using System.Text.Json.Serialization;
using Meeko.Common.Web;
using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class PlaceOrderCommand
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long AccountUid { get; set; }

    [Key(1)] public string ProductCode { get; set; } = string.Empty;
    [Key(2)] public int Quantity { get; set; } = 1;
    [Key(3)] public string? Currency { get; set; } = "CNY";
    [Key(4)] public string? MetadataJson { get; set; }
    [Key(5)] public string? IdempotencyKey { get; set; }
    [Key(6)] public BillingMode? BillingMode { get; set; }
    [Key(7)] public SubscriptionPeriod? Period { get; set; }
    [Key(8)] public decimal? UnitPrice { get; set; }
}
