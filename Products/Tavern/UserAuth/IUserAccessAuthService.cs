using MagicOnion;
using Meeko.Contracts.Gateway.Auth;

namespace Meeko.Contracts.Tavern.UserAuth;

/// <summary>
/// Hosted Tavern.Gateway → Meeko.Tavern：JWT 验签公钥 + 撤销查询（Keystone 仅在平台内可见）。
/// </summary>
public interface IUserAccessAuthService : IService<IUserAccessAuthService>
{
    /// <summary>ES256 验签公钥；平台内转发 Keystone InternalRpc，网关不走 HTTP JWKS。</summary>
    UnaryResult<JwtSigningKeySet> GetJwtSigningKeysAsync();

    UnaryResult<bool> IsAccessTokenRevokedAsync(string jti);
}
