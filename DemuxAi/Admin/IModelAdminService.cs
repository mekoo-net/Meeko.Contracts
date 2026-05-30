using MagicOnion;
using Meeko.Contracts.DemuxAi.Common;

namespace Meeko.Contracts.DemuxAi.Admin;

public interface IModelAdminService : IService<IModelAdminService>
{
    UnaryResult<ModelMetaAdminDto[]> ListAsync();
    UnaryResult<ModelMetaAdminDto?> GetAsync(long id);
    UnaryResult<AdminCommandResult> UpsertAsync(UpsertModelMetaCommand cmd);
    UnaryResult<AdminCommandResult> DeleteAsync(long id);
}
