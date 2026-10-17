using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class SetRedemptionBatchFrozenCommand
{
    [Key(0)] public required string BatchId { get; set; }
    [Key(1)] public bool Frozen { get; set; }
}
