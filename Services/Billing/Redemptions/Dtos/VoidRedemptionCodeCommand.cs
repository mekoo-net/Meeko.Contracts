using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class VoidRedemptionCodeCommand
{
    [Key(0)] public long CodeId { get; set; }
    [Key(1)] public required string Reason { get; set; }
    [Key(2)] public long OperatorStaffUid { get; set; }
}
