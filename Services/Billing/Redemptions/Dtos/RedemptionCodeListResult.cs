using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class RedemptionCodeListResult
{
    [Key(0)] public RedemptionCodeDto[] Items { get; set; } = [];
    [Key(1)] public int Total { get; set; }
}
