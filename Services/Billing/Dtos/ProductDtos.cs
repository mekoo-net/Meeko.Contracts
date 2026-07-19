using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class ProductDto
{
    [Key(0)] public required string Code { get; set; }
    [Key(2)] public required string DisplayName { get; set; }
    [Key(3)] public string? MetadataJson { get; set; }
    [Key(4)] public bool Active { get; set; }
    [Key(5)] public DateTime CreatedAtUtc { get; set; }
    [Key(6)] public DateTime UpdatedAtUtc { get; set; }
}

[MessagePackObject]
public sealed class ProductListResult
{
    [Key(0)] public ProductDto[] Items { get; set; } = [];
}

[MessagePackObject]
public sealed class DiscoveredProductDto
{
    [Key(0)] public required string Code { get; set; }
    [Key(2)] public required string SuggestedDisplayName { get; set; }
    [Key(3)] public bool AlreadyRegistered { get; set; }
    [Key(4)] public required string ServiceName { get; set; }
}

[MessagePackObject]
public sealed class DiscoveredProductListResult
{
    [Key(0)] public DiscoveredProductDto[] Items { get; set; } = [];
}

[MessagePackObject]
public sealed class RegisterDiscoveredProductCommand
{
    [Key(0)] public required string Code { get; set; }
    [Key(1)] public string? DisplayName { get; set; }
}

[MessagePackObject]
public sealed class UpdateProductCommand
{
    [Key(0)] public required string Code { get; set; }
    [Key(1)] public string? DisplayName { get; set; }
    [Key(2)] public string? MetadataJson { get; set; }
}
