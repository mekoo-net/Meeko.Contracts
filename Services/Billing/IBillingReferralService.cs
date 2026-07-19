using MagicOnion;

namespace Meeko.Contracts.Billing;

/// <summary>Bff → Billing：推荐返利余额、返利记录与提现。</summary>
public interface IBillingReferralService : IService<IBillingReferralService>
{
    /// <summary>账户返利总览。<paramref name="productCode"/> 指定当前平台时，返佣比例按该产品的返利机制解析；为空则回落到平台已启用费率。</summary>
    UnaryResult<ReferralAccountSummaryDto> GetSummaryAsync(long accountUid, string? productCode);

    UnaryResult<ListReferralRebatesResult> ListRebatesAsync(ListReferralRebatesQuery query);

    /// <summary>按来源账户聚合受益人名下的返利总额（SQL 端 GROUP BY SUM），供邀请列表展示「贡献返利」。</summary>
    UnaryResult<SumReferralRebatesBySourceResult> SumRebatesBySourceAsync(SumReferralRebatesBySourceQuery query);

    UnaryResult<ListReferralWithdrawalsResult> ListWithdrawalsAsync(ListReferralWithdrawalsQuery query);

    UnaryResult<ReferralWithdrawalDto> CreateWithdrawalAsync(CreateReferralWithdrawalCommand cmd);

    /// <summary>用户撤销待审核的提现申请，冻结金额退回可提现余额。</summary>
    UnaryResult<ReferralWithdrawalDto> CancelWithdrawalAsync(CancelReferralWithdrawalCommand cmd);

    UnaryResult<ListReferralWithdrawalsAdminResult> ListWithdrawalsAdminAsync(ListReferralWithdrawalsAdminQuery query);

    UnaryResult<ReferralWithdrawalDto> ApproveWithdrawalAsync(long withdrawalId);

    UnaryResult<ReferralWithdrawalDto> RejectWithdrawalAsync(RejectReferralWithdrawalCommand cmd);

    UnaryResult<ReferralWithdrawalDto> MarkWithdrawalPaidAsync(long withdrawalId);

    /// <summary>运营标记打款失败（审核通过后），冻结金额退回可提现余额，用户可重新申请。</summary>
    UnaryResult<ReferralWithdrawalDto> MarkWithdrawalFailedAsync(RejectReferralWithdrawalCommand cmd);

    /// <summary>列出可参与返利的业务域（来自 products 表去重 domain）。</summary>
    UnaryResult<ReferralProductListResult> ListReferralProductsAsync();

    UnaryResult<ReferralSettingsAdminWireDto> GetReferralSettingsAsync();

    UnaryResult<ReferralSettingsAdminWireDto> UpdateReferralSettingsAsync(UpdateReferralSettingsWireCommand cmd);

    UnaryResult<decimal?> GetAccountReferralRateOverrideAsync(long accountUid);

    UnaryResult<bool> SetAccountReferralRateOverrideAsync(SetReferralAccountOverrideWireCommand cmd);
}
