using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class AlipayEndpointsConfig
{
    [Key(0)] public string? Gateway { get; set; }
    [Key(1)] public string? NotifyUrl { get; set; }
    [Key(2)] public string? ReturnUrl { get; set; }
}
