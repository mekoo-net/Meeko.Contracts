using MessagePack;

namespace Meeko.Contracts.Notice.Channels;

[MessagePackObject]
public sealed class TestSmtpProviderResult
{
    [Key(0)] public bool Success { get; set; }
    [Key(1)] public string? ProviderMessageId { get; set; }
    [Key(2)] public int ElapsedMs { get; set; }
    [Key(3)] public string? FailureCode { get; set; }
    [Key(4)] public string? FailureMessage { get; set; }
}
