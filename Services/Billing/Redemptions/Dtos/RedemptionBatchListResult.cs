using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class RedemptionBatchListResult
{
    [Key(0)] public RedemptionBatchDto[] Items { get; set; } = [];
    [Key(1)] public int Total { get; set; }
}
