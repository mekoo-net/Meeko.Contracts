namespace Meeko.Contracts.Billing.Redemptions;

/// <summary>批次操作记录的动作。单张卡的冻结 / 作废也记在所属批次下，批次时间线才完整。</summary>
public enum RedemptionBatchAction : short
{
    Created = 0,
    Edited = 1,
    Appended = 2,
    Exported = 3,
    Frozen = 4,
    Unfrozen = 5,
    Voided = 6,
    CodeFrozen = 7,
    CodeUnfrozen = 8,
    CodeVoided = 9,
}
