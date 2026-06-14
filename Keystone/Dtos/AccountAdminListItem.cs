using MessagePack;

namespace Meeko.Contracts.Keystone;

[MessagePackObject]
public sealed class AccountAdminListItem
{
    [Key(0)] public required long Uid { get; set; }
    [Key(1)] public required string Type { get; set; }
    [Key(2)] public required string DisplayName { get; set; }
    [Key(3)] public required string Status { get; set; }

    /// <summary>账户等级（1..5）。Key 顺延以兼容旧消息，声明位置就近 Status。</summary>
    [Key(8)] public int Tier { get; set; }

    /// <summary>该账户已持有的成就/徽章 code（用于列表筛选与展示）。</summary>
    [Key(9)] public string[] AchievementCodes { get; set; } = [];

    [Key(4)] public AccountOwnerInfo? Owner { get; set; }
    [Key(5)] public int IamUserCount { get; set; }
    [Key(6)] public DateTime CreatedAtUtc { get; set; }
    [Key(7)] public DateTime? LastActiveAtUtc { get; set; }
}
