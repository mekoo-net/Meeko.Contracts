using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class SetChannelActiveCommand
{
    [Key(0)] public required string Code { get; set; }
    [Key(1)] public required bool Active { get; set; }
}
