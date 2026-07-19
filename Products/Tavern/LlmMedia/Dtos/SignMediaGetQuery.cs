using MessagePack;

namespace Meeko.Contracts.Tavern.LlmMedia.Dtos;

[MessagePackObject]
public sealed class SignMediaGetQuery
{
    [Key(0)] public string FinalUrl { get; set; } = string.Empty;
    [Key(1)] public int TtlSeconds { get; set; } = 600;
    /// <summary>私有媒体优先用 storage key；公开层可只用 FinalUrl。</summary>
    [Key(2)] public string? StorageKey { get; set; }
    /// <summary>私有层 SignGet 鉴权所需；网关从 ticket 填入。</summary>
    [Key(3)] public long AccountUid { get; set; }
}
