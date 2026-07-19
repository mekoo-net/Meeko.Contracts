using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class ReferralWithdrawalDto
{
    [Key(0)] public required string Id { get; set; }

    [Key(1)] public decimal Amount { get; set; }

    [Key(2)] public string Currency { get; set; } = "CNY";

    /// <summary>alipay / bank。</summary>
    [Key(3)] public required string Method { get; set; }

    [Key(4)] public required string AccountNo { get; set; }

    [Key(5)] public required string AccountName { get; set; }

    /// <summary>pending / approved / rejected / paid。</summary>
    [Key(6)] public required string Status { get; set; }

    [Key(7)] public string? RejectReason { get; set; }

    [Key(8)] public DateTime AppliedAtUtc { get; set; }

    [Key(9)] public DateTime? ReviewedAtUtc { get; set; }

    [Key(10)] public DateTime? PaidAtUtc { get; set; }

    [Key(11)] public long AccountUid { get; set; }
}
