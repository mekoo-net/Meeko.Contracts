using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class ListBillsQuery
{
    [Key(0)] public int Page { get; set; } = 1;
    [Key(1)] public int PageSize { get; set; } = 20;
    [Key(2)] public long? AccountUid { get; set; }
    [Key(3)] public string? ProductCode { get; set; }
    [Key(4)] public string? SubType { get; set; }
    [Key(5)] public string? Status { get; set; }
    [Key(6)] public DateTime? FromUtc { get; set; }
    [Key(7)] public DateTime? ToUtc { get; set; }

    /// <summary>按抵扣券（用户券 Id）筛选：仅返回该券抵扣过的账单；0 或缺省表示不筛选。</summary>
    [Key(8)] public long? UserVoucherId { get; set; }
}
