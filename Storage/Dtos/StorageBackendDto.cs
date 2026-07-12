using MessagePack;

namespace Meeko.Contracts.Storage.Dtos;

[MessagePackObject]
public sealed class StorageBackendDto
{
    [Key(0)]  public long Id { get; set; }
    [Key(1)]  public string Name { get; set; } = string.Empty;
    [Key(2)]  public string ProviderType { get; set; } = string.Empty;
    [Key(3)]  public string Endpoint { get; set; } = string.Empty;
    [Key(4)]  public string Region { get; set; } = string.Empty;
    [Key(5)]  public string Bucket { get; set; } = string.Empty;
    [Key(6)]  public string? PublicEndpoint { get; set; }
    [Key(7)]  public string? CdnBaseUrl { get; set; }
    [Key(8)]  public string AccessKeyId { get; set; } = string.Empty;
    [Key(9)]  public bool AccessKeySecretConfigured { get; set; }
    [Key(10)] public string? LocalRoot { get; set; }
    [Key(11)] public bool IsActive { get; set; }
    [Key(12)] public bool IsDefault { get; set; }
    [Key(13)] public DateTime CreatedAtUtc { get; set; }
    [Key(14)] public DateTime UpdatedAtUtc { get; set; }
}
