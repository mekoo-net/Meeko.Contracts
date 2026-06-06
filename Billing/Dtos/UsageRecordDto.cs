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

    [Key(2)] public string ProductCode { get; set; } = string.Empty;
    [Key(3)] public string Domain { get; set; } = string.Empty;
    [Key(4)] public string MetricKey { get; set; } = string.Empty;
    [Key(5)] public decimal Quantity { get; set; }
    [Key(6)] public decimal UnitPrice { get; set; }
    [Key(7)] public decimal Amount { get; set; }
    [Key(8)] public DateTime OccurredAtUtc { get; set; }
    [Key(9)] public UsageStatus Status { get; set; }
}
