using MagicOnion;

namespace Meeko.Contracts.Billing;

/// <summary>BFF → Billing：钱包查询 + 充值发起 / 确认。</summary>
public interface IBillingWalletService : IService<IBillingWalletService>
{
    UnaryResult<WalletSnapshot?> GetWalletAsync(long accountUid);

    /// <summary>批量查钱包快照（一次 IN 查询），供列表类视图 enrich 余额。未开户的 uid 不在返回集中。</summary>
    UnaryResult<WalletSnapshot[]> GetWalletsAsync(long[] accountUids);

    UnaryResult<RechargeIntent> CreateRechargeAsync(CreateRechargeCommand cmd);

    /// <summary>仅 notify HTTP 回调内部使用，幂等。</summary>
    UnaryResult<bool> ConfirmRechargeAsync(string outTradeNo);

    UnaryResult<bool> CancelRechargeAsync(long rechargeUid);

    UnaryResult<WalletTxnDto[]> ListTransactionsAsync(long accountUid, DateTime fromUtc, DateTime toUtc, int take);
}
