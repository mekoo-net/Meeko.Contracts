namespace Meeko.Contracts.Keystone.Permissions;

/// <summary>
/// Account 域 IamUser 权限码（DB <c>keystone.permissions.code</c>）。
/// 命名规则见 Meeko-Keystone.md §4.1；同时作为 API Key scope 使用。
/// </summary>
public static class AccountPermissions
{
    public const string AccountRead = "account:read";
    public const string AccountUpdate = "account:update";
    public const string AccountUpgrade = "account:upgrade";
    public const string AccountTransferOwnership = "account:transfer-ownership";
    public const string AccountDelete = "account:delete";

    public const string IamUserCreate = "iamuser:create";
    public const string IamUserUpdate = "iamuser:update";
    public const string IamUserDelete = "iamuser:delete";
    public const string IamUserList = "iamuser:list";

    public const string ApiKeyCreateSelf = "apikey:create-self";
    public const string ApiKeyCreateAccount = "apikey:create-account";
    public const string ApiKeyRevokeSelf = "apikey:revoke-self";
    public const string ApiKeyRevokeAny = "apikey:revoke-any";
    public const string ApiKeyList = "apikey:list";

    public const string InferenceInvoke = "inference:invoke";
    public const string InferenceStream = "inference:stream";

    public const string ModelsRead = "models:read";
    public const string ModelsWrite = "models:write";

    public const string UsageRead = "usage:read";
    public const string UsageReadSelf = "usage:read-self";

    public const string BillingRead = "billing:read";
    public const string BillingWrite = "billing:write";
    public const string BillingInvoiceDownload = "billing:invoice-download";

    public static readonly IReadOnlyCollection<string> All =
    [
        AccountRead, AccountUpdate, AccountUpgrade, AccountTransferOwnership, AccountDelete,
        IamUserCreate, IamUserUpdate, IamUserDelete, IamUserList,
        ApiKeyCreateSelf, ApiKeyCreateAccount, ApiKeyRevokeSelf, ApiKeyRevokeAny, ApiKeyList,
        InferenceInvoke, InferenceStream,
        ModelsRead, ModelsWrite,
        UsageRead, UsageReadSelf,
        BillingRead, BillingWrite, BillingInvoiceDownload,
        .. DemuxPermissions.All,
    ];

    /// <summary>Owner：全量权限。</summary>
    public static readonly IReadOnlyCollection<string> Owner = All;

    /// <summary>Admin：除账户销毁/转让外的管理权限 + Demux 控制台全量。</summary>
    public static readonly IReadOnlyCollection<string> Admin =
    [
        AccountRead, AccountUpdate, AccountUpgrade,
        IamUserCreate, IamUserUpdate, IamUserDelete, IamUserList,
        ApiKeyCreateSelf, ApiKeyCreateAccount, ApiKeyRevokeSelf, ApiKeyRevokeAny, ApiKeyList,
        InferenceInvoke, InferenceStream,
        ModelsRead, ModelsWrite,
        UsageRead, UsageReadSelf,
        BillingRead, BillingWrite, BillingInvoiceDownload,
        .. DemuxPermissions.All,
    ];

    /// <summary>Member：自助使用面。</summary>
    public static readonly IReadOnlyCollection<string> Member =
    [
        AccountRead, AccountUpdate,
        ApiKeyCreateSelf, ApiKeyRevokeSelf, ApiKeyList,
        InferenceInvoke, InferenceStream,
        UsageReadSelf,
        BillingRead,
    ];

    /// <summary>Billing：Member + 计费写权限。</summary>
    public static readonly IReadOnlyCollection<string> Billing =
    [
        .. Member,
        BillingWrite, BillingInvoiceDownload,
    ];
}
