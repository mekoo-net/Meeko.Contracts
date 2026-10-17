using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class ListRedemptionAttemptsQuery
{
    [Key(0)] public int Page { get; set; } = 1;
    [Key(1)] public int PageSize { get; set; } = 20;
    [Key(2)] public RedemptionAttemptResult? Result { get; set; }

    /// <summary>只看失败（除 success 外的全部结果）；与 <see cref="Result"/> 同时给出时以 Result 为准。</summary>
    [Key(3)] public bool FailedOnly { get; set; }

    /// <summary>提交账户；语义同 <see cref="SearchRedemptionCodesQuery.AccountUids"/>。</summary>
    [Key(4)] public long[]? AccountUids { get; set; }

    /// <summary>前缀匹配。</summary>
    [Key(5)] public string? Ip { get; set; }

    [Key(6)] public long? CodeId { get; set; }
    [Key(7)] public string? BatchId { get; set; }
    [Key(8)] public DateTime? FromUtc { get; set; }
    [Key(9)] public DateTime? ToUtc { get; set; }

    /// <summary>提交时所在的业务，精确匹配。</summary>
    [Key(10)] public string? ProductCode { get; set; }
}
