using System.Text.Json.Serialization;
using Platform.Common.Web;
using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class ReferralRebateDto
{
    [Key(0)] public required string Id { get; set; }

    [Key(1)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long SourceAccountUid { get; set; }

    [Key(2)] public string SourceLabel { get; set; } = string.Empty;

    [Key(3)] public decimal RechargeAmount { get; set; }

    [Key(4)] public decimal RebateRatePercent { get; set; }

    [Key(5)] public decimal RebateAmount { get; set; }

    [Key(6)] public string Currency { get; set; } = "CNY";

    [Key(7)] public DateTime OccurredAtUtc { get; set; }

    [Key(8)] public required string LinkedRechargeId { get; set; }
}
