using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class ChannelConfigSchemaDto
{
    [Key(0)] public string Code { get; set; } = string.Empty;
    [Key(1)] public string DisplayName { get; set; } = string.Empty;
    [Key(2)] public ChannelConfigFieldDto[] Fields { get; set; } = [];
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
    [Key(0)] public string Code { get; set; } = string.Empty;
    [Key(1)] public Dictionary<string, string> Values { get; set; } = new();
}

[MessagePackObject]
public sealed class PutChannelConfigCommand
{
    [Key(0)] public string Code { get; set; } = string.Empty;
    [Key(1)] public Dictionary<string, string> Values { get; set; } = new();
}
