using MessagePack;

namespace Meeko.Contracts.Keystone;

/// <summary>
/// 账户联系信息（按 uid 批量查询用）：展示名 + Owner 联系邮箱 / 手机。
/// 供 Bff enrich 充值 / 账单等只含 AccountUid 的流水。
/// </summary>
[MessagePackObject]
public sealed class AccountContactDto
{
    [Key(0)] public required long Uid { get; set; }
    [Key(1)] public string? DisplayName { get; set; }
    [Key(2)] public string? Email { get; set; }
    [Key(3)] public string? Phone { get; set; }
}
