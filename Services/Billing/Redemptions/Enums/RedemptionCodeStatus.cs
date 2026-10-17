namespace Meeko.Contracts.Billing.Redemptions;

/// <summary>卡密状态。<see cref="Expired"/> 同样由所属批次的失效时间推导。</summary>
public enum RedemptionCodeStatus : short
{
    Unused = 0,
    Redeemed = 1,
    Frozen = 2,
    Voided = 3,
    Expired = 4,
}
