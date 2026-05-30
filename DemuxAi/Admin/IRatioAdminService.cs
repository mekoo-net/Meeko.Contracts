using MagicOnion;
using Meeko.Contracts.DemuxAi.Common;

namespace Meeko.Contracts.DemuxAi.Admin;

public interface IRatioAdminService : IService<IRatioAdminService>
{
    UnaryResult<ListRatiosResult> ListAsync(ListRatiosQuery query);
    UnaryResult<AdminCommandResult> UpsertAsync(UpsertRatioCommand cmd);
    UnaryResult<AdminCommandResult> DeleteAsync(DeleteRatioCommand cmd);
    UnaryResult<RatioVersionDto[]> ListVersionsAsync(int take);
}
