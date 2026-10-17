using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

/// <summary>用户钱包的兑换入口：渠道停用时入口关闭。</summary>
[MessagePackObject]
public sealed class RedemptionEntryDto
{
    [Key(0)] public bool Enabled { get; set; }

    /// <summary>兑换框下方的说明（渠道配置 redeemTip）。</summary>
    [Key(1)] public string? Tip { get; set; }
}
