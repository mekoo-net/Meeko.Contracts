using System.Text.Json.Serialization;
using Meeko.Common.Web;
using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class UsageRecordDto
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

    [Key(3)]
    [JsonConverter(typeof(NullableLongToStringConverter))]
    public long? SubscriptionId { get; set; }

    [Key(4)] public string ProductCode { get; set; } = string.Empty;
    [Key(5)] public string Domain { get; set; } = string.Empty;
    [Key(6)] public string MetricKey { get; set; } = string.Empty;
    [Key(7)] public decimal Quantity { get; set; }
    [Key(8)] public decimal UnitPrice { get; set; }
    [Key(9)] public decimal Amount { get; set; }
    [Key(10)] public DateTime OccurredAtUtc { get; set; }
    [Key(11)] public UsageStatus Status { get; set; }
}
