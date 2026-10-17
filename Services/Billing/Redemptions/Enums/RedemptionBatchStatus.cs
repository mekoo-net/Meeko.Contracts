namespace Meeko.Contracts.Billing.Redemptions;

/// <summary>卡密批次状态。<see cref="Expired"/> 由失效时间推导，不落库：延后失效时间即自动恢复。</summary>
public enum RedemptionBatchStatus : short
{
    Active = 0,
    Frozen = 1,
    Voided = 2,
    Expired = 3,
}
