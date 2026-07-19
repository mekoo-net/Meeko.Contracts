using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class WechatPayConfig
{
    [Key(0)] public WechatPayAppConfig? App { get; set; }
    [Key(1)] public WechatPayCredentialsConfig? Credentials { get; set; }
    [Key(2)] public WechatPayEndpointsConfig? Endpoints { get; set; }
    [Key(3)] public string? Environment { get; set; }
}
