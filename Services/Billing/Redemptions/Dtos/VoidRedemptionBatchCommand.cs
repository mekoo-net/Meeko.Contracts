using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class VoidRedemptionBatchCommand
{
    [Key(0)] public required string BatchId { get; set; }

    /// <summary>作废原因，记在被作废的卡上。</summary>
    [Key(1)] public required string Reason { get; set; }
}
