using MagicOnion;

namespace Meeko.Contracts.Billing;

/// <summary>BFF → Billing：钱包查询 + 充值发起 / 确认。</summary>
public interface IBillingWalletService : IService<IBillingWalletService>
{
    UnaryResult<WalletSnapshot?> GetWalletAsync(long accountUid);

    UnaryResult<RechargeIntent> CreateRechargeAsync(CreateRechargeCommand cmd);

    /// <summary>仅 notify HTTP 回调内部使用，幂等。</summary>
    UnaryResult<bool> ConfirmRechargeAsync(string outTradeNo);

    UnaryResult<bool> CancelRechargeAsync(long rechargeUid);

    UnaryResult<WalletTxnDto[]> ListTransactionsAsync(long accountUid, DateTime fromUtc, DateTime toUtc, int take);
}
