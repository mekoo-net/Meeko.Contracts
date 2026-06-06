using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class ListReferralWithdrawalsResult
{
    [Key(0)] public ReferralWithdrawalDto[] Items { get; set; } = [];

    [Key(1)] public int Total { get; set; }
}
