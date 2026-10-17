namespace Meeko.Contracts.Billing.Redemptions;

/// <summary>导出范围：未兑换用于补货上架，已兑换 / 全部用于对账。</summary>
public enum RedemptionExportScope : short
{
    Unused = 0,
    Redeemed = 1,
    All = 2,
}
