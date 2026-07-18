namespace Meeko.Contracts.Keystone.Permissions;

/// <summary>
/// Demux 产品管理域 permission 码（平台 Staff 域 RBAC，DB <c>keystone_staff.staff_permissions.code</c>）。
/// Demux 管理面是跨账号的平台运营功能（用户/厂商/模型/定价/日志），只授予 Staff 角色。
/// Keystone <b>不</b>引用本类：Demux 启动时经 <c>IKeystoneStaffAdminService.RegisterPermissionCatalogAsync</c>
/// 自注册目录（见 DemuxPermissionCatalogRegistrar），新码自动授予 SuperAdmin（全部）/ReadOnly（只读子集）。
/// Account/IAM 域绝不授予这些码 —— 租户侧只有 self 视图（[Authorize] + 按 uid 过滤）。
/// 命名：<c>demux:{resource}:{action}</c>，与 <see cref="StaffPermissions"/> 平台通用码分离。
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
