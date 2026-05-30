using MessagePack;

namespace Meeko.Contracts.DemuxAi.LlmBackend;

[MessagePackObject]
public sealed class ReserveQuotaCommand
{
    [Key(0)] public long TokenId { get; set; }
    [Key(1)] public long AccountUid { get; set; }
    [Key(2)] public string ModelName { get; set; } = string.Empty;
    /// <summary>调用方估算的 prompt token 数；DemuxAi 用 ratios[model] 自己换算成预扣金额。</summary>
    [Key(3)] public int EstimatedPromptTokens { get; set; }
    /// <summary>可选：估算 completion token 数。缺省时 DemuxAi 用 prompt × 默认系数兜底。</summary>
    [Key(4)] public int? EstimatedCompletionTokens { get; set; }
    [Key(5)] public TimeSpan? Ttl { get; set; }
    /// <summary>幂等键。建议用上游 request_id；同一键多次调用返回同一 ReservationUid。</summary>
    [Key(6)] public string RequestId { get; set; } = string.Empty;
    [Key(7)] public string? ClientIp { get; set; }
}
