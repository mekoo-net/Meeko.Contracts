using MagicOnion;

namespace Meeko.Contracts.Billing.Redemptions;

/// <summary>
/// Bff → Billing：用户在钱包里用卡密兑换余额。兑换成功生成一笔 provider = redemption 的充值单并入账；
/// 失败（卡密不存在、已兑换、频控等）同样记一条兑换尝试，以 <c>"{code}: {message}"</c> 作为 gRPC status detail 回传。
/// </summary>
public interface IBillingRedemptionService : IService<IBillingRedemptionService>
{
    /// <summary>兑换入口是否开放及说明文案；兑换码渠道停用时入口关闭。</summary>
    UnaryResult<RedemptionEntryDto> GetEntryAsync();

    UnaryResult<RedemptionReceiptDto> RedeemAsync(RedeemCodeCommand cmd);
}
