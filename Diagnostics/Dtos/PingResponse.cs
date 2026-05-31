using MagicOnion;
using MessagePack;

namespace Meeko.Contracts.Diagnostics;

[MessagePackObject]
public sealed class PingResponse
{
    [Key(0)]
    public string Echo { get; set; } = string.Empty;

    [Key(1)]
    public string ServerName { get; set; } = string.Empty;

    [Key(2)]
    public DateTimeOffset ServerTimeUtc { get; set; }

    [Key(3)]
    public string? CallerUserId { get; set; }
}
