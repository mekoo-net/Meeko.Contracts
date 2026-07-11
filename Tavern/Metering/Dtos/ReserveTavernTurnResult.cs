using MessagePack;

namespace Meeko.Contracts.Tavern.Metering.Dtos;

[MessagePackObject]
public sealed class ReserveTavernTurnResult
{
    [Key(0)] public bool Success { get; set; }
    [Key(1)] public long? ReservationId { get; set; }
    [Key(2)] public long? BillingHoldId { get; set; }
    /// <summary>预扣金额（token 估算 × 模型倍率 × 基准单价）。</summary>
    [Key(3)] public decimal? EstimatedAmount { get; set; }
    [Key(4)] public decimal? WalletAvailableAfter { get; set; }
    [Key(5)] public string? FailureCode { get; set; }
    [Key(6)] public string? FailureMessage { get; set; }
}
