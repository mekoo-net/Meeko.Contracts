using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class RechargeOwnerInfo
{
    [Key(0)] public required long AccountUid { get; set; }
}
