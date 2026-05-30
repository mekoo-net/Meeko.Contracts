using MessagePack;

namespace Meeko.Contracts.Notice.Channels;

[MessagePackObject]
public sealed class UpdateSmtpProviderCommand
{
    [Key(0)] public long Id { get; set; }
    [Key(1)] public string Name { get; set; } = string.Empty;
    [Key(2)] public string Host { get; set; } = string.Empty;
    [Key(3)] public int Port { get; set; }
    [Key(4)] public string? Username { get; set; }
    /// <summary>非 null 则更新口令；null 表示保留旧值。</summary>
    [Key(5)] public string? Password { get; set; }
    [Key(6)] public bool UseStartTls { get; set; }
    [Key(7)] public string FromAddress { get; set; } = string.Empty;
    [Key(8)] public string FromName { get; set; } = string.Empty;
    [Key(9)] public bool IsActive { get; set; }
    [Key(10)] public bool IsDefault { get; set; }
    [Key(11)] public int Priority { get; set; }
}
