using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class AlipayAppConfig
{
    [Key(0)] public string? AppId { get; set; }
    [Key(1)] public string? SignType { get; set; }
}
