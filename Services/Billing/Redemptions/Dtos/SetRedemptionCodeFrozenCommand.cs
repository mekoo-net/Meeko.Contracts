using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class SetRedemptionCodeFrozenCommand
{
    [Key(0)] public long CodeId { get; set; }
    [Key(1)] public bool Frozen { get; set; }

    /// <summary>冻结原因，记在卡上；解冻不需要。</summary>
    [Key(2)] public string? Reason { get; set; }
}
