using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class ReferralAccountSummaryDto
{
    [Key(0)] public int InviteCount { get; set; }

    [Key(1)] public decimal TotalRebateAmount { get; set; }

    [Key(2)] public decimal WithdrawableAmount { get; set; }

    [Key(3)] public decimal WithdrawnAmount { get; set; }

    [Key(4)] public string Currency { get; set; } = "CNY";
}
