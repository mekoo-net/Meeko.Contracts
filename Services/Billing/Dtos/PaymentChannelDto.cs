using MessagePack;

namespace Meeko.Contracts.Billing;

/// <summary>支付渠道「实例」。一个 <see cref="DriverCode"/>(支付类型)可对应多个实例。</summary>
[MessagePackObject]
public sealed class PaymentChannelDto
{
    /// <summary>实例 Id（PaymentChannel.Id），下单/配置/启停均以它定位。</summary>
    [Key(0)] public required long Id { get; set; }
    /// <summary>支付类型 / 驱动 code（如 "alipay"）。</summary>
    [Key(1)] public required string DriverCode { get; set; }
    /// <summary>实例展示名（管理员自定义，如「支付宝-主账户」）。</summary>
    [Key(2)] public required string DisplayName { get; set; }
    [Key(3)] public required bool IsActive { get; set; }
    [Key(4)] public required bool IsConfigured { get; set; }
    [Key(5)] public required string[] SupportedScenes { get; set; }
    /// <summary>支付类型展示名（如「支付宝」），用于 UI 分组/标签。</summary>
    [Key(6)] public string? DriverDisplayName { get; set; }
}
