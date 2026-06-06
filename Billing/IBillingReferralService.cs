using MagicOnion;

namespace Meeko.Contracts.Billing;

/// <summary>Bff → Billing：推荐返利余额、返利记录与提现。</summary>
public interface IBillingReferralService : IService<IBillingReferralService>
{
    UnaryResult<ReferralAccountSummaryDto> GetSummaryAsync(long accountUid);

    UnaryResult<ListReferralRebatesResult> ListRebatesAsync(ListReferralRebatesQuery query);

    UnaryResult<ListReferralWithdrawalsResult> ListWithdrawalsAsync(ListReferralWithdrawalsQuery query);

    UnaryResult<ReferralWithdrawalDto> CreateWithdrawalAsync(CreateReferralWithdrawalCommand cmd);

    UnaryResult<ListReferralWithdrawalsAdminResult> ListWithdrawalsAdminAsync(ListReferralWithdrawalsAdminQuery query);

    UnaryResult<ReferralWithdrawalDto> ApproveWithdrawalAsync(long withdrawalId);

    UnaryResult<ReferralWithdrawalDto> RejectWithdrawalAsync(RejectReferralWithdrawalCommand cmd);

    UnaryResult<ReferralWithdrawalDto> MarkWithdrawalPaidAsync(long withdrawalId);
}
