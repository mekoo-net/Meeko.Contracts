using MessagePack;

namespace Meeko.Contracts.Storage.Dtos;

[MessagePackObject]
public sealed class ListStorageObjectsQuery
{
    [Key(0)] public int Page { get; set; } = 1;
    [Key(1)] public int PageSize { get; set; } = 20;
    [Key(2)] public long? AccountUid { get; set; }
    [Key(3)] public string? Product { get; set; }
    [Key(4)] public string? Purpose { get; set; }
    [Key(5)] public string? Sha256 { get; set; }
    [Key(6)] public string? MimePrefix { get; set; }
    [Key(7)] public string? Status { get; set; }
    [Key(8)] public long? BackendId { get; set; }
}

[MessagePackObject]
public sealed class BrowseStorageObjectsQuery
{
    [Key(0)] public string Prefix { get; set; } = string.Empty;
    [Key(1)] public int Page { get; set; } = 1;
    [Key(2)] public int PageSize { get; set; } = 50;
    [Key(3)] public long? BackendId { get; set; }
}

[MessagePackObject]
public sealed class BrowseStorageObjectsResult
{
    [Key(0)] public string Prefix { get; set; } = string.Empty;
    [Key(1)] public string[] CommonPrefixes { get; set; } = [];
    [Key(2)] public StorageObjectListItemDto[] Items { get; set; } = [];
    [Key(3)] public int Total { get; set; }
}

[MessagePackObject]
public sealed class StorageObjectListItemDto
{
    [Key(0)] public long Id { get; set; }
    [Key(1)] public string StorageKey { get; set; } = string.Empty;
    [Key(2)] public string Sha256 { get; set; } = string.Empty;
    [Key(3)] public long BackendId { get; set; }
    [Key(4)] public string BackendName { get; set; } = string.Empty;
    [Key(5)] public long CreatedByUid { get; set; }
    [Key(6)] public string Mime { get; set; } = string.Empty;
    [Key(7)] public long Size { get; set; }
    [Key(8)] public string Status { get; set; } = string.Empty;
    [Key(9)] public DateTime CreatedAtUtc { get; set; }
    [Key(10)] public int ActiveRefCount { get; set; }
    [Key(11)] public int TotalRefCount { get; set; }
    [Key(12)] public string[] Products { get; set; } = [];
    [Key(13)] public string[] Purposes { get; set; } = [];
    [Key(14)] public string? PublicUrl { get; set; }
}

[MessagePackObject]
public sealed class ListStorageObjectsResult
{
    [Key(0)] public StorageObjectListItemDto[] Items { get; set; } = [];
    [Key(1)] public int Total { get; set; }
}
