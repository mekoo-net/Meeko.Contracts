using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class RedemptionAttemptListResult
{
    [Key(0)] public RedemptionAttemptDto[] Items { get; set; } = [];
    [Key(1)] public int Total { get; set; }
}
