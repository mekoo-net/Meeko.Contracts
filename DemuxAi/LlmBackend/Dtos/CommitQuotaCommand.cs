using MessagePack;

namespace Meeko.Contracts.DemuxAi.LlmBackend;

[MessagePackObject]
public sealed class CommitQuotaCommand
{
    /// <summary>非 null 走"预扣 → 提交"路径；为 null 走"无预扣直接落账"路径。</summary>
    [Key(0)]  public long? ReservationId { get; set; }
    [Key(1)]  public long TokenId { get; set; }
    [Key(2)]  public long AccountUid { get; set; }
    [Key(3)]  public string ModelName { get; set; } = string.Empty;
    /// <summary>实际 token 用量。DemuxAi 用 ratios[model] × 该用量算 actual quota（authoritative）。</summary>
    [Key(4)]  public TokenUsageBreakdown Tokens { get; set; } = new();
    [Key(5)]  public int? UpstreamStatusCode { get; set; }
    [Key(6)]  public int LatencyMs { get; set; }
    [Key(7)]  public int? ChannelIdExternal { get; set; }
    [Key(8)]  public string? ClientIp { get; set; }
    /// <summary>幂等键。同一键多次调用只落账一次。</summary>
    [Key(9)]  public string RequestId { get; set; } = string.Empty;
    /// <summary>上游返回的额外字段（model_returned 等），原文 JSON 透传到 usage_logs.extra。</summary>
    [Key(10)] public string? ExtraJson { get; set; }
    [Key(11)] public int? ProviderId { get; set; }
    [Key(12)] public string? ApiType { get; set; }
    [Key(13)] public bool Streamed { get; set; }
    [Key(14)] public string? ConvId { get; set; }
    [Key(15)] public long? IamUserUid { get; set; }
    [Key(16)] public string? ErrorCode { get; set; }
    [Key(17)] public string? ErrorMessage { get; set; }
    /// <summary>W3C trace id（32 位十六进制）。把这条计费记录关联回网关请求的分布式 trace。</summary>
    [Key(18)] public string? TraceId { get; set; }
}
