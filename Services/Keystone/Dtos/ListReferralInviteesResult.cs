using MessagePack;

namespace Meeko.Contracts.Keystone.Dtos;

[MessagePackObject]
public sealed class ListReferralInviteesResult
{
    [Key(0)] public ReferralInviteeDto[] Items { get; set; } = [];

    [Key(1)] public int Total { get; set; }
}
