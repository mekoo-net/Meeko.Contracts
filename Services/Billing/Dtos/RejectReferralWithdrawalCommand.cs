using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class RejectReferralWithdrawalCommand
{
    [Key(0)] public long WithdrawalId { get; set; }

    [Key(1)] public string? Reason { get; set; }
}
