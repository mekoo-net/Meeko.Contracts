using MessagePack;

namespace Meeko.Contracts.Notice.Templates;

[MessagePackObject]
public sealed class CreateEmailTemplateCommand
{
    [Key(0)] public string Code { get; set; } = string.Empty;
    [Key(1)] public string Locale { get; set; } = "zh-CN";
    [Key(2)] public string Subject { get; set; } = string.Empty;
    [Key(3)] public string Body { get; set; } = string.Empty;
    [Key(4)] public bool IsHtml { get; set; }
    [Key(5)] public string? Description { get; set; }
    [Key(6)] public bool IsActive { get; set; } = true;
}
