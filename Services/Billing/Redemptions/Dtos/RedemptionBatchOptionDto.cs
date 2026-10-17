using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class RedemptionBatchOptionDto
{
    [Key(0)] public required string Id { get; set; }
    [Key(1)] public required string Name { get; set; }
    [Key(2)] public decimal FaceValue { get; set; }
}
