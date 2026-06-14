using MessagePack;

namespace Meeko.Contracts.Keystone;

[MessagePackObject]
public sealed class AccountAdminDetail
{
    [Key(0)] public required long Uid { get; set; }
    [Key(1)] public required string Type { get; set; }
    [Key(2)] public required string DisplayName { get; set; }
    [Key(3)] public required string Status { get; set; }

    /// <summary>账户等级（1..5），由管理员手动调整。Key 顺延以兼容旧消息，声明位置就近 Status。</summary>
    [Key(10)] public int Tier { get; set; }

    [Key(4)] public AccountOwnerDetail? Owner { get; set; }
    [Key(5)] public int IamUserCount { get; set; }
    [Key(6)] public DateTime CreatedAtUtc { get; set; }
    [Key(7)] public DateTime UpdatedAtUtc { get; set; }
    [Key(8)] public DateTime? LastActiveAtUtc { get; set; }
    [Key(9)] public AccountAchievementDto[] Achievements { get; set; } = [];
}
