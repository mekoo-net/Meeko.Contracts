using MessagePack;

namespace Meeko.Contracts.Notice.Channels;

[MessagePackObject]
public sealed class TestSmtpProviderCommand
{
    [Key(0)] public long Id { get; set; }
    [Key(1)] public string Recipient { get; set; } = string.Empty;
    [Key(2)] public string? Subject { get; set; }
    [Key(3)] public string? Body { get; set; }
}
