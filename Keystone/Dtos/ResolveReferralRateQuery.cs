using MessagePack;

namespace Meeko.Contracts.Keystone.Dtos;

[MessagePackObject]
public sealed class ResolveReferralRateQuery
{
    [Key(0)] public long InviterAccountUid { get; set; }

    /// <summary>充值渠道 / 产品标识（如 demuxai）。</summary>
    [Key(1)] public string Channel { get; set; } = string.Empty;
}
