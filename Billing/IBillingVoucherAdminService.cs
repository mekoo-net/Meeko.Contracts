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

    UnaryResult<VoucherActivityListResult> ListActivitiesAsync(ListVoucherActivitiesQuery query);

    UnaryResult<VoucherActivityDto?> GetActivityAsync(long activityId);

    UnaryResult<VoucherActivityDto> CreateActivityAsync(CreateVoucherActivityCommand cmd);

    UnaryResult<VoucherActivityDto> UpdateActivityAsync(UpdateVoucherActivityCommand cmd);

    UnaryResult<VoucherActivityDto> SetActivityStatusAsync(SetVoucherActivityStatusCommand cmd);

    UnaryResult<ActivityClaimersResult> ListActivityClaimersAsync(ListActivityClaimersQuery query);
}
