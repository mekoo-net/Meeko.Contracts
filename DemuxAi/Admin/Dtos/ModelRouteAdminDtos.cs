using MessagePack;

namespace Meeko.Contracts.DemuxAi.Admin;

[MessagePackObject]
public sealed class ModelRouteDto
{
    [Key(0)] public long Uid { get; set; }
    [Key(1)] public string Alias { get; set; } = string.Empty;
    [Key(2)] public string VendorKey { get; set; } = string.Empty;
    [Key(3)] public string VendorModel { get; set; } = string.Empty;
    [Key(4)] public int Weight { get; set; }
    [Key(5)] public int Priority { get; set; }
    [Key(6)] public string Status { get; set; } = "enabled";
    [Key(7)] public string? Notes { get; set; }
    [Key(8)] public DateTime CreatedAtUtc { get; set; }
    [Key(9)] public DateTime UpdatedAtUtc { get; set; }
}

[MessagePackObject]
public sealed class ModelRouteWritePayload
{
    [Key(0)] public string Alias { get; set; } = string.Empty;
    [Key(1)] public string VendorKey { get; set; } = string.Empty;
    [Key(2)] public string VendorModel { get; set; } = string.Empty;
    [Key(3)] public int? Weight { get; set; }
    [Key(4)] public int? Priority { get; set; }
    [Key(5)] public string? Status { get; set; }
    [Key(6)] public string? Notes { get; set; }
}

[MessagePackObject]
public sealed class ModelRouteStatusPayload
{
    [Key(0)] public string Status { get; set; } = "enabled";
}
