using MessagePack;

namespace Meeko.Contracts.Keystone.Dtos;

[MessagePackObject]
public sealed class ReferralInviteeDto
{
    [Key(0)] public long AccountUid { get; set; }

    /// <summary>被邀请账户身份与联系信息（展示名 / 邮箱 / 手机 / 类型）；统一嵌套 <see cref="AccountContactDto"/>。</summary>
    [Key(1)] public AccountContactDto? Contact { get; set; }

    [Key(3)] public DateTime RegisteredAtUtc { get; set; }

    [Key(4)] public string Status { get; set; } = "active";
}
