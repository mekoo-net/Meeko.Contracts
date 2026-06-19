using MessagePack;

namespace Meeko.Contracts.Billing;

/// <summary>
/// 用户端可用支付方式：仅「已启用且已配置」的渠道实例 + 展示元数据。
/// 展示元数据（图标 / 描述）来自渠道插件，Billing 是唯一真相源。
/// </summary>
[MessagePackObject]
public sealed class AvailablePaymentMethodDto
{
    /// <summary>渠道实例 Id；下单时作为 ChannelId 传回。</summary>
    [Key(0)] public long ChannelId { get; set; }
    /// <summary>支付类型 / 驱动 code（如 "alipay"）。</summary>
    [Key(1)] public string DriverCode { get; set; } = string.Empty;
    /// <summary>实例展示名（管理员自定义，如「支付宝-主账户」）。</summary>
    [Key(2)] public string DisplayName { get; set; } = string.Empty;
    /// <summary>展示图标 key（前端据此选图标）。</summary>
    [Key(3)] public string Icon { get; set; } = string.Empty;
    /// <summary>展示描述（如「扫码支付」）。</summary>
    [Key(4)] public string Description { get; set; } = string.Empty;
    [Key(5)] public string[] SupportedScenes { get; set; } = [];
}
