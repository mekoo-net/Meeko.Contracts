using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class ListReferralWithdrawalsAdminResult
{
    [Key(0)] public ReferralWithdrawalDto[] Items { get; set; } = [];

    [Key(1)] public int Total { get; set; }
}
