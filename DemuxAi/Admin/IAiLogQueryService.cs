using MagicOnion;

namespace Meeko.Contracts.DemuxAi.Admin;

/// <summary>AI 用量日志查询：Admin 全量；用户面只能查自己 Account 下的日志（由 BFF 强制）。</summary>
public interface IAiLogQueryService : IService<IAiLogQueryService>
{
    UnaryResult<ListAiLogsResult> ListAsync(ListAiLogsQuery query);
    UnaryResult<AiUsageLogDto?> GetAsync(long id);
    UnaryResult<AiLogStatDto[]> StatDailyAsync(AiLogStatQuery query);

    UnaryResult<ReverseAiLogResult> ReverseAsync(ReverseAiLogCommand cmd);
}
