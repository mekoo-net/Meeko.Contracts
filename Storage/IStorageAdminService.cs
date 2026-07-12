using MagicOnion;
using Meeko.Contracts.Storage.Dtos;

namespace Meeko.Contracts.Storage;

/// <summary>
/// 存储后端管理 RPC：CRUD + 连通性测试。调用方需具备 <see cref="Keystone.Permissions.StaffPermissions.StorageBackendRead"/> / Write。
/// </summary>
public interface IStorageAdminService : IService<IStorageAdminService>
{
    UnaryResult<StorageBackendDto[]> ListAsync();
    UnaryResult<StorageBackendDto?> GetAsync(long id);
    UnaryResult<StorageAdminCommandResult> CreateAsync(CreateStorageBackendCommand cmd);
    UnaryResult<StorageAdminCommandResult> UpdateAsync(UpdateStorageBackendCommand cmd);
    UnaryResult<StorageAdminCommandResult> DeleteAsync(long id);
    UnaryResult<TestStorageBackendResult> TestAsync(long id);

    /// <summary>对象引用溯源：这个文件是谁存的、什么时候存的、现在有哪些账号在引用（含已释放的历史引用）。</summary>
    UnaryResult<StorageObjectRefsResult> ListObjectRefsAsync(string storageKey);
}
