using MessagePack;

namespace Meeko.Contracts.Keystone.Dtos;

[MessagePackObject]
public sealed class ListReferralInviteesQuery
{
    [Key(0)] public long InviterAccountUid { get; set; }

    [Key(1)] public int Page { get; set; } = 1;

    [Key(2)] public int PageSize { get; set; } = 20;
}
