using MagicOnion;

namespace Meeko.Contracts.Billing;

/// <summary>
/// Bff → Billing：账单管理面（list / detail）。账单只含扣费与冲正；扣费冲正走计量服务按幂等键冲正。
/// 当前底层映射自 WalletTxn 聚合，部分字段（business / subType / failure / reversal / balanceAfter）暂返回 null，
/// 待 Bill 专用聚合落地后填充。
/// </summary>
public interface IBillingBillAdminService : IService<IBillingBillAdminService>
{
    UnaryResult<ListBillsResult> ListBillsAsync(ListBillsQuery query);

    UnaryResult<BillDto?> GetBillBySerialAsync(string billSerial);
}
