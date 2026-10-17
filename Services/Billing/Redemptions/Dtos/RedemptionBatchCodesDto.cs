using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

/// <summary>生成 / 追加卡密的响应：明文只在这里出现一次。</summary>
[MessagePackObject]
public sealed class RedemptionBatchCodesDto
{
    [Key(0)] public required RedemptionBatchDto Batch { get; set; }
    [Key(1)] public string[] Codes { get; set; } = [];
}
