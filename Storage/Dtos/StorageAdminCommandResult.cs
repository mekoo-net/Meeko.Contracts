using MessagePack;

namespace Meeko.Contracts.Storage.Dtos;

[MessagePackObject]
public sealed class StorageAdminCommandResult
{
    [Key(0)] public bool Success { get; set; }
    [Key(1)] public long Id { get; set; }
    [Key(2)] public string? FailureCode { get; set; }
    [Key(3)] public string? FailureMessage { get; set; }

    public static StorageAdminCommandResult Ok(long id) => new() { Success = true, Id = id };
    public static StorageAdminCommandResult Fail(string code, string msg) => new() { FailureCode = code, FailureMessage = msg };
}
