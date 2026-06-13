using MessagePack;

namespace Meeko.Contracts.DemuxAi.Admin;

[MessagePackObject]
public sealed class LogAccountDto
{
    [Key(0)]
    [System.Text.Json.Serialization.JsonConverter(typeof(Meeko.Common.Web.LongToStringConverter))]
    public long Uid { get; set; }

    [Key(1)]
    [System.Text.Json.Serialization.JsonConverter(typeof(Meeko.Common.Web.NullableLongToStringConverter))]
    public long? IamUserUid { get; set; }

    [Key(2)] public string? DisplayName { get; set; }
    [Key(3)] public string? Email { get; set; }
    [Key(4)] public string? Phone { get; set; }
}

[MessagePackObject]
public sealed class LogUsageInputDto
{
    [Key(0)] public int Tokens { get; set; }
    [Key(1)] public int CachedReadTokens { get; set; }
    [Key(2)] public int CachedWriteTokens { get; set; }
    [Key(3)] public int AudioTokens { get; set; }
}

[MessagePackObject]
public sealed class LogUsageOutputDto
{
    [Key(0)] public int Tokens { get; set; }
    [Key(1)] public int ReasoningTokens { get; set; }
    [Key(2)] public int AudioTokens { get; set; }
}

[MessagePackObject]
public sealed class LogUsageDto
{
    [Key(0)] public int TotalTokens { get; set; }
    [Key(1)] public LogUsageInputDto Input { get; set; } = new();
    [Key(2)] public LogUsageOutputDto Output { get; set; } = new();
}

[MessagePackObject]
public sealed class LogDimCostDto
{
    [Key(0)] public decimal PerMToken { get; set; }
    [Key(1)] public decimal Amount { get; set; }
}

[MessagePackObject]
public sealed class LogCostInputDto
{
    [Key(0)] public decimal PerMToken { get; set; }
    [Key(1)] public decimal Amount { get; set; }
    [Key(2)] public LogDimCostDto CachedRead { get; set; } = new();
    [Key(3)] public LogDimCostDto CachedWrite { get; set; } = new();
    [Key(4)] public LogDimCostDto Audio { get; set; } = new();
}

[MessagePackObject]
public sealed class LogCostOutputDto
{
    [Key(0)] public decimal PerMToken { get; set; }
    [Key(1)] public decimal Amount { get; set; }
    [Key(2)] public LogDimCostDto Reasoning { get; set; } = new();
    [Key(3)] public LogDimCostDto Audio { get; set; } = new();
}

[MessagePackObject]
public sealed class LogCostDto
{
    [Key(0)] public LogCostInputDto Input { get; set; } = new();
    [Key(1)] public LogCostOutputDto Output { get; set; } = new();
    [Key(2)] public decimal Total { get; set; }
}

[MessagePackObject]
public sealed class LogPerCallUsageDto
{
    /// <summary>
    /// 按次计费的调用同样会消耗 token（如 function call / moderation 仍是 LLM 调用），
    /// 仅记录上游回报的输入 / 输出 / 缓存 token 原始明细，供观测 / 对账，
    /// 不参与计费（计费走 <see cref="LogPerCallCostDto.PricePerCall"/>）。
    /// </summary>
    [Key(0)] public LogUsageInputDto Input { get; set; } = new();
    [Key(1)] public LogUsageOutputDto Output { get; set; } = new();
}

[MessagePackObject]
public sealed class LogPerCallCostDto
{
    [Key(0)] public decimal PricePerCall { get; set; }
    [Key(1)] public decimal CachedPricePerCall { get; set; }
    [Key(2)] public decimal Total { get; set; }
}

[MessagePackObject]
public sealed class LogPerImageUsageTierDto
{
    [Key(0)] public string Size { get; set; } = string.Empty;
    [Key(1)] public string Quality { get; set; } = string.Empty;
}

[MessagePackObject]
public sealed class LogPerImageUsageDto
{
    [Key(0)] public LogPerImageUsageTierDto Tier { get; set; } = new();
    [Key(1)] public int Count { get; set; }
}

[MessagePackObject]
public sealed class LogPerImageCostDto
{
    [Key(0)] public decimal PricePerImage { get; set; }
    [Key(1)] public decimal Total { get; set; }
}

[MessagePackObject]
public sealed class LogPerVideoUsageTierDto
{
    [Key(0)] public string Resolution { get; set; } = string.Empty;
}

[MessagePackObject]
public sealed class LogPerVideoUsageDto
{
    [Key(0)] public LogPerVideoUsageTierDto Tier { get; set; } = new();
    [Key(1)] public decimal Seconds { get; set; }
}

[MessagePackObject]
public sealed class LogPerVideoCostDto
{
    [Key(0)] public decimal PricePerSecond { get; set; }
    [Key(1)] public decimal Total { get; set; }
}

[MessagePackObject]
public sealed class LogPerAudioMinuteUsageDto
{
    [Key(0)] public decimal Minutes { get; set; }
}

[MessagePackObject]
public sealed class LogPerAudioMinuteCostDto
{
    [Key(0)] public decimal PricePerMinute { get; set; }
    [Key(1)] public decimal Total { get; set; }
}

[MessagePackObject]
public sealed class LogPerCharacterUsageDto
{
    [Key(0)] public int Characters { get; set; }
}

[MessagePackObject]
public sealed class LogPerCharacterCostDto
{
    [Key(0)] public decimal PricePerKChar { get; set; }
    [Key(1)] public decimal Total { get; set; }
}

[MessagePackObject]
public sealed class LogErrorDto
{
    [Key(0)] public string? Code { get; set; }
    [Key(1)] public string? Message { get; set; }
    [Key(2)] public int HttpStatus { get; set; }
}

[MessagePackObject]
public sealed class LogBillReversalDto
{
    [Key(0)] public DateTime AtUtc { get; set; }
    [Key(1)] public string? By { get; set; }
    [Key(2)] public string? Code { get; set; }
    [Key(3)] public string? Remark { get; set; }
}

[MessagePackObject]
public sealed class LogBillDto
{
    [Key(0)] public string? Id { get; set; }
    [Key(1)] public string? Status { get; set; }
    [Key(2)] public LogBillReversalDto? Reversal { get; set; }
}

[MessagePackObject]
public sealed class LogTokenDto
{
    [Key(0)]
    [System.Text.Json.Serialization.JsonConverter(typeof(Meeko.Common.Web.LongToStringConverter))]
    public long Id { get; set; }

    [Key(1)] public string Name { get; set; } = string.Empty;
}

/// <summary>Admin 日志行（嵌套折叠形，对齐 console docs 11-demuxai-logs.md LogEntry）。</summary>
[MessagePackObject]
public sealed class AiUsageLogDto
{
    [Key(0)]
    [System.Text.Json.Serialization.JsonConverter(typeof(Meeko.Common.Web.LongToStringConverter))]
    public long Id { get; set; }

    [Key(1)]  public DateTime CreateAt { get; set; }
    [Key(2)]  public LogAccountDto Account { get; set; } = new();
    [Key(3)]  public string? ConvId { get; set; }
    [Key(4)]  public string ModelName { get; set; } = string.Empty;
    [Key(5)]  public int? ProviderId { get; set; }
    [Key(6)]  public string? ApiType { get; set; }
    [Key(7)]  public int? TokenLatency { get; set; }
    [Key(8)]  public bool Streamed { get; set; }
    [Key(9)]  public long? ClientIpV4 { get; set; }
    [Key(10)] public bool Success { get; set; }
    /// <summary>结算状态：<c>pending</c> | <c>success</c> | <c>failure</c> | <c>cancelled</c>。比 <see cref="Success"/> 表达力更强。</summary>
    [Key(11)] public string Status { get; set; } = "success";
    [Key(12)] public LogErrorDto? Error { get; set; }
    [Key(13)] public string BillingType { get; set; } = string.Empty;
    [Key(14)] public object Usage { get; set; } = new LogUsageDto();
    [Key(15)] public object Cost { get; set; } = new LogCostDto();
    [Key(16)] public LogBillDto? Bill { get; set; }
    /// <summary>sk- 令牌快照；PG 直发（无令牌）时为 null。</summary>
    [Key(17)] public LogTokenDto? Token { get; set; }
    /// <summary>请求命中的供应商（供应商组 / 内部 QueueGroup）。来自定价快照绑定，历史不丢。</summary>
    [Key(18)] public string? VendorKey { get; set; }
    /// <summary>请求命中的上游真实模型名（vendor_model）。来自别名快照绑定，历史不丢。</summary>
    [Key(19)] public string? VendorModel { get; set; }
    /// <summary>对外公开通道 slug（如 nai / pa），由 <see cref="VendorKey"/> 反查 Vendor.VendorSlug 得到；供前端映射渠道展示名。未配置 slug 时为 null。</summary>
    [Key(20)] public string? VendorPlug { get; set; }
}

[MessagePackObject]
public sealed class ListAiLogsQuery
{
    [Key(0)]  public long? AccountUid { get; set; }
    [Key(1)]  public long? TokenId { get; set; }
    [Key(2)]  public string? ModelName { get; set; }
    [Key(3)]  public Meeko.Contracts.DemuxAi.Common.AiUsageStatus? Status { get; set; }
    [Key(4)]  public DateTime? FromUtc { get; set; }
    [Key(5)]  public DateTime? ToUtc { get; set; }
    [Key(6)]  public int Take { get; set; } = 50;
    [Key(7)]  public int Skip { get; set; }
    [Key(8)]  public long? IamUserUid { get; set; }
    [Key(9)]  public int? ProviderId { get; set; }
    [Key(10)] public string? ApiType { get; set; }
    [Key(11)] public string? ConvId { get; set; }
    /// <summary>仅返回失败行（Success=false）；与 Status 可叠加。</summary>
    [Key(12)] public bool? ErrorOnly { get; set; }
    [Key(13)] public string? ErrorCode { get; set; }
    /// <summary>按供应商（供应商组）过滤；匹配定价快照绑定的 vendor_key。</summary>
    [Key(14)] public string? VendorKey { get; set; }
}

[MessagePackObject]
public sealed class ListAiLogsResult
{
    [Key(0)] public AiUsageLogDto[] Items { get; set; } = [];
    [Key(1)] public int Total { get; set; }
}

/// <summary>
/// 时间序列分桶聚合行（按查询跨度自适应桶宽：≤48h 按小时，否则按天）。
/// 每个桶含成功 / 失败计数，便于前端绘制成功+失败叠加趋势。
/// </summary>
[MessagePackObject]
public sealed class AiLogStatDto
{
    /// <summary>桶起点（Unix 毫秒 UTC）。桶宽见 <see cref="BucketSeconds"/>。</summary>
    [Key(0)] public DateTime BucketStartUtc { get; set; }
    /// <summary>该桶总调用数（成功 + 失败）。</summary>
    [Key(1)] public int RequestCount { get; set; }
    /// <summary>成功调用累计输入 token。</summary>
    [Key(2)] public long TotalPromptTokens { get; set; }
    /// <summary>成功调用累计输出 token。</summary>
    [Key(3)] public long TotalCompletionTokens { get; set; }
    /// <summary>成功调用累计扣费（元）。</summary>
    [Key(4)] public decimal TotalQuota { get; set; }
    /// <summary>该桶失败调用数（Status != Success）。</summary>
    [Key(5)] public int ErrorCount { get; set; }
    /// <summary>桶宽（秒）：3600=按小时，86400=按天。前端据此格式化横轴刻度。</summary>
    [Key(6)] public int BucketSeconds { get; set; }
}

[MessagePackObject]
public sealed class AiLogStatQuery
{
    [Key(0)] public long? AccountUid { get; set; }
    [Key(1)] public long? TokenId { get; set; }
    [Key(2)] public string? ModelName { get; set; }
    [Key(3)] public DateTime FromUtc { get; set; }
    [Key(4)] public DateTime ToUtc { get; set; }
}

/// <summary>按供应商（供应商组）聚合的消费统计行。</summary>
[MessagePackObject]
public sealed class AiVendorStatDto
{
    [Key(0)] public string VendorKey { get; set; } = string.Empty;
    [Key(1)] public int RequestCount { get; set; }
    [Key(2)] public long TotalPromptTokens { get; set; }
    [Key(3)] public long TotalCompletionTokens { get; set; }
    [Key(4)] public decimal TotalQuota { get; set; }
    /// <summary>该供应商下出现过的上游真实模型数（去重）。</summary>
    [Key(5)] public int UpstreamModelCount { get; set; }
}

[MessagePackObject]
public sealed class AiVendorStatQuery
{
    [Key(0)] public DateTime FromUtc { get; set; }
    [Key(1)] public DateTime ToUtc { get; set; }
    [Key(2)] public long? AccountUid { get; set; }
    [Key(3)] public long? TokenId { get; set; }
    /// <summary>仅统计指定供应商；空 = 全部供应商。</summary>
    [Key(4)] public string? VendorKey { get; set; }
}

/// <summary>按对外模型别名（alias）聚合的 Top 排行行。</summary>
[MessagePackObject]
public sealed class AiModelStatDto
{
    [Key(0)] public string ModelName { get; set; } = string.Empty;
    [Key(1)] public int RequestCount { get; set; }
    [Key(2)] public decimal TotalQuota { get; set; }
    [Key(3)] public int ErrorCount { get; set; }
}

/// <summary>按模型渠道（Provider.id）聚合的 Top 排行行。</summary>
[MessagePackObject]
public sealed class AiProviderStatDto
{
    [Key(0)] public int ProviderId { get; set; }
    [Key(1)] public int RequestCount { get; set; }
    [Key(2)] public int ErrorCount { get; set; }
    /// <summary>平均首字延迟（ms）；仅 streamed + success 样本入均值。</summary>
    [Key(3)] public int AvgTokenLatencyMs { get; set; }
    /// <summary>渠道展示名（VendorSlug 优先，否则 QueueGroup）。</summary>
    [Key(4)] public string? ProviderName { get; set; }
}

[MessagePackObject]
public sealed class ReverseAiLogCommand
{
    [Key(0)] public long LogId { get; set; }
    [Key(1)] public required string Code { get; set; }
    [Key(2)] public string? Remark { get; set; }
    [Key(3)] public long? OperatorIamUserUid { get; set; }
}

[MessagePackObject]
public sealed class ReverseAiLogResult
{
    [Key(0)] public bool Success { get; set; }
    [Key(1)] public string? BillId { get; set; }
    [Key(2)] public DateTime? ReversedAtUtc { get; set; }
    [Key(3)] public string? ReversedBy { get; set; }
    [Key(4)] public string? ReversedCode { get; set; }
    [Key(5)] public string? FailureCode { get; set; }
    [Key(6)] public string? FailureMessage { get; set; }

    public static ReverseAiLogResult Ok(
        string billId,
        DateTime reversedAtUtc,
        string? reversedBy,
        string reversedCode) =>
        new()
        {
            Success = true,
            BillId = billId,
            ReversedAtUtc = reversedAtUtc,
            ReversedBy = reversedBy,
            ReversedCode = reversedCode,
        };

    public static ReverseAiLogResult Fail(string code, string message) =>
        new() { Success = false, FailureCode = code, FailureMessage = message };
}
