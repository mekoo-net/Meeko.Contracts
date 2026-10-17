using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class VoidRedemptionBatchCommand
{
    [Key(0)] public required string BatchId { get; set; }
}
