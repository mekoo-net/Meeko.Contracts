using MagicOnion;
using MessagePack;

namespace Meeko.Contracts.Diagnostics;

[MessagePackObject]
public sealed class PingRequest
{
    [Key(0)]
    public string Message { get; set; } = string.Empty;
}
