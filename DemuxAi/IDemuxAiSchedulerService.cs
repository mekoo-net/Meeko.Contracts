using MagicOnion;
using Meeko.Contracts.Billing;

namespace Meeko.Contracts.DemuxAi;

/// <summary>
/// Meeko.Jobs（Hangfire）→ DemuxAi：调度类操作入口。
///
/// 两类职责：
///   1. <see cref="ExpireReservationsAsync"/> —— 扫描已超过 TTL 的 Active 预扣记录，释放
///      Billing hold 并标记 Expired，作为"hold TTL 兜底"（Gateway 侧理论上已在 cancel，
///      这里是双重保险）。
///   2. <see cref="RollupQuotaDailyAsync"/> —— 将 ai_usage_logs 中指定日期的成功记录
///      聚合到 quota_daily，为前端"按日/按模型"图表提供低成本的汇总视图。
/// </summary>
public interface IDemuxAiSchedulerService : IService<IDemuxAiSchedulerService>
{
    /// <summary>
    /// 扫描 usage_reservations 中已过期的 Active 记录（expires_at_utc &lt; now()），
    /// 对每条：先释放 Billing hold，再将 reservation 状态改为 Expired。
    /// </summary>
    /// <param name="batchSize">单次处理的最大行数，避免大事务。建议 100–500。</param>
    UnaryResult<SchedulerResult> ExpireReservationsAsync(int batchSize);

    /// <summary>
    /// 将 ai_usage_logs 中 dateUtc 那天（UTC）的成功记录聚合到 quota_daily。
    /// 如果目标行已存在则 UPSERT（同一 job 重跑幂等）。
    /// </summary>
    /// <param name="dateUtc">目标日期，精确到日（时分秒忽略）；通常传"昨天"。</param>
    UnaryResult<SchedulerResult> RollupQuotaDailyAsync(DateTime dateUtc);
}
