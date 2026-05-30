using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class BillOperatorInfo
{
    [Key(0)] public required long AccountUid { get; set; }

    /// <summary>区分席位时使用；当前 WalletTxn 没存 IAM 用户上下文，返回 null。</summary>
    [Key(1)] public long? IamUserUid { get; set; }
}
