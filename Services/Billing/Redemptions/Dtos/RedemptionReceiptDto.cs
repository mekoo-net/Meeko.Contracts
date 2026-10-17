using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class RedemptionReceiptDto
{
    /// <summary>入账金额（卡密面值）。</summary>
    [Key(0)] public decimal Amount { get; set; }

    /// <summary>入账生成的充值单流水号。</summary>
    [Key(1)] public required string RechargeId { get; set; }

    [Key(2)] public required string CodeMasked { get; set; }
    [Key(3)] public DateTime RedeemedAtUtc { get; set; }
}
