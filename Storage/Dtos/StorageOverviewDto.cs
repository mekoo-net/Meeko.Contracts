using MessagePack;

namespace Meeko.Contracts.Storage.Dtos;

[MessagePackObject]
public sealed class StorageOverviewDto
{
    [Key(0)] public int BackendCount { get; set; }
    [Key(1)] public int ActiveBackendCount { get; set; }
    [Key(2)] public long TotalObjectCount { get; set; }
    [Key(3)] public long TotalBytes { get; set; }
    [Key(4)] public int OrphanedObjectCount { get; set; }
    [Key(5)] public int PendingUploadCount { get; set; }
    [Key(6)] public int ActiveRefCount { get; set; }
    [Key(7)] public StorageBackendUsageDto[] Backends { get; set; } = [];
}

[MessagePackObject]
public sealed class StorageBackendUsageDto
{
    [Key(0)] public long BackendId { get; set; }
    [Key(1)] public string Name { get; set; } = string.Empty;
    [Key(2)] public string ProviderType { get; set; } = string.Empty;
    [Key(3)] public bool IsActive { get; set; }
    [Key(4)] public bool IsDefault { get; set; }
    [Key(5)] public long ObjectCount { get; set; }
    [Key(6)] public long TotalBytes { get; set; }
    [Key(7)] public int OrphanedCount { get; set; }
    [Key(8)] public int ActiveRefCount { get; set; }
    [Key(9)] public int PendingUploadCount { get; set; }
}
