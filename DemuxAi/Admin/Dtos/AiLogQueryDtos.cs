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
    [Key(2)] public decimal MultiplierSnapshot { get; set; }
    [Key(3)] public decimal TierSnapshot { get; set; }
    [Key(4)] public decimal Total { get; set; }
}

[MessagePackObject]
public sealed class LogPerCallUsageDto
{
    [Key(0)] public int Calls { get; set; }
}

[MessagePackObject]
public sealed class LogPerCallCostDto
{
    [Key(0)] public decimal PricePerCall { get; set; }
    [Key(1)] public decimal CachedPricePerCall { get; set; }
    [Key(2)] public decimal MultiplierSnapshot { get; set; }
    [Key(3)] public decimal TierSnapshot { get; set; }
    [Key(4)] public decimal Total { get; set; }
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
    [Key(1)] public decimal MultiplierSnapshot { get; set; }
    [Key(2)] public decimal TierSnapshot { get; set; }
    [Key(3)] public decimal Total { get; set; }
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
    [Key(1)] public decimal MultiplierSnapshot { get; set; }
    [Key(2)] public decimal TierSnapshot { get; set; }
    [Key(3)] public decimal Total { get; set; }
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
    [Key(1)] public decimal MultiplierSnapshot { get; set; }
    [Key(2)] public decimal TierSnapshot { get; set; }
    [Key(3)] public decimal Total { get; set; }
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
    [Key(1)] public decimal MultiplierSnapshot { get; set; }
    [Key(2)] public decimal TierSnapshot { get; set; }
    [Key(3)] public decimal Total { get; set; }
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
    [Key(11)] public LogErrorDto? Error { get; set; }
    [Key(12)] public string BillingType { get; set; } = string.Empty;
    [Key(13)] public object Usage { get; set; } = new LogUsageDto();
    [Key(14)] public object Cost { get; set; } = new LogCostDto();
    [Key(15)] public LogBillDto? Bill { get; set; }
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
}

[MessagePackObject]
public sealed class ListAiLogsResult
{
    [Key(0)] public AiUsageLogDto[] Items { get; set; } = [];
    [Key(1)] public int Total { get; set; }
}

[MessagePackObject]
public sealed class AiLogStatDto
{
    [Key(0)] public DateTime DateUtc { get; set; }
    [Key(1)] public int RequestCount { get; set; }
    [Key(2)] public long TotalPromptTokens { get; set; }
    [Key(3)] public long TotalCompletionTokens { get; set; }
    [Key(4)] public decimal TotalQuota { get; set; }
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
