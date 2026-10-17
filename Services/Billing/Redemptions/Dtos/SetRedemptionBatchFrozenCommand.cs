using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class SetRedemptionBatchFrozenCommand
{
    [Key(0)] public required string BatchId { get; set; }
    [Key(1)] public bool Frozen { get; set; }

    /// <summary>冻结原因，记在连带冻结的卡上；解冻不需要。</summary>
    [Key(2)] public string? Reason { get; set; }
}
