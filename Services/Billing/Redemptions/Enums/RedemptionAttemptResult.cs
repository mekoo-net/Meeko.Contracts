namespace Meeko.Contracts.Billing.Redemptions;

/// <summary>一次兑换提交的结果；失败也落一行，枚举卡密、转卖都靠它查。</summary>
public enum RedemptionAttemptResult : short
{
    Success = 0,
    NotFound = 1,
    AlreadyRedeemed = 2,
    Frozen = 3,
    Voided = 4,
    // 5、6 曾是已过期 / 未生效（兑换码已改为永久有效）。数值已落库，不要复用。
    LimitExceeded = 7,
    RateLimited = 8,
}
