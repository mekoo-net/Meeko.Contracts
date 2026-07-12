using MessagePack;

namespace Meeko.Contracts.Storage.Dtos;

/// <summary>一个物理对象的一条逻辑引用：谁、什么时候、以什么用途引用。</summary>
[MessagePackObject]
public sealed class StorageObjectRefDto
{
    [Key(0)] public long Id { get; set; }
    [Key(1)] public long AccountUid { get; set; }
    [Key(2)] public string Product { get; set; } = string.Empty;
    [Key(3)] public string Purpose { get; set; } = string.Empty;
    [Key(4)] public string? RefKey { get; set; }

    /// <summary>pending / committed / released。</summary>
    [Key(5)] public string Status { get; set; } = string.Empty;

    [Key(6)] public DateTime CreatedAtUtc { get; set; }
    [Key(7)] public DateTime LastSeenAtUtc { get; set; }
    [Key(8)] public DateTime? ReleasedAtUtc { get; set; }
}

/// <summary>对象引用溯源查询结果：物理对象元数据 + 全部引用（含已释放）。</summary>
[MessagePackObject]
public sealed class StorageObjectRefsResult
{
    [Key(0)] public bool Found { get; set; }
    [Key(1)] public string StorageKey { get; set; } = string.Empty;
    [Key(2)] public string? Sha256 { get; set; }

    /// <summary>首传者（审计）。</summary>
    [Key(3)] public long CreatedByUid { get; set; }

    [Key(4)] public DateTime CreatedAtUtc { get; set; }
    [Key(5)] public long Size { get; set; }
    [Key(6)] public string Mime { get; set; } = string.Empty;
    [Key(7)] public StorageObjectRefDto[] Refs { get; set; } = [];
}
