using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class RedemptionOverviewDto
{
    [Key(0)] public int BatchCount { get; set; }
    [Key(1)] public int IssuedCount { get; set; }
    [Key(2)] public decimal IssuedValue { get; set; }
    [Key(3)] public int RedeemedCount { get; set; }
    [Key(4)] public decimal RedeemedValue { get; set; }

    /// <summary>仍可兑换（批次生效中）的卡密：已卖出未兑即平台预收负债。</summary>
    [Key(5)] public int OutstandingCount { get; set; }
    [Key(6)] public decimal OutstandingValue { get; set; }
    [Key(7)] public int TodayRedeemedCount { get; set; }
    [Key(8)] public decimal TodayRedeemedValue { get; set; }
    [Key(9)] public int FailedAttempts24h { get; set; }

    /// <summary>近 24 小时失败次数达到阈值的 IP 数。</summary>
    [Key(10)] public int SuspiciousIps24h { get; set; }
}
