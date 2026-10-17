using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class SetRedemptionBatchFrozenCommand
{
    [Key(0)] public required string BatchId { get; set; }
    [Key(1)] public bool Frozen { get; set; }
    [Key(2)] public required string Reason { get; set; }
    [Key(3)] public long OperatorStaffUid { get; set; }
}
