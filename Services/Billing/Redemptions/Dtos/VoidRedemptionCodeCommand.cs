using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class VoidRedemptionCodeCommand
{
    [Key(0)] public long CodeId { get; set; }
}
