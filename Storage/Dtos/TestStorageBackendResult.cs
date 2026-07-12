using MessagePack;

namespace Meeko.Contracts.Storage.Dtos;

[MessagePackObject]
public sealed class TestStorageBackendResult
{
    [Key(0)] public bool Success { get; set; }
    [Key(1)] public int ElapsedMs { get; set; }
    [Key(2)] public string? FailureCode { get; set; }
    [Key(3)] public string? FailureMessage { get; set; }
}
