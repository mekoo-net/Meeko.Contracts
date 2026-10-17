using MagicOnion;

namespace Meeko.Contracts.Billing.Refunds;

/// <summary>
/// Bff → Billing：后台退款。只扣钱包余额，钱由财务按折损比例线下打给用户，不走第三方原路退款。
/// 业务失败以 <c>"{code}: {message}"</c> 作为 gRPC status detail 回传。
/// </summary>
public interface IBillingRefundAdminService : IService<IBillingRefundAdminService>
{
    /// <summary>同一个幂等键重复提交只扣一次，返回第一次的结果。</summary>
    UnaryResult<BalanceRefundDto> RefundBalanceAsync(RefundBalanceCommand cmd);
}
