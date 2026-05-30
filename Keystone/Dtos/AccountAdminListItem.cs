using MessagePack;

namespace Meeko.Contracts.Keystone;

[MessagePackObject]
public sealed class AccountAdminListItem
{
    [Key(0)] public required long Uid { get; set; }
    [Key(1)] public required string Type { get; set; }
    [Key(2)] public required string DisplayName { get; set; }
    [Key(3)] public required string Status { get; set; }
    [Key(4)] public AccountOwnerInfo? Owner { get; set; }
    [Key(5)] public int IamUserCount { get; set; }
    [Key(6)] public DateTime CreatedAtUtc { get; set; }
    [Key(7)] public DateTime? LastActiveAtUtc { get; set; }
}
