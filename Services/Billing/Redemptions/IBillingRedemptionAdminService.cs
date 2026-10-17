using MagicOnion;

namespace Meeko.Contracts.Billing.Redemptions;

/// <summary>
/// Bff → Billing：兑换码（卡密）后台管理。按批次生成、编辑、导出、冻结、作废卡密，
/// 查询卡密与兑换尝试。批次对外以流水号寻址；明文卡密只出现在生成 / 追加 / 导出的响应里。
/// 业务失败以 <c>"{code}: {message}"</c> 作为 gRPC status detail 回传。
/// <para>
/// 本目录的 DTO 与 web/meeko-console/docs/api/17-billing-redemption.md 一一对应；BFF 直接把它们序列化给前端，
/// 字段名与枚举取值（snake_case）就是前端看到的 wire 格式，改名即破坏前端。
/// </para>
/// </summary>
public interface IBillingRedemptionAdminService : IService<IBillingRedemptionAdminService>
{
    UnaryResult<RedemptionOverviewDto> GetOverviewAsync(GetRedemptionOverviewQuery query);

    UnaryResult<RedemptionBatchListResult> ListBatchesAsync(ListRedemptionBatchesQuery query);

    /// <summary>下拉选项用：全部批次的轻量列表，按创建时间倒序。</summary>
    UnaryResult<RedemptionBatchOptionDto[]> ListBatchOptionsAsync();

    UnaryResult<RedemptionBatchCodesDto> CreateBatchAsync(CreateRedemptionBatchCommand cmd);

    /// <summary>编辑批次；数量增加时生成新卡密，<c>Codes</c> 只含本次追加的明文。</summary>
    UnaryResult<RedemptionBatchCodesDto> UpdateBatchAsync(UpdateRedemptionBatchCommand cmd);

    /// <summary>按范围取明文卡密。只读，不改批次。</summary>
    UnaryResult<RedemptionExportDto> ExportBatchAsync(ExportRedemptionBatchCommand cmd);

    UnaryResult<RedemptionBatchDto> SetBatchFrozenAsync(SetRedemptionBatchFrozenCommand cmd);

    /// <summary>作废批次内全部未兑换卡密，不可恢复；已兑换的不受影响。</summary>
    UnaryResult<RedemptionBatchDto> VoidBatchAsync(VoidRedemptionBatchCommand cmd);

    UnaryResult<RedemptionCodeListResult> SearchCodesAsync(SearchRedemptionCodesQuery query);

    UnaryResult<RedemptionCodeDto?> GetCodeAsync(long codeId);

    UnaryResult<RedemptionCodeDto> SetCodeFrozenAsync(SetRedemptionCodeFrozenCommand cmd);

    UnaryResult<RedemptionCodeDto> VoidCodeAsync(VoidRedemptionCodeCommand cmd);

    UnaryResult<RedemptionAttemptListResult> ListAttemptsAsync(ListRedemptionAttemptsQuery query);
}
