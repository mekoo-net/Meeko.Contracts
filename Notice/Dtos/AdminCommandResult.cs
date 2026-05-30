using MessagePack;

namespace Meeko.Contracts.Notice.Channels;

[MessagePackObject]
public sealed class AdminCommandResult
{
    [Key(0)] public bool Success { get; set; }
    [Key(1)] public long Id { get; set; }
    [Key(2)] public string? FailureCode { get; set; }
    [Key(3)] public string? FailureMessage { get; set; }

    public static AdminCommandResult Ok(long id) => new() { Success = true, Id = id };
    public static AdminCommandResult Fail(string code, string msg) => new() { FailureCode = code, FailureMessage = msg };
}
