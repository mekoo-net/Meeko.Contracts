using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class CreateRedemptionBatchCommand
{
    [Key(0)] public required string Name { get; set; }
    [Key(1)] public string? SalesChannel { get; set; }

    /// <summary>入账途径，生成后不可改；Key 顺延，声明就近放在销售渠道旁。</summary>
    [Key(6)] public RedemptionPurpose Purpose { get; set; }

    [Key(2)] public decimal FaceValue { get; set; }
    [Key(3)] public int Quantity { get; set; }

    /// <summary>空 = 无前缀；否则 2–6 位大写字母数字。</summary>
    [Key(4)] public string? Prefix { get; set; }

    [Key(5)] public int? PerAccountLimit { get; set; }
}
