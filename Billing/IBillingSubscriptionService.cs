using MagicOnion;

namespace Meeko.Contracts.Billing;

/// <summary>BFF → Billing：订阅查询与取消。</summary>
public interface IBillingSubscriptionService : IService<IBillingSubscriptionService>
{
    UnaryResult<SubscriptionDto?> GetAsync(long subscriptionUid);

    UnaryResult<SubscriptionDto[]> ListByAccountAsync(long accountUid);

    UnaryResult<bool> SetCancelAtPeriodEndAsync(long subscriptionUid, bool flag);

    UnaryResult<bool> CancelImmediatelyAsync(long subscriptionUid, string reason);
}
