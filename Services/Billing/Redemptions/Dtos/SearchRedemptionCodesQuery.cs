using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class SearchRedemptionCodesQuery
{
    [Key(0)] public int Page { get; set; } = 1;
    [Key(1)] public int PageSize { get; set; } = 20;

    /// <summary>完整卡密（精确匹配，忽略大小写和分隔符）或末 4 位。</summary>
    [Key(2)] public string? Code { get; set; }

    [Key(3)] public string? BatchId { get; set; }
    [Key(4)] public RedemptionCodeStatus? Status { get; set; }

    /// <summary>兑换账户；BFF 已把 uid / 邮箱条件解析成 uid 列表。null 不筛，空数组表示无匹配账户。</summary>
    [Key(5)] public long[]? AccountUids { get; set; }

    /// <summary>兑换 IP，前缀匹配。</summary>
    [Key(6)] public string? Ip { get; set; }

    /// <summary>兑换时间范围。</summary>
    [Key(7)] public DateTime? FromUtc { get; set; }
    [Key(8)] public DateTime? ToUtc { get; set; }
}
