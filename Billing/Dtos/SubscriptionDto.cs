using System.Text.Json.Serialization;
using Meeko.Common.Web;
using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class SubscriptionDto
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long Id { get; set; }

    [Key(1)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long AccountUid { get; set; }

    [Key(2)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long OrderId { get; set; }

    [Key(3)] public string ProductCode { get; set; } = string.Empty;
    [Key(4)] public SubscriptionPeriod Period { get; set; }
    [Key(5)] public DateTime CurrentPeriodStartUtc { get; set; }
    [Key(6)] public DateTime CurrentPeriodEndUtc { get; set; }
    [Key(7)] public DateTime NextBillingAtUtc { get; set; }
    [Key(8)] public SubscriptionStatus Status { get; set; }
    [Key(9)] public bool AutoRenew { get; set; }
    [Key(10)] public bool CancelAtPeriodEnd { get; set; }
    [Key(11)] public DateTime CreatedAtUtc { get; set; }
}
