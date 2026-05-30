using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class BillOwnerInfo
{
    [Key(0)] public required long AccountUid { get; set; }
}
