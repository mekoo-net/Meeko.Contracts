using MagicOnion;
using Meeko.Common.Auth;

namespace Meeko.Contracts.Demux.UserAuth;

/// <summary>
/// Hosted Demux.Gateway → Meeko.Demux：JWT 验签公钥 + 撤销查询（Keystone 仅在平台内可见）。
/// </summary>
public interface IUserAccessAuthService : IService<IUserAccessAuthService>
{
    /// <summary>ES256 验签公钥；平台内转发 Keystone InternalRpc，网关不走 HTTP JWKS。</summary>
    UnaryResult<JwtSigningKeySet> GetJwtSigningKeysAsync();

    UnaryResult<bool> IsAccessTokenRevokedAsync(string jti);

    /// <summary>Keystone account 域 RBAC：按角色名查 permission（Demux.Gateway 管理面鉴权）。</summary>
    UnaryResult<bool> HasAccountPermissionAsync(string roleName, string permissionCode);
}
