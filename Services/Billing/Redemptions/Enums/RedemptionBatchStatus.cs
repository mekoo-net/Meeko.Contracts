namespace Meeko.Contracts.Billing.Redemptions;

/// <summary>卡密批次状态。兑换码永久有效，没有过期状态。</summary>
public enum RedemptionBatchStatus : short
{
    Active = 0,
    Frozen = 1,
    Voided = 2,
}
