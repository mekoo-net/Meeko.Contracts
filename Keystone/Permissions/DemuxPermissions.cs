namespace Meeko.Contracts.Keystone.Permissions;

/// <summary>
/// Demux 产品控制台 permission 码（Keystone account 域 RBAC）。
/// 命名：<c>demux:{resource}:{action}</c>，与平台通用 <see cref="AccountPermissions"/> 分离。
/// </summary>
public static class DemuxPermissions
{
    public const string RedemptionRead = "demux:redemption:read";
    public const string RedemptionWrite = "demux:redemption:write";

    public const string ModelsRead = "demux:models:read";
    public const string ModelsWrite = "demux:models:write";

    public const string ProvidersRead = "demux:providers:read";
    public const string ProvidersWrite = "demux:providers:write";

    public const string PricingRead = "demux:pricing:read";
    public const string PricingWrite = "demux:pricing:write";

    public const string RoutesRead = "demux:routes:read";
    public const string RoutesWrite = "demux:routes:write";

    public const string BackendsRead = "demux:backends:read";
    public const string BackendsWrite = "demux:backends:write";

    public const string UsageRead = "demux:usage:read";
    public const string UsageWrite = "demux:usage:write";

    public const string UsersRead = "demux:users:read";
    public const string UsersWrite = "demux:users:write";

    public const string TasksRead = "demux:tasks:read";

    public const string RateLimitRead = "demux:ratelimit:read";
    public const string RateLimitWrite = "demux:ratelimit:write";

    public static readonly IReadOnlyCollection<string> All =
    [
        RedemptionRead, RedemptionWrite,
        ModelsRead, ModelsWrite,
        ProvidersRead, ProvidersWrite,
        PricingRead, PricingWrite,
        RoutesRead, RoutesWrite,
        BackendsRead, BackendsWrite,
        UsageRead, UsageWrite,
        UsersRead, UsersWrite,
        TasksRead,
        RateLimitRead, RateLimitWrite,
    ];

    /// <summary>Demux 控制台只读子集（未来可赋给审计类角色）。</summary>
    public static readonly IReadOnlyCollection<string> ReadOnly =
    [
        RedemptionRead,
        ModelsRead, ProvidersRead, PricingRead, RoutesRead, BackendsRead,
        UsageRead, UsersRead, TasksRead,
        RateLimitRead,
    ];
}
