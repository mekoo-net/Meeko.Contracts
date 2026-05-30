using MessagePack;

namespace Meeko.Contracts.Notice.Templates;

[MessagePackObject]
public sealed class EmailTemplateDto
{
    [Key(0)]  public long Id { get; set; }
    [Key(1)]  public string Code { get; set; } = string.Empty;
    [Key(2)]  public string Locale { get; set; } = "zh-CN";
    [Key(3)]  public string Subject { get; set; } = string.Empty;
    [Key(4)]  public string Body { get; set; } = string.Empty;
    [Key(5)]  public bool IsHtml { get; set; }
    [Key(6)]  public string? Description { get; set; }
    [Key(7)]  public int CurrentVersion { get; set; }
    [Key(8)]  public bool IsActive { get; set; }
    [Key(9)]  public DateTime CreatedAtUtc { get; set; }
    [Key(10)] public DateTime UpdatedAtUtc { get; set; }
}
