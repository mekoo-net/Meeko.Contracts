using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class ChannelConfigSchemaDto
{
    /// <summary>支付类型 / 驱动 code。</summary>
    [Key(0)] public string Code { get; set; } = string.Empty;
    [Key(1)] public string DisplayName { get; set; } = string.Empty;
    [Key(2)] public ChannelConfigFieldDto[] Fields { get; set; } = [];
}

/// <summary>可创建的支付渠道「类型」(驱动)，供新建实例时选择。</summary>
[MessagePackObject]
public sealed class ChannelTypeDto
{
    /// <summary>驱动 code（如 "alipay"）。</summary>
    [Key(0)] public string Code { get; set; } = string.Empty;
    [Key(1)] public string DisplayName { get; set; } = string.Empty;
    /// <summary>是否允许创建多个实例（手工入账为 false）。</summary>
    [Key(2)] public bool AllowMultiple { get; set; }
    /// <summary>已创建实例数。</summary>
    [Key(3)] public int InstanceCount { get; set; }
    [Key(4)] public string[] SupportedScenes { get; set; } = [];
    [Key(5)] public ChannelConfigFieldDto[] Fields { get; set; } = [];
}

/// <summary>新建支付渠道实例。</summary>
[MessagePackObject]
public sealed class CreateChannelCommand
{
    /// <summary>支付类型 / 驱动 code（如 "alipay"）。</summary>
    [Key(0)] public string DriverCode { get; set; } = string.Empty;
    /// <summary>实例展示名（如「支付宝-主账户」）。</summary>
    [Key(1)] public string DisplayName { get; set; } = string.Empty;
}

[MessagePackObject]
public sealed class ChannelConfigFieldDto
{
    [Key(0)] public string Key { get; set; } = string.Empty;
    [Key(1)] public string Label { get; set; } = string.Empty;
    [Key(2)] public string Type { get; set; } = "Text";
    [Key(3)] public bool IsSecret { get; set; }
    [Key(4)] public bool Required { get; set; }
    [Key(5)] public string? Placeholder { get; set; }
    [Key(6)] public string? Help { get; set; }
}

[MessagePackObject]
public sealed class ChannelConfigValuesDto
{
    /// <summary>渠道实例 Id。</summary>
    [Key(0)] public long ChannelId { get; set; }
    [Key(1)] public Dictionary<string, string> Values { get; set; } = new();
}

[MessagePackObject]
public sealed class PutChannelConfigCommand
{
    /// <summary>渠道实例 Id。</summary>
    [Key(0)] public long ChannelId { get; set; }
    [Key(1)] public Dictionary<string, string> Values { get; set; } = new();
}
