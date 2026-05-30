using MessagePack;

namespace Meeko.Contracts.Notice.Templates;

[MessagePackObject]
public sealed class UpdateEmailTemplateCommand
{
    [Key(0)] public long Id { get; set; }
    [Key(1)] public string Subject { get; set; } = string.Empty;
    [Key(2)] public string Body { get; set; } = string.Empty;
    [Key(3)] public bool IsHtml { get; set; }
    [Key(4)] public string? Description { get; set; }
    [Key(5)] public bool IsActive { get; set; } = true;
    [Key(6)] public string? ChangeNote { get; set; }
}
