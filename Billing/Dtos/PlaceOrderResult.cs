using System.Text.Json.Serialization;
using Meeko.Common.Web;
using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class PlaceOrderResult
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long OrderId { get; set; }

    [Key(1)] public OrderStatus Status { get; set; }
    [Key(2)] public BillingMode BillingMode { get; set; }

    [Key(3)]
    [JsonConverter(typeof(NullableLongToStringConverter))]
    public long? HoldId { get; set; }

    [Key(4)]
    [JsonConverter(typeof(NullableLongToStringConverter))]
    public long? SubscriptionId { get; set; }

    [Key(5)]
    [JsonConverter(typeof(NullableLongToStringConverter))]
    public long? InvoiceId { get; set; }

    [Key(6)] public decimal Amount { get; set; }
}
