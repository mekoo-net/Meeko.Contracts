using MagicOnion;

namespace Meeko.Contracts.Billing;

/// <summary>
/// Bff → Billing：账单流水管理面（list / detail / reverse）。
/// 当前底层映射自 WalletTxn 聚合，部分字段（business / subType / failure / reversal / balanceAfter）暂返回 null，
/// 待 Bill 专用聚合落地后填充。
/// </summary>
public interface IBillingBillAdminService : IService<IBillingBillAdminService>
{
    UnaryResult<ListBillsResult> ListBillsAsync(ListBillsQuery query);

    UnaryResult<BillDto?> GetBillBySerialAsync(string billSerial);

    UnaryResult<ReverseBillResult> ReverseBillAsync(ReverseBillCommand cmd);
}
