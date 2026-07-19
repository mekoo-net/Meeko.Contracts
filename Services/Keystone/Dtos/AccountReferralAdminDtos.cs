using MessagePack;

namespace Meeko.Contracts.Keystone.Dtos;

[MessagePackObject]
public sealed class AccountReferralAdminWireDto
{
    [Key(0)] public long AccountUid { get; set; }

    /// <summary>邀请人（返利上线）身份与联系信息；自然注册为 null。统一嵌套 <see cref="AccountContactDto"/>，不再展平。</summary>
    [Key(1)] public AccountContactDto? Inviter { get; set; }

    [Key(4)] public int InviteCount { get; set; }
}
