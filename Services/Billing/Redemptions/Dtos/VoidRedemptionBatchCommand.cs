using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class VoidRedemptionBatchCommand
{
    [Key(0)] public required string BatchId { get; set; }
    [Key(1)] public required string Reason { get; set; }
    [Key(2)] public long OperatorStaffUid { get; set; }
}
