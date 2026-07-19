using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class AlipayConfig
{
    [Key(0)] public AlipayAppConfig? App { get; set; }
    [Key(1)] public AlipayCredentialsConfig? Credentials { get; set; }
    [Key(2)] public AlipayEndpointsConfig? Endpoints { get; set; }
    [Key(3)] public string? Environment { get; set; }
}
