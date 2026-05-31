using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class BillOperatorInfo
{
    [Key(0)] public required long AccountUid { get; set; }

    /// <summary>区分席位时使用；当前 WalletTxn 没存 IAM 用户上下文，返回 null。</summary>
    [Key(1)] public long? IamUserUid { get; set; }

    /// <summary>BFF enrich：账户展示名。</summary>
    [Key(2)] public string? DisplayName { get; set; }

    /// <summary>BFF enrich：Owner 联系邮箱。</summary>
    [Key(3)] public string? Email { get; set; }

    /// <summary>BFF enrich：Owner 联系手机。</summary>
    [Key(4)] public string? Phone { get; set; }
}
