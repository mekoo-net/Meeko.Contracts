using System.Text.Json.Serialization;
using MessagePack;
using Platform.Common.Web;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class RedemptionCodeDto
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long Id { get; set; }

    [Key(1)] public required string BatchId { get; set; }
    [Key(2)] public required string BatchName { get; set; }
    [Key(3)] public required string CodeMasked { get; set; }
    [Key(4)] public decimal FaceValue { get; set; }
    [Key(5)] public RedemptionCodeStatus Status { get; set; }
    [Key(6)] public RedemptionRedeemContextDto? Redeemed { get; set; }

    /// <summary>命中这张卡的失败提交次数；已兑换后仍被他人提交，多半是转卖或外泄。</summary>
    [Key(7)] public int FailedAttempts { get; set; }

    [Key(8)] public DateTime? ExpiresAtUtc { get; set; }
    [Key(9)] public DateTime CreatedAtUtc { get; set; }

    /// <summary>冻结 / 作废原因。</summary>
    [Key(10)] public string? StatusReason { get; set; }
}
