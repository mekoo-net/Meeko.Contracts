using MagicOnion;

namespace Meeko.Contracts.Billing;

/// <summary>
/// Bff → Billing：兑换码（领取Key）。后台为某张券生成一次性兑换码批次、查看/导出码、作废批次；
/// 用户侧按码兑换（调用券域发券能力从模板铸券）。
/// </summary>
public interface IBillingVoucherCodeService : IService<IBillingVoucherCodeService>
{
    UnaryResult<VoucherCodeBatchListResult> ListBatchesAsync(ListCodeBatchesQuery query);

    UnaryResult<VoucherCodeBatchDto> GenerateAsync(GenerateRedeemCodesCommand cmd);

    UnaryResult<bool> DisableBatchAsync(long batchId);

    /// <summary>列出批次内的兑换码（用于查看/导出）。</summary>
    UnaryResult<ListRedeemCodesResult> ListCodesAsync(ListRedeemCodesQuery query);

    /// <summary>用户按码兑换，返回铸出的用户券。</summary>
    UnaryResult<UserVoucherDto> RedeemAsync(RedeemVoucherCodeCommand cmd);
}
