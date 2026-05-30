using MessagePack;

namespace Meeko.Contracts.Notice;

[MessagePackObject]
public sealed class SendOtpCommand
{
    [Key(0)] public OtpPurpose Purpose { get; set; }
    [Key(1)] public NoticeChannel Channel { get; set; } = NoticeChannel.Email;
    [Key(2)] public string Recipient { get; set; } = string.Empty;
    [Key(3)] public long? AccountUid { get; set; }
    [Key(4)] public string? IpAddress { get; set; }
    [Key(5)] public string Locale { get; set; } = "zh-CN";
    [Key(6)] public string? IdempotencyKey { get; set; }
}

[MessagePackObject]
public sealed class SendOtpResult
{
    [Key(0)] public bool Success { get; set; }
    [Key(1)] public long AuditId { get; set; }
    [Key(2)] public DateTime ExpiresAtUtc { get; set; }
    [Key(3)] public string? FailureCode { get; set; }
    [Key(4)] public string? FailureMessage { get; set; }
    [Key(5)] public int? RetryAfterSeconds { get; set; }
}

[MessagePackObject]
public sealed class VerifyOtpCommand
{
    [Key(0)] public OtpPurpose Purpose { get; set; }
    [Key(1)] public NoticeChannel Channel { get; set; } = NoticeChannel.Email;
    [Key(2)] public string Recipient { get; set; } = string.Empty;
    [Key(3)] public string Code { get; set; } = string.Empty;
    [Key(4)] public string? IpAddress { get; set; }
}

[MessagePackObject]
public sealed class VerifyOtpResult
{
    [Key(0)] public OtpVerifyResult Status { get; set; }
    [Key(1)] public int RemainingAttempts { get; set; }
}
