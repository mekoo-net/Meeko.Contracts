using System.Text.Json.Serialization;
using Meeko.Common.Web;
using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class ListInvoicesQuery
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long AccountUid { get; set; }

    [Key(1)] public InvoiceKind? Kind { get; set; }
    [Key(2)] public DateTime? FromUtc { get; set; }
    [Key(3)] public DateTime? ToUtc { get; set; }
    [Key(4)] public int Take { get; set; } = 50;
}
