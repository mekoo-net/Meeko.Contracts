using MessagePack;

namespace Meeko.Contracts.Keystone.Dtos;

[MessagePackObject]
public sealed class ResolveReferralRateResult
{
    [Key(0)] public decimal RebateRatePercent { get; set; }

    [Key(1)] public decimal MinWithdrawAmount { get; set; }

    [Key(2)] public bool WithdrawReviewRequired { get; set; }
}
