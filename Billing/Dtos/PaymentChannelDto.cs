using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class PaymentChannelDto
{
    [Key(0)] public required string Code { get; set; }
    [Key(1)] public required string DisplayName { get; set; }
    [Key(2)] public required bool IsActive { get; set; }
    [Key(3)] public required bool IsConfigured { get; set; }
    [Key(4)] public required string[] SupportedScenes { get; set; }
}
