using System.Text.Json.Serialization;
using Meeko.Common.Web;
using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class OrderDto
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long Id { get; set; }

    [Key(1)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long AccountUid { get; set; }

    [Key(2)] public string ProductCode { get; set; } = string.Empty;
    [Key(3)] public int Quantity { get; set; }
    [Key(4)] public BillingMode BillingMode { get; set; }
    [Key(5)] public decimal UnitPriceSnapshot { get; set; }
    [Key(6)] public OrderStatus Status { get; set; }

    [Key(7)]
    [JsonConverter(typeof(NullableLongToStringConverter))]
    public long? ResourceId { get; set; }

    [Key(8)] public string? MetadataJson { get; set; }
    [Key(9)] public DateTime CreatedAtUtc { get; set; }
    [Key(10)] public DateTime? ActivatedAtUtc { get; set; }
    [Key(11)] public DateTime? TerminatedAtUtc { get; set; }
}
