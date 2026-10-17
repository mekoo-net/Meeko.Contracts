using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class RedemptionBatchDto
{
    /// <summary>批次流水号（如 RD20261017000000001），对外即批次 id。</summary>
    [Key(0)] public required string Id { get; set; }
    [Key(1)] public required string Name { get; set; }
    [Key(2)] public string? SalesChannel { get; set; }

    /// <summary>入账途径；Key 顺延，声明就近放在销售渠道旁。</summary>
    [Key(12)] public RedemptionPurpose Purpose { get; set; }

    [Key(3)] public decimal FaceValue { get; set; }
    [Key(4)] public int Quantity { get; set; }
    [Key(5)] public int RedeemedCount { get; set; }
    [Key(6)] public int FrozenCount { get; set; }
    [Key(7)] public int VoidedCount { get; set; }
    [Key(8)] public RedemptionBatchStatus Status { get; set; }
    [Key(9)] public required string CodePattern { get; set; }
    [Key(10)] public int? PerAccountLimit { get; set; }
    [Key(11)] public DateTime CreatedAtUtc { get; set; }
}
