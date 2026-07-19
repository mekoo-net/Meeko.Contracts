using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class SetChannelActiveCommand
{
    /// <summary>渠道实例 Id（PaymentChannel.Id）。</summary>
    [Key(0)] public required long Id { get; set; }
    [Key(1)] public required bool Active { get; set; }
}
