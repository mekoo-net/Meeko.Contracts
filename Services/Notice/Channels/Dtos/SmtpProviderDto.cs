using MessagePack;

namespace Meeko.Contracts.Notice.Channels;

[MessagePackObject]
public sealed class SmtpProviderDto
{
    [Key(0)]  public long Id { get; set; }
    [Key(1)]  public string Name { get; set; } = string.Empty;
    [Key(2)]  public string Host { get; set; } = string.Empty;
    [Key(3)]  public int Port { get; set; }
    [Key(4)]  public string? Username { get; set; }
    [Key(5)]  public bool UseStartTls { get; set; }
    [Key(6)]  public string FromAddress { get; set; } = string.Empty;
    [Key(7)]  public string FromName { get; set; } = string.Empty;
    [Key(8)]  public bool IsActive { get; set; }
    [Key(9)]  public bool IsDefault { get; set; }
    [Key(10)] public int Priority { get; set; }
    [Key(11)] public DateTime CreatedAtUtc { get; set; }
    [Key(12)] public DateTime UpdatedAtUtc { get; set; }
}
