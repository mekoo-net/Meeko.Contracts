using MessagePack;

namespace Meeko.Contracts.Billing;

/// <summary>
/// 发卡付（聚合发卡网）渠道配置。鉴权采用 TOTP 风格动态码，
/// <see cref="AppSecret"/> 仅本地参与 HMAC 派生动态码，永不在网络上传输。
/// GET 时服务侧脱敏（仅留后 4 位）；PUT 接收明文，服务侧入库。
/// </summary>
[MessagePackObject]
public sealed class FkPayConfig
{
    /// <summary>网关基础地址，例 http://your-gateway:8080。</summary>
    [Key(0)] public string? BaseUrl { get; set; }

    /// <summary>商户 AppId。</summary>
    [Key(1)] public string? AppId { get; set; }

    /// <summary>商户密钥（仅本地派生动态码用）。</summary>
    [Key(2)] public string? AppSecret { get; set; }
}
