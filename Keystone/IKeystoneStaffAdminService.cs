using MagicOnion;

namespace Meeko.Contracts.Keystone;

/// <summary>Bff → Keystone：平台 Staff 账号与角色管理。</summary>
public interface IKeystoneStaffAdminService : IService<IKeystoneStaffAdminService>
{
    UnaryResult<StaffAdminListResult> ListStaffAsync(ListStaffQuery query);
    UnaryResult<StaffUserDto?> GetStaffAsync(long staffUid);

    UnaryResult<StaffAdminCommandResult> CreateStaffAsync(CreateStaffCommand cmd);
    UnaryResult<StaffAdminCommandResult> UpdateStaffAsync(UpdateStaffCommand cmd);
    UnaryResult<StaffAdminCommandResult> SetStaffStatusAsync(SetStaffStatusCommand cmd);
    UnaryResult<StaffAdminCommandResult> ResetStaffPasswordAsync(ResetStaffPasswordCommand cmd);
    UnaryResult<StaffAdminCommandResult> ChangeStaffRoleAsync(ChangeStaffRoleCommand cmd);

    UnaryResult<StaffRoleListResult> ListRolesAsync(ListStaffRolesQuery query);
    UnaryResult<StaffRoleDto?> GetRoleAsync(long roleId);
    UnaryResult<StaffAdminCommandResult> CreateRoleAsync(CreateStaffRoleCommand cmd);
    UnaryResult<StaffAdminCommandResult> UpdateRoleAsync(UpdateStaffRoleCommand cmd);
    UnaryResult<StaffAdminCommandResult> DeleteRoleAsync(DeleteStaffRoleCommand cmd);

    UnaryResult<StaffPermissionDto[]> ListPermissionCatalogAsync();
}
