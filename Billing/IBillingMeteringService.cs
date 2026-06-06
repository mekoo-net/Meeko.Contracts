using MagicOnion;

namespace Meeko.Contracts.Billing;

/// <summary>产品域 → Billing：hold / commit / release / usage。</summary>
public interface IBillingMeteringService : IService<IBillingMeteringService>
{
    UnaryResult<HoldResult> TryHoldAsync(HoldRequest request);

    UnaryResult<bool> CommitHoldAsync(long holdId, decimal actualAmount, string idempotencyKey);

    UnaryResult<bool> ReleaseHoldAsync(long holdId, string reason);

    UnaryResult<bool> ReportUsageAsync(ReportUsageRequest request);

    /// <summary>
    /// 按 Commit 幂等键（产品域 request_id）批量回查已落账的钱包流水。
    /// 供产品域把自身用量日志与 Billing 账单关联，避免跨库直读 Billing schema。
    /// </summary>
    UnaryResult<LookupCommitBillsByIdempotencyKeysResult> LookupCommitBillsByIdempotencyKeysAsync(
        string[] idempotencyKeys);

    /// <summary>按 Commit 幂等键全额驳回（退回钱包 + 写 Refund 流水）。</summary>
    UnaryResult<ReverseBillResult> ReverseCommitByIdempotencyKeyAsync(ReverseCommitByKeyCommand cmd);
}
