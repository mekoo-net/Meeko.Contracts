using MagicOnion;

namespace Meeko.Contracts.Billing;

/// <summary>Meeko.Jobs（Hangfire）→ Billing：调度类操作入口。</summary>
public interface IBillingSchedulerService : IService<IBillingSchedulerService>
{
    UnaryResult<SchedulerResult> RunPaygHourlySettlementAsync(DateTime asOfUtc);

    UnaryResult<SchedulerResult> RunSubscriptionRenewalsAsync(DateTime asOfUtc);

    UnaryResult<SchedulerResult> CloseMonthlyInvoicesAsync(int year, int month);

    UnaryResult<SchedulerResult> ExpireStaleHoldsAsync(DateTime asOfUtc);

    UnaryResult<SchedulerResult> DispatchOutboxAsync(int batchSize);
}
