using System.Text.Json.Serialization;
using Platform.Common.Web;
using MessagePack;

namespace Meeko.Contracts.Notice.Templates;

[MessagePackObject]
public sealed class EmailTemplateDto
{
    [Key(0)][JsonConverter(typeof(LongToStringConverter))] public long Id { get; set; }
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

    /// <summary>绑定的 SMTP 发信渠道 Id；null 表示使用默认渠道。</summary>
    [Key(11)][JsonConverter(typeof(NullableLongToStringConverter))] public long? SmtpProviderId { get; set; }
}
