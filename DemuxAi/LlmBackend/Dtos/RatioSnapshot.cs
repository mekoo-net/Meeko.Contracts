using MessagePack;

namespace Meeko.Contracts.DemuxAi.LlmBackend;

[MessagePackObject]
public sealed class RatioSnapshot
{
    [Key(0)] public int Version { get; set; }
    [Key(1)] public DateTime UpdatedAtUtc { get; set; }
    [Key(2)] public string[] Items { get; set; } = [];
    [Key(3)] public string[] DeletedKeys { get; set; } = [];
}
