using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class RechargeOperatorInfo
{
    [Key(0)] public required long IamUserUid { get; set; }
}
