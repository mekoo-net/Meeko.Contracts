using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

/// <summary>用户钱包的兑换入口：渠道停用时入口关闭。</summary>
[MessagePackObject]
public sealed class RedemptionEntryDto
{
    [Key(0)] public bool Enabled { get; set; }

    // Key(1) 曾是兑换说明 Tip，已撤掉。空着不复用：未升级的一端会把旧值按新字段解析。

    /// <summary>卖兑换码的发卡网（渠道配置 stores），用户点击跳转购买。</summary>
    [Key(2)] public RedemptionStoreDto[] Stores { get; set; } = [];
}
