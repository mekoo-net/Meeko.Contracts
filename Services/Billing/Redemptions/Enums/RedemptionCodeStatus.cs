namespace Meeko.Contracts.Billing.Redemptions;

/// <summary>卡密状态。</summary>
public enum RedemptionCodeStatus : short
{
    Unused = 0,
    Redeemed = 1,
    Frozen = 2,
    Voided = 3,
}
