namespace Meeko.Contracts.Billing.Redemptions;

/// <summary>
/// 卡密的入账途径，批次生成时定下、之后不可改。决定兑换生成的充值单记在哪个入账来源下：
/// 账户充值记「兑换码」、算充值并计推荐返利；活动奖励记「营销奖励」、客服补偿记「客服补偿」，都不算充值。
/// </summary>
public enum RedemptionPurpose : short
{
    Recharge = 0,
    Reward = 1,
    Compensation = 2,
}
