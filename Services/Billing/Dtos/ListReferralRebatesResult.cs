using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class ListReferralRebatesResult
{
    [Key(0)] public ReferralRebateDto[] Items { get; set; } = [];

    [Key(1)] public int Total { get; set; }
}
