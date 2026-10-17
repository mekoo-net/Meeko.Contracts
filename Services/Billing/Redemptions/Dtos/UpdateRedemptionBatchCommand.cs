using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

/// <summary>编辑批次：面值与前缀不可改；数量只增不减，多出的张数由服务端生成。</summary>
[MessagePackObject]
public sealed class UpdateRedemptionBatchCommand
{
    [Key(0)] public required string BatchId { get; set; }
    [Key(1)] public required string Name { get; set; }
    [Key(2)] public string? SalesChannel { get; set; }
    [Key(3)] public int Quantity { get; set; }
    [Key(4)] public int? PerAccountLimit { get; set; }
    [Key(5)] public DateTime? StartsAtUtc { get; set; }
    [Key(6)] public DateTime? ExpiresAtUtc { get; set; }
}
