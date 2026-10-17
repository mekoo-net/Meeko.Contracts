using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class SetRedemptionCodeFrozenCommand
{
    [Key(0)] public long CodeId { get; set; }
    [Key(1)] public bool Frozen { get; set; }
}
