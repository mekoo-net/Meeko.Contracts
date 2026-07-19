using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class WechatPayEndpointsConfig
{
    [Key(0)] public string? Gateway { get; set; }
    [Key(1)] public string? NotifyUrl { get; set; }
}
