using MessagePack;

namespace Meeko.Contracts.Keystone.Dtos;

[MessagePackObject]
public sealed class AccountReferralAdminWireDto
{
    [Key(0)] public long AccountUid { get; set; }
    [Key(1)] public long? InviterAccountUid { get; set; }
    [Key(2)] public string? InviterDisplayName { get; set; }
    [Key(3)] public string? InviterEmail { get; set; }
    [Key(4)] public int InviteCount { get; set; }
}
