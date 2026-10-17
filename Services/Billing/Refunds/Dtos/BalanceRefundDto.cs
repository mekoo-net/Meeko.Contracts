using System.Text.Json.Serialization;
using MessagePack;
using Platform.Common.Web;

namespace Meeko.Contracts.Billing.Refunds;

[MessagePackObject]
public sealed class BalanceRefundDto
{
    /// <summary>退款单流水号（如 RF20261018000000001）。</summary>
    [Key(0)] public required string Id { get; set; }

    [Key(1)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long AccountUid { get; set; }

    /// <summary>从钱包扣减的金额。</summary>
    [Key(2)] public decimal Amount { get; set; }

    [Key(3)] public decimal LossRatePercent { get; set; }

    /// <summary>线下实际打给用户的金额。</summary>
    [Key(4)] public decimal PayoutAmount { get; set; }

    [Key(5)] public string? Note { get; set; }

    /// <summary>扣款后的可用余额。</summary>
    [Key(6)] public decimal BalanceAfter { get; set; }

    [Key(7)] public DateTime CreatedAtUtc { get; set; }
}
