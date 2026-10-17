using System.Text.Json.Serialization;
using MessagePack;
using Platform.Common.Web;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class RedemptionBatchEventDto
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long Id { get; set; }

    [Key(1)] public RedemptionBatchAction Action { get; set; }
    [Key(2)] public required RedemptionStaffRefDto Operator { get; set; }
    [Key(3)] public string? Detail { get; set; }
    [Key(4)] public DateTime AtUtc { get; set; }
}
