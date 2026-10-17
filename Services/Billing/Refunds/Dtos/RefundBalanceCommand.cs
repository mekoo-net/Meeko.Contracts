using MessagePack;

namespace Meeko.Contracts.Billing.Refunds;

[MessagePackObject]
public sealed class RefundBalanceCommand
{
    [Key(0)] public long AccountUid { get; set; }

    /// <summary>从钱包扣减的金额，不能超过可用余额。</summary>
    [Key(1)] public decimal Amount { get; set; }

    /// <summary>折损比例（%），0 ≤ x &lt; 100；实退金额 = 扣减金额 × (1 − 折损比例)。</summary>
    [Key(2)] public decimal LossRatePercent { get; set; }

    [Key(3)] public string? Note { get; set; }
    [Key(4)] public string? IdempotencyKey { get; set; }
    [Key(5)] public long? OperatorStaffUid { get; set; }
}
