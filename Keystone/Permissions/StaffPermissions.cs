namespace Meeko.Contracts.Keystone.Permissions;

/// <summary>
/// 平台 Staff 域权限码（DB <c>keystone_staff.staff_permissions.code</c>）。
/// 命名规则：<c>{domain}.{resource}.{action}</c>，全部小写、点号分段。
/// 角色映射在 KeystoneDevDataSeeder 中初始化；变更角色权限映射时 Keystone 负责 invalidate 缓存。
/// </summary>
public static class StaffPermissions
{
    public const string PlatformRead = "platform.read";
    public const string PlatformStaffRead = "platform.staff.read";
    public const string PlatformStaffWrite = "platform.staff.write";
    public const string PlatformRoleRead = "platform.role.read";
    public const string PlatformRoleWrite = "platform.role.write";
    public const string PlatformSettingsRead = "platform.settings.read";
    public const string PlatformSettingsWrite = "platform.settings.write";

    public const string NoticeTemplateRead = "notice.template.read";
    public const string NoticeTemplateWrite = "notice.template.write";

    public const string NoticeChannelRead = "notice.channel.read";
    public const string NoticeChannelWrite = "notice.channel.write";

    public const string BillingRechargeRead = "billing.recharge.read";
    public const string BillingRechargeWrite = "billing.recharge.write";

    public const string BillingBillRead = "billing.bill.read";
    public const string BillingBillWrite = "billing.bill.write";

    public const string BillingChannelRead = "billing.channel.read";
    public const string BillingChannelWrite = "billing.channel.write";

    public const string AccountAdminRead = "account.admin.read";
    public const string AccountAdminWrite = "account.admin.write";

    /// <summary>所有 Staff 平台权限码的完整集合，用于 seed SuperAdmin。</summary>
    public static readonly IReadOnlyCollection<string> All =
    [
        PlatformRead,
        PlatformStaffRead, PlatformStaffWrite,
        PlatformRoleRead, PlatformRoleWrite,
        PlatformSettingsRead, PlatformSettingsWrite,
        NoticeTemplateRead, NoticeTemplateWrite,
        NoticeChannelRead, NoticeChannelWrite,
        BillingRechargeRead, BillingRechargeWrite,
        BillingBillRead, BillingBillWrite,
        BillingChannelRead, BillingChannelWrite,
        AccountAdminRead, AccountAdminWrite,
    ];

    /// <summary>只读子集（用于 seed ReadOnly 角色）。</summary>
    public static readonly IReadOnlyCollection<string> ReadOnly =
    [
        PlatformRead,
        PlatformStaffRead,
        PlatformRoleRead,
        PlatformSettingsRead,
        NoticeTemplateRead,
        NoticeChannelRead,
        BillingRechargeRead,
        BillingBillRead,
        BillingChannelRead,
        AccountAdminRead,
    ];
}
