using System.Text.Json.Serialization;
using Meeko.Common.Web;
using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class CreateReferralWithdrawalCommand
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long AccountUid { get; set; }

    [Key(1)] public decimal Amount { get; set; }

    /// <summary>alipay / bank。</summary>
    [Key(2)] public string Method { get; set; } = "alipay";

    [Key(3)] public string AccountNo { get; set; } = string.Empty;

    [Key(4)] public string AccountName { get; set; } = string.Empty;
}
