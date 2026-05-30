using MessagePack;

namespace Meeko.Contracts.Notice;

[MessagePackObject]
public sealed class SendNoticeCommand
{
    [Key(0)] public NoticeChannel Channel { get; set; } = NoticeChannel.Email;
    [Key(1)] public NoticePurpose Purpose { get; set; } = NoticePurpose.Generic;
    [Key(2)] public string Recipient { get; set; } = string.Empty;
    [Key(3)] public long? AccountUid { get; set; }
    [Key(4)] public string TemplateCode { get; set; } = string.Empty;
    [Key(5)] public string Locale { get; set; } = "zh-CN";
    [Key(6)] public Dictionary<string, string>? TemplateData { get; set; }
    [Key(7)] public string? IpAddress { get; set; }
    [Key(8)] public string? IdempotencyKey { get; set; }
}

[MessagePackObject]
public sealed class SendNoticeResult
{
    [Key(0)] public bool Success { get; set; }
    [Key(1)] public long MessageId { get; set; }
    [Key(2)] public NoticeStatus Status { get; set; }
    [Key(3)] public string? FailureCode { get; set; }
    [Key(4)] public string? FailureMessage { get; set; }
    [Key(5)] public int? RetryAfterSeconds { get; set; }
}
