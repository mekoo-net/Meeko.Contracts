using MessagePack;

namespace Meeko.Contracts.Notice.Templates;

[MessagePackObject]
public sealed class EmailTemplateRevisionDto
{
    [Key(0)] public int Version { get; set; }
    [Key(1)] public string Subject { get; set; } = string.Empty;
    [Key(2)] public string Body { get; set; } = string.Empty;
    [Key(3)] public bool IsHtml { get; set; }
    [Key(4)] public string? ChangedBy { get; set; }
    [Key(5)] public DateTime ChangedAtUtc { get; set; }
    [Key(6)] public string? ChangeNote { get; set; }
}
