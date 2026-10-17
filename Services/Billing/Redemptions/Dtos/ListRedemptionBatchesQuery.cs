using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class ListRedemptionBatchesQuery
{
    [Key(0)] public int Page { get; set; } = 1;
    [Key(1)] public int PageSize { get; set; } = 20;

    /// <summary>批次流水号，模糊匹配。</summary>
    [Key(2)] public string? BatchId { get; set; }

    [Key(3)] public string? Name { get; set; }
    [Key(4)] public string? SalesChannel { get; set; }
    [Key(5)] public RedemptionBatchStatus? Status { get; set; }

    /// <summary>创建时间范围。</summary>
    [Key(6)] public DateTime? FromUtc { get; set; }
    [Key(7)] public DateTime? ToUtc { get; set; }
    [Key(8)] public RedemptionPurpose? Purpose { get; set; }
}
