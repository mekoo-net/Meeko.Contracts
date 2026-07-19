using MessagePack;

namespace Meeko.Contracts.Tavern.Metering.Dtos;

[MessagePackObject]
public sealed class ReserveTavernTurnCommand
{
    [Key(0)] public long AccountUid { get; set; }
    /// <summary>回合幂等键（建议 assistantMessageId 或 W3C trace id）。</summary>
    [Key(1)] public string TraceId { get; set; } = string.Empty;
    [Key(2)] public string ModelName { get; set; } = string.Empty;
    [Key(3)] public int EstimatedPromptTokens { get; set; }
    [Key(4)] public string? VendorKey { get; set; }
    /// <summary>自主唤醒回合为 true，平台选用 proactive 计量维度。</summary>
    [Key(5)] public bool Proactive { get; set; }
}
