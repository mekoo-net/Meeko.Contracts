using MagicOnion;

namespace Meeko.Contracts.Billing;

/// <summary>Bff → Billing：代金券批次管理、下发与查询。</summary>
public interface IBillingVoucherAdminService : IService<IBillingVoucherAdminService>
{
    UnaryResult<VoucherTemplateListResult> ListTemplatesAsync(ListVoucherTemplatesQuery query);

    UnaryResult<VoucherTemplateDto?> GetTemplateAsync(long templateId);

    UnaryResult<VoucherTemplateDto> CreateTemplateAsync(CreateVoucherTemplateCommand cmd);

    UnaryResult<VoucherTemplateDto> UpdateTemplateAsync(UpdateVoucherTemplateCommand cmd);

    UnaryResult<VoucherTemplateDto> SetTemplateStatusAsync(SetVoucherTemplateStatusCommand cmd);

    UnaryResult<IssueVouchersResult> IssueAsync(IssueVouchersCommand cmd);

    UnaryResult<bool> RevokeAsync(long userVoucherId);

    UnaryResult<ListUserVouchersResult> ListUserVouchersAsync(ListUserVouchersQuery query);

    UnaryResult<ListVoucherRedemptionsResult> ListRedemptionsAsync(ListVoucherRedemptionsQuery query);

    /// <summary>账户维度完整券余额流水（含发放/预占/释放/抵扣/退回/过期/作废）。</summary>
    UnaryResult<ListVoucherLedgerResult> ListLedgerAsync(ListVoucherRedemptionsQuery query);

    /// <summary>按券查其全部抵扣流水（审计："这张券都用在哪些账单"）。</summary>
    UnaryResult<ListVoucherRedemptionsResult> ListRedemptionsByVoucherAsync(long userVoucherId, int take);

    /// <summary>按券查其完整余额流水。</summary>
    UnaryResult<ListVoucherLedgerResult> ListLedgerByVoucherAsync(long userVoucherId, int take);

    /// <summary>按账单（Hold）查其全部券抵扣（审计："这张账单用了哪些券"）。</summary>
    UnaryResult<ListVoucherRedemptionsResult> ListRedemptionsByBillAsync(long holdId);

    /// <summary>按账单（Hold）查其全部券流水（含预占/释放/抵扣/退回）。</summary>
    UnaryResult<ListVoucherLedgerResult> ListLedgerByBillAsync(long holdId);

    UnaryResult<VoucherActivityListResult> ListActivitiesAsync(ListVoucherActivitiesQuery query);

    UnaryResult<VoucherActivityDto?> GetActivityAsync(long activityId);

    UnaryResult<VoucherActivityDto> CreateActivityAsync(CreateVoucherActivityCommand cmd);

    UnaryResult<VoucherActivityDto> UpdateActivityAsync(UpdateVoucherActivityCommand cmd);

    UnaryResult<VoucherActivityDto> SetActivityStatusAsync(SetVoucherActivityStatusCommand cmd);

    UnaryResult<ActivityClaimersResult> ListActivityClaimersAsync(ListActivityClaimersQuery query);
}
