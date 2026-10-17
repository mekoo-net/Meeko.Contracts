using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class RedemptionExportDto
{
    [Key(0)] public required RedemptionBatchDto Batch { get; set; }
    [Key(1)] public RedemptionExportScope Scope { get; set; }
    [Key(2)] public RedemptionExportItemDto[] Items { get; set; } = [];
}
