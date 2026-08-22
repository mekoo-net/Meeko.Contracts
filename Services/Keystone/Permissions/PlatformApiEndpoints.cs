namespace Meeko.Contracts.Keystone.Permissions;

/// <summary>
/// 令牌可开通的<b>现有</b>后台接口。存 METHOD + 路径模板，不另开调用面。
/// </summary>
public static class PlatformApiEndpoints
{
    public const string ListAccounts = "GET /api/admin/accounts";
    public const string IssueVouchers = "POST /api/admin/billing/voucher/templates/{templateId}/issue";

    public static readonly IReadOnlyCollection<string> All =
    [
        ListAccounts,
        IssueVouchers,
    ];

    public static string Normalize(string grant) => grant.Trim();

    public static bool Allows(string grant, string method, string? requestPath)
    {
        if (string.IsNullOrEmpty(requestPath)) return false;

        var normalized = Normalize(grant);
        if (!All.Contains(normalized, StringComparer.OrdinalIgnoreCase))
            return false;

        return Matches(normalized, method, requestPath);
    }

    private static bool Matches(string grant, string method, string requestPath)
    {
        var space = grant.IndexOf(' ');
        if (space < 0) return false;
        if (!string.Equals(grant[..space], method, StringComparison.OrdinalIgnoreCase))
            return false;

        var templateSegs = grant[(space + 1)..].TrimEnd('/').Split('/');
        var pathSegs = requestPath.TrimEnd('/').Split('/');
        if (templateSegs.Length != pathSegs.Length) return false;

        for (var i = 0; i < templateSegs.Length; i++)
        {
            var t = templateSegs[i];
            if (t.Length >= 2 && t[0] == '{' && t[^1] == '}') continue;
            if (!string.Equals(t, pathSegs[i], StringComparison.OrdinalIgnoreCase))
                return false;
        }

        return true;
    }
}
