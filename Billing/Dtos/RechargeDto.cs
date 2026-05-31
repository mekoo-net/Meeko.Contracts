using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class RechargeDto
{
    /// <summary>对外显示形如 "RC20260531000001234"（前缀 + UTC 日期 + 9 位序列）。</summary>
    [Key(0)] public required string Id { get; set; }

    [Key(1)] public required RechargeOwnerInfo Owner { get; set; }

    [Key(2)] public required RechargeSourceInfo Source { get; set; }

    [Key(3)] public required RechargeAmountInfo Amount { get; set; }

    /// <summary>pending / paid / expired / cancelled / failed / refunded。</summary>
    [Key(4)] public required string Status { get; set; }

    /// <summary>仅 manual / cs_compensation / marketing_reward 三类内部入账有值。</summary>
    [Key(5)] public RechargeOperatorInfo? Operator { get; set; }

    [Key(6)] public DateTime CreatedAtUtc { get; set; }

    [Key(7)] public DateTime? PaidAtUtc { get; set; }
}
