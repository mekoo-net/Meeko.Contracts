using System.Text.Json.Serialization;
using Meeko.Common.Web;
using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class BillVoucherDeductionDto
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long UserVoucherId { get; set; }

    [Key(1)] public decimal AmountDeducted { get; set; }
}
