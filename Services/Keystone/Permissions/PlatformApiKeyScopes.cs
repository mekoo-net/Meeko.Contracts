namespace Meeko.Contracts.Keystone.Permissions;

/// <summary>平台 API Key 可挂的权限码。每把 Key 独立勾选，不从角色或产品线继承。</summary>
public static class PlatformApiKeyScopes
{
    public const string AccountLookup = "account.lookup";
    public const string VoucherIssue = "billing.voucher.issue";

    public static readonly IReadOnlyCollection<string> All =
    [
        AccountLookup,
        VoucherIssue,
    ];
}
