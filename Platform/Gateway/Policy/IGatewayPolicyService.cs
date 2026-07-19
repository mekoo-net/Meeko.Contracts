using MagicOnion;
using MessagePack;

namespace Meeko.Contracts.Gateway.Policy;

/// <summary>
/// Gateway → Keystone：限流策略 / 封禁状态查询。Meeko-Keystone.md §10.2。
/// v1.0 占位实现固定返回；v1.1 实质化以支持按 Account 等级差异化限流。
/// </summary>
public interface IGatewayPolicyService : IService<IGatewayPolicyService>
{
    /// <summary>
    /// 查询某 Account 的限流策略（每分钟请求数、突发桶大小等）。
    /// </summary>
    UnaryResult<RateLimitPolicy> GetRateLimitForAccountAsync(long accountUid);

    /// <summary>
    /// 快速封禁检查（命中后 Gateway 直接 403）。
    /// </summary>
    UnaryResult<bool> IsAccountSuspendedAsync(long accountUid);
}

[MessagePackObject]
public sealed class RateLimitPolicy
{
    /// <summary>每分钟最大请求数（默认值，v1.0 固定 600）。</summary>
    [Key(0)] public required int RequestsPerMinute { get; init; }

    /// <summary>突发桶容量（默认值，v1.0 固定 60）。</summary>
    [Key(1)] public required int BurstCapacity { get; init; }
}
