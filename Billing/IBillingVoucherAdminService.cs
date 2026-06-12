using MagicOnion;

namespace Meeko.Contracts.Billing;

/// <summary>Bff → Billing：代金券批次管理、下发与查询。</summary>
public interface IBillingVoucherAdminService : IService<IBillingVoucherAdminService>
{
    UnaryResult<VoucherTemplateListResult> ListTemplatesAsync(bool includeArchived = false);

    UnaryResult<VoucherTemplateDto?> GetTemplateAsync(long templateId);

    UnaryResult<VoucherTemplateDto> CreateTemplateAsync(CreateVoucherTemplateCommand cmd);

    UnaryResult<VoucherTemplateDto> UpdateTemplateAsync(UpdateVoucherTemplateCommand cmd);

    UnaryResult<VoucherTemplateDto> SetTemplateStatusAsync(SetVoucherTemplateStatusCommand cmd);

    UnaryResult<IssueVouchersResult> IssueAsync(IssueVouchersCommand cmd);

    UnaryResult<bool> RevokeAsync(long userVoucherId);

    UnaryResult<ListUserVouchersResult> ListUserVouchersAsync(ListUserVouchersQuery query);

    UnaryResult<ListVoucherRedemptionsResult> ListRedemptionsAsync(ListVoucherRedemptionsQuery query);
}
