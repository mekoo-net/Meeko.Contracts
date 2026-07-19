using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class ReferralProductRateWireDto
{
    [Key(0)] public string ProductCode { get; set; } = string.Empty;
    [Key(1)] public string ProductName { get; set; } = string.Empty;
    [Key(2)] public bool Enabled { get; set; }
    [Key(3)] public decimal RebateRatePercent { get; set; }
    [Key(4)] public decimal MinWithdrawAmount { get; set; }
    [Key(5)] public bool WithdrawReviewRequired { get; set; }
}

[MessagePackObject]
public sealed class ReferralSettingsAdminWireDto
{
    [Key(0)] public ReferralProductRateWireDto[] ProductRates { get; set; } = [];
    [Key(1)] public DateTime UpdatedAtUtc { get; set; }
}

[MessagePackObject]
public sealed class UpdateReferralSettingsWireCommand
{
    [Key(0)] public ReferralProductRateWireDto[]? ProductRates { get; set; }
}

[MessagePackObject]
public sealed class SetReferralAccountOverrideWireCommand
{
    [Key(0)] public long AccountUid { get; set; }
    [Key(1)] public decimal? RebateRatePercent { get; set; }
}
