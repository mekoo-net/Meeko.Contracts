using MessagePack;

namespace Meeko.Contracts.Keystone;

[MessagePackObject]
public sealed class ListAccountsQuery
{
    [Key(0)] public int Page { get; set; } = 1;
    [Key(1)] public int PageSize { get; set; } = 20;
    [Key(2)] public long? AccountUid { get; set; }
    [Key(3)] public string? ContactKeyword { get; set; }

    /// <summary>"personal" / "organization" / null/"all" 不筛。</summary>
    [Key(4)] public string? Type { get; set; }

    /// <summary>"active" / "suspended" / "deleted" / null/"all" 不筛。</summary>
    [Key(5)] public string? Status { get; set; }
}
