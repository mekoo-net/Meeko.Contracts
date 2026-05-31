using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class BillOwnerInfo
{
    [Key(0)] public required long AccountUid { get; set; }

    /// <summary>BFF enrich：账户展示名。</summary>
    [Key(1)] public string? DisplayName { get; set; }

    /// <summary>BFF enrich：Owner 联系邮箱。</summary>
    [Key(2)] public string? Email { get; set; }

    /// <summary>BFF enrich：Owner 联系手机。</summary>
    [Key(3)] public string? Phone { get; set; }
}
