using System.Text.Json.Serialization;
using Meeko.Common.Web;
using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class InvoiceLineDto
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long InvoiceId { get; set; }

    [Key(1)] public string Description { get; set; } = string.Empty;
    [Key(2)] public string? ProductCode { get; set; }
    [Key(3)] public decimal Quantity { get; set; }
    [Key(4)] public decimal UnitPrice { get; set; }
    [Key(5)] public decimal Amount { get; set; }

    [Key(6)]
    [JsonConverter(typeof(NullableLongToStringConverter))]
    public long? UsageRecordId { get; set; }
}
