using System.Text.Json.Serialization;
using Platform.Common.Web;
using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class ListReferralRebatesQuery
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long AccountUid { get; set; }

    [Key(1)] public int Page { get; set; } = 1;

    [Key(2)] public int PageSize { get; set; } = 20;
}
