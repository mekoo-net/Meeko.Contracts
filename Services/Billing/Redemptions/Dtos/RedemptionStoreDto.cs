using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

/// <summary>卖兑换码的发卡网。</summary>
[MessagePackObject]
public sealed class RedemptionStoreDto
{
    [Key(0)] public required string Name { get; set; }

    /// <summary>http(s) 绝对地址，保存渠道配置时已校验。</summary>
    [Key(1)] public required string Url { get; set; }

    /// <summary>名称下的一行说明（如支持的付款方式），可空。</summary>
    [Key(2)] public string? Description { get; set; }
}
