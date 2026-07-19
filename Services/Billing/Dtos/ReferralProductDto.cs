using MessagePack;

namespace Meeko.Contracts.Billing;

/// <summary>可参与返利的业务域（来自 billing.products 表去重 domain）。</summary>
[MessagePackObject]
public sealed class ReferralProductDto
{
    /// <summary>业务域标识（= 充值 channel，如 demuxai）。</summary>
    [Key(0)] public required string Code { get; set; }

    [Key(1)] public required string DisplayName { get; set; }
}

[MessagePackObject]
public sealed class ReferralProductListResult
{
    [Key(0)] public ReferralProductDto[] Items { get; set; } = [];
}
