using Meeko.Contracts.DemuxAi.Common;
using MessagePack;

namespace Meeko.Contracts.DemuxAi.LlmBackend;

// Key 序号必须与 DemuxAi.Gateway/Rpc/Contracts/LlmBackend/Dtos.cs 严格一致，改一边记得改另一边。
[MessagePackObject]
public sealed class AiTokenResolution
{
    [Key(0)] public long TokenId { get; set; }
    [Key(1)] public long AccountUid { get; set; }
    [Key(2)] public string TokenName { get; set; } = string.Empty;
    [Key(3)] public AiTokenStatus Status { get; set; }
    [Key(4)] public bool UnlimitedQuota { get; set; }
    [Key(5)] public decimal RemainQuota { get; set; }
    [Key(6)] public string[] ModelLimits { get; set; } = [];
    [Key(7)] public string[] AllowIpCidrs { get; set; } = [];
    [Key(8)] public DateTime? ExpiresAtUtc { get; set; }
}
