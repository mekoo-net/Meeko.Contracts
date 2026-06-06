using MessagePack;

namespace Meeko.Contracts.Keystone.Dtos;

[MessagePackObject]
public sealed class ReferralInviteeDto
{
    [Key(0)] public long AccountUid { get; set; }

    [Key(1)] public string? DisplayName { get; set; }

    [Key(2)] public string? Email { get; set; }

    [Key(3)] public DateTime RegisteredAtUtc { get; set; }

    [Key(4)] public string Status { get; set; } = "active";
}
