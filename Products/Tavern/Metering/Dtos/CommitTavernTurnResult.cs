using MessagePack;

namespace Meeko.Contracts.Tavern.Metering.Dtos;

[MessagePackObject]
public sealed class CommitTavernTurnResult
{
    [Key(0)] public bool Success { get; set; }
    /// <summary>实扣金额（Usages 逐条 token × 模型倍率 × 基准单价累加）。</summary>
    [Key(1)] public decimal? ChargedAmount { get; set; }
    [Key(2)] public decimal? WalletAvailableAfter { get; set; }
    [Key(3)] public string? FailureCode { get; set; }
    [Key(4)] public string? FailureMessage { get; set; }
}
