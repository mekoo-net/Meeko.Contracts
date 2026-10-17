using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class VoidRedemptionCodeCommand
{
    [Key(0)] public long CodeId { get; set; }

    /// <summary>作废原因，记在卡上。</summary>
    [Key(1)] public required string Reason { get; set; }
}
