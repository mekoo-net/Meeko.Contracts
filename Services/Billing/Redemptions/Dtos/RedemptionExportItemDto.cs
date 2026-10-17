using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class RedemptionExportItemDto
{
    [Key(0)] public required string Code { get; set; }
    [Key(1)] public RedemptionCodeStatus Status { get; set; }
    [Key(2)] public DateTime? RedeemedAtUtc { get; set; }
    [Key(3)] public RedemptionAccountRefDto? RedeemedBy { get; set; }
}
