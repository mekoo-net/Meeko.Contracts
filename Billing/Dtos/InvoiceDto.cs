using System.Text.Json.Serialization;
using Meeko.Common.Web;
using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class InvoiceDto
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long Id { get; set; }

    [Key(1)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long AccountUid { get; set; }

    [Key(2)] public InvoiceKind Kind { get; set; }
    [Key(3)] public DateTime? PeriodStartUtc { get; set; }
    [Key(4)] public DateTime? PeriodEndUtc { get; set; }
    [Key(5)] public decimal Subtotal { get; set; }
    [Key(6)] public decimal Tax { get; set; }
    [Key(7)] public decimal Total { get; set; }
    [Key(8)] public string Currency { get; set; } = "CNY";
    [Key(9)] public InvoiceStatus Status { get; set; }
    [Key(10)] public DateTime IssuedAtUtc { get; set; }
    [Key(11)] public DateTime? PaidAtUtc { get; set; }

    [Key(12)]
    [JsonConverter(typeof(NullableLongToStringConverter))]
    public long? SubscriptionId { get; set; }

    [Key(13)]
    [JsonConverter(typeof(NullableLongToStringConverter))]
    public long? OrderId { get; set; }
}
