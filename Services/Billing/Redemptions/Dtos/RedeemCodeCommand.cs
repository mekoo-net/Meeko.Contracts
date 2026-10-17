using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class RedeemCodeCommand
{
    [Key(0)] public long AccountUid { get; set; }
    [Key(1)] public required string Code { get; set; }

    /// <summary>网关确认的客户端 IP。</summary>
    [Key(2)] public required string ClientIp { get; set; }

    [Key(3)] public string? UserAgent { get; set; }

    /// <summary>在哪个业务里兑换（如 demux），与充值下单同一口径：决定推荐返利按哪个产品的费率算。</summary>
    [Key(4)] public string? ProductCode { get; set; }
}
