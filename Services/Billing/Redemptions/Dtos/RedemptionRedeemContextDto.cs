using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

/// <summary>兑换现场：客诉与风控排查都靠这几项。</summary>
[MessagePackObject]
public sealed class RedemptionRedeemContextDto
{
    [Key(0)] public required RedemptionAccountRefDto Account { get; set; }
    [Key(1)] public DateTime AtUtc { get; set; }
    [Key(2)] public required string Ip { get; set; }
    [Key(3)] public string? UserAgent { get; set; }

    /// <summary>入账生成的充值单流水号（provider = redemption）。</summary>
    [Key(4)] public required string RechargeId { get; set; }

    /// <summary>在哪个业务里兑换（取自充值单）；未指定业务为 null。</summary>
    [Key(5)] public string? ProductCode { get; set; }
}
