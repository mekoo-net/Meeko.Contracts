using MessagePack;

namespace Meeko.Contracts.Tavern.LlmMedia.Dtos;

[MessagePackObject]
public sealed class SignMediaGetQuery
{
    [Key(0)] public string FinalUrl { get; set; } = string.Empty;
    [Key(1)] public int TtlSeconds { get; set; } = 600;
}
