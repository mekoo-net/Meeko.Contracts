using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class AlipayCredentialsConfig
{
    [Key(0)] public string? AppPrivateKey { get; set; }
    [Key(1)] public string? AlipayPublicKey { get; set; }
}
