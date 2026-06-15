using MagicOnion;

namespace Meeko.Contracts.DemuxAi.Admin;

/// <summary>AI 用量日志查询：Admin 全量；用户面只能查自己 Account 下的日志（由 BFF 强制）。</summary>
public interface IAiLogQueryService : IService<IAiLogQueryService>
{
    UnaryResult<ListAiLogsResult> ListAsync(ListAiLogsQuery query);
    UnaryResult<AiUsageLogDto?> GetAsync(long id);

    /// <summary>
    /// 批量把 request_id 解析为调用日志号（UsageLog.Id）。供产品域据账单流水的 request_id
    /// 反查发起它的调用日志；未命中的 request_id 不出现在结果里。
    /// </summary>
    UnaryResult<LogRequestRefDto[]> ResolveLogIdsByRequestIdsAsync(string[] requestIds);
    UnaryResult<AiLogStatDto[]> StatDailyAsync(AiLogStatQuery query);
    UnaryResult<AiVendorStatDto[]> StatByVendorAsync(AiVendorStatQuery query);

    UnaryResult<ReverseAiLogResult> ReverseAsync(ReverseAiLogCommand cmd);
}
