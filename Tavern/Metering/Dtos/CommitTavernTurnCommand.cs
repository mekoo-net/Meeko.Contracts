using MessagePack;

namespace Meeko.Contracts.Tavern.Metering.Dtos;

[MessagePackObject]
public sealed class CommitTavernTurnCommand
{
    [Key(0)] public long? ReservationId { get; set; }
    [Key(1)] public long AccountUid { get; set; }
    [Key(2)] public string TraceId { get; set; } = string.Empty;
    /// <summary>本回合全部模型调用的原始用量明细（主对话 + 唤醒判定 + embedding + 媒体生成）。</summary>
    [Key(3)] public TavernModelUsage[] Usages { get; set; } = [];
    /// <summary>上游 / 落库是否成功；失败路径释放 hold、不收费。</summary>
    [Key(4)] public bool UpstreamSuccess { get; set; } = true;
    /// <summary>自主唤醒回合为 true，平台选用 proactive 倍率。</summary>
    [Key(5)] public bool Proactive { get; set; }
    /// <summary>会话 id，落消费明细供用户端"和 XX 的对话"展示。</summary>
    [Key(6)] public string? SessionId { get; set; }
}
