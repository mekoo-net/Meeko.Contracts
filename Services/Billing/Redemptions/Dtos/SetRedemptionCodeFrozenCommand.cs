using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class SetRedemptionCodeFrozenCommand
{
    [Key(0)] public long CodeId { get; set; }
    [Key(1)] public bool Frozen { get; set; }
    [Key(2)] public required string Reason { get; set; }
    [Key(3)] public long OperatorStaffUid { get; set; }
}
