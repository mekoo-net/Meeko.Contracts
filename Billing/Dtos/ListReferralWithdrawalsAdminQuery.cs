using System.Text.Json.Serialization;
using Meeko.Common.Web;
using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class ListReferralWithdrawalsAdminQuery
{
    [Key(0)]
    [JsonConverter(typeof(NullableLongToStringConverter))]
    public long? AccountUid { get; set; }

    /// <summary>pending / approved / rejected / paid / all。</summary>
    [Key(1)] public string Status { get; set; } = "all";

    [Key(2)] public int Page { get; set; } = 1;

    [Key(3)] public int PageSize { get; set; } = 20;
}
