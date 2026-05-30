using MessagePack;

namespace Meeko.Contracts.Notice.Channels;

[MessagePackObject]
public sealed class CreateSmtpProviderCommand
{
    [Key(0)] public string Name { get; set; } = string.Empty;
    [Key(1)] public string Host { get; set; } = string.Empty;
    [Key(2)] public int Port { get; set; } = 587;
    [Key(3)] public string? Username { get; set; }
    [Key(4)] public string? Password { get; set; }
    [Key(5)] public bool UseStartTls { get; set; } = true;
    [Key(6)] public string FromAddress { get; set; } = string.Empty;
    [Key(7)] public string FromName { get; set; } = string.Empty;
    [Key(8)] public bool IsActive { get; set; } = true;
    [Key(9)] public bool IsDefault { get; set; }
    [Key(10)] public int Priority { get; set; }
}
