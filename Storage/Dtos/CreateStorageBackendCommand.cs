using MessagePack;

namespace Meeko.Contracts.Storage.Dtos;

[MessagePackObject]
public sealed class CreateStorageBackendCommand
{
    [Key(0)]  public string Name { get; set; } = string.Empty;
    [Key(1)]  public string ProviderType { get; set; } = string.Empty;
    [Key(2)]  public string Endpoint { get; set; } = string.Empty;
    [Key(3)]  public string Region { get; set; } = string.Empty;
    [Key(4)]  public string Bucket { get; set; } = string.Empty;
    [Key(5)]  public string? PublicEndpoint { get; set; }
    [Key(6)]  public string? CdnBaseUrl { get; set; }
    [Key(7)]  public string AccessKeyId { get; set; } = string.Empty;
    [Key(8)]  public string? AccessKeySecret { get; set; }
    [Key(9)]  public string? LocalRoot { get; set; }
    [Key(10)] public bool IsActive { get; set; } = true;
    [Key(11)] public bool IsDefault { get; set; }
}
