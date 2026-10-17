using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class ExportRedemptionBatchCommand
{
    [Key(0)] public required string BatchId { get; set; }
    [Key(1)] public RedemptionExportScope Scope { get; set; }
}
