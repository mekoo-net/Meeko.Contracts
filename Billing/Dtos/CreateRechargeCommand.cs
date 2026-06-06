using System.Text.Json.Serialization;
using Meeko.Common.Web;
using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class CreateRechargeCommand
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long AccountUid { get; set; }

    [Key(1)] public decimal Amount { get; set; }
    [Key(2)] public string Provider { get; set; } = "manual";
    [Key(3)] public PaymentScene Scene { get; set; } = PaymentScene.Manual;
    [Key(4)] public string? ClientIp { get; set; }
    [Key(5)] public string? ReturnUrl { get; set; }
    [Key(6)] public string? OpenId { get; set; }
    [Key(7)] public string? Subject { get; set; } = "Meeko 钱包充值";
    [Key(8)] public string? IdempotencyKey { get; set; }

    /// <summary>充值渠道 / 产品标识（如 demuxai）。</summary>
    [Key(9)] public string? Channel { get; set; }
}
