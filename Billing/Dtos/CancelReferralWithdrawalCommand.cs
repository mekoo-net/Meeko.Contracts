using System.Text.Json.Serialization;
using Meeko.Common.Web;
using MessagePack;

namespace Meeko.Contracts.Billing;

/// <summary>用户撤销提现申请。按 <see cref="SerialNo"/> 定位，并校验归属 <see cref="AccountUid"/>。</summary>
[MessagePackObject]
public sealed class CancelReferralWithdrawalCommand
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long AccountUid { get; set; }

    [Key(1)] public string SerialNo { get; set; } = string.Empty;
}
