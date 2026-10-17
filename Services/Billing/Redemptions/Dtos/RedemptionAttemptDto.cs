using System.Text.Json.Serialization;
using MessagePack;
using Platform.Common.Web;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class RedemptionAttemptDto
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long Id { get; set; }

    [Key(1)] public DateTime AtUtc { get; set; }
    [Key(2)] public required RedemptionAccountRefDto Account { get; set; }

    /// <summary>用户输入的卡密（脱敏）；不存在的卡密也照样记录，用于识别枚举。</summary>
    [Key(3)] public required string InputMasked { get; set; }

    [Key(4)]
    [JsonConverter(typeof(NullableLongToStringConverter))]
    public long? CodeId { get; set; }

    [Key(5)] public string? BatchId { get; set; }
    [Key(6)] public string? BatchName { get; set; }
    [Key(7)] public RedemptionAttemptResult Result { get; set; }

    /// <summary>成功时的入账金额。</summary>
    [Key(8)] public decimal? Amount { get; set; }

    [Key(9)] public required string Ip { get; set; }
    [Key(10)] public string? UserAgent { get; set; }
    [Key(11)] public string? RechargeId { get; set; }

    /// <summary>在哪个业务里提交的；未指定业务为 null。</summary>
    [Key(12)] public string? ProductCode { get; set; }
}
