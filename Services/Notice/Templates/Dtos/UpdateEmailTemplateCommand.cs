using System.Text.Json.Serialization;
using Platform.Common.Web;
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

    /// <summary>绑定的 SMTP 发信渠道 Id；null 表示使用默认渠道。前端按 console 约定以字符串传 id。</summary>
    [Key(7)][JsonConverter(typeof(NullableLongToStringConverter))] public long? SmtpProviderId { get; set; }
}
