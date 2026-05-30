using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class WechatPayCredentialsConfig
{
    [Key(0)] public string? ApiV3Key { get; set; }
    [Key(1)] public string? MerchantPrivateKey { get; set; }
    [Key(2)] public string? WechatPlatformCert { get; set; }
}
