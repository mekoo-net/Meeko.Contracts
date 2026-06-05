using MessagePack;

namespace Meeko.Contracts.DemuxAi.Admin;

[MessagePackObject]
public sealed class ModelRouteDto
{
    [Key(0)] public long Uid { get; set; }
    [Key(1)] public string Alias { get; set; } = string.Empty;
    [Key(2)] public string VendorKey { get; set; } = string.Empty;
    [Key(3)] public string VendorModel { get; set; } = string.Empty;
    [Key(4)] public bool IsPublished { get; set; }
    [Key(5)] public string? Notes { get; set; }
    [Key(6)] public DateTime CreatedAtUtc { get; set; }
    [Key(7)] public DateTime UpdatedAtUtc { get; set; }
}

[MessagePackObject]
public sealed class ModelRouteWritePayload
{
    [Key(0)] public string Alias { get; set; } = string.Empty;
    [Key(1)] public string VendorKey { get; set; } = string.Empty;
    [Key(2)] public string VendorModel { get; set; } = string.Empty;
    [Key(3)] public bool? IsPublished { get; set; }
    [Key(4)] public string? Notes { get; set; }
}

[MessagePackObject]
public sealed class ModelRoutePublishedPayload
{
    [Key(0)] public bool IsPublished { get; set; }
}
