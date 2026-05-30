using MessagePack;

namespace Meeko.Contracts.DemuxAi.Admin;

[MessagePackObject]
public sealed class ProviderGroupDto
{
    [Key(0)] public string QueueGroup { get; set; } = string.Empty;
    [Key(1)] public string DisplayName { get; set; } = string.Empty;
    [Key(2)] public string Status { get; set; } = "active";
    [Key(3)] public int UpstreamModelCount { get; set; }
    [Key(4)] public string? Notes { get; set; }
    [Key(5)] public DateTime ImportedAtUtc { get; set; }
    [Key(6)] public DateTime UpdatedAtUtc { get; set; }
}

[MessagePackObject]
public sealed class ProviderUpstreamModelDto
{
    [Key(0)] public string QueueGroup { get; set; } = string.Empty;
    [Key(1)] public string UpstreamModelId { get; set; } = string.Empty;
    [Key(2)] public string? Label { get; set; }
}

[MessagePackObject]
public sealed class DiscoveredUpstreamModelDto
{
    [Key(0)] public string UpstreamModelId { get; set; } = string.Empty;
    [Key(1)] public string? Label { get; set; }
    [Key(2)] public bool AlreadyImported { get; set; }
}

[MessagePackObject]
public sealed class DiscoveredProviderGroupDto
{
    [Key(0)] public string QueueGroup { get; set; } = string.Empty;
    [Key(1)] public string DisplayName { get; set; } = string.Empty;
    [Key(2)] public bool AlreadyImported { get; set; }
    [Key(3)] public DiscoveredUpstreamModelDto[] Models { get; set; } = [];
}

[MessagePackObject]
public sealed class DiscoverCatalogResultDto
{
    [Key(0)] public DiscoveredProviderGroupDto[] Groups { get; set; } = [];
    [Key(1)] public DateTime DiscoveredAtUtc { get; set; }
}

[MessagePackObject]
public sealed class ImportUpstreamModelPayload
{
    [Key(0)] public string UpstreamModelId { get; set; } = string.Empty;
    [Key(1)] public string? Label { get; set; }
}

[MessagePackObject]
public sealed class ImportProviderGroupPayload
{
    [Key(0)] public string QueueGroup { get; set; } = string.Empty;
    [Key(1)] public string DisplayName { get; set; } = string.Empty;
    [Key(2)] public string? Notes { get; set; }
    [Key(3)] public ImportUpstreamModelPayload[] Models { get; set; } = [];
}

[MessagePackObject]
public sealed class ImportProviderGroupResultDto
{
    [Key(0)] public string QueueGroup { get; set; } = string.Empty;
    [Key(1)] public int ImportedModelCount { get; set; }
    [Key(2)] public DateTime ImportedAtUtc { get; set; }
}
