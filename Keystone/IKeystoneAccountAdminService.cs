using MagicOnion;

namespace Meeko.Contracts.Keystone;

/// <summary>
/// Bff → Keystone：账户管理面（list / detail / update / status / create IAM）。
/// 鉴权由 Bff 完成；本服务面向运营 Admin 调用，方法层面不再二次鉴权。
/// </summary>
public interface IKeystoneAccountAdminService : IService<IKeystoneAccountAdminService>
{
    UnaryResult<AccountAdminListResult> ListAccountsAsync(ListAccountsQuery query);

    UnaryResult<AccountAdminDetail?> GetAccountAdminAsync(long accountUid);

    UnaryResult<AccountAdminCommandResult> UpdateAccountAsync(UpdateAccountCommand cmd);

    UnaryResult<AccountAdminCommandResult> SetAccountStatusAsync(SetAccountStatusCommand cmd);

    UnaryResult<AccountAdminCommandResult> GrantAchievementAsync(GrantAchievementCommand cmd);

    UnaryResult<AccountAdminCommandResult> RevokeAchievementAsync(RevokeAchievementCommand cmd);

    UnaryResult<CreateIamUserAdminResult> CreateIamUserAsync(CreateIamUserAdminCommand cmd);
}
