using MagicOnion;
using MessagePack;

namespace Meeko.Contracts.Keystone;

public interface IKeystoneReferralService : IService<IKeystoneReferralService>
{
    UnaryResult<long?> GetInviterAsync(long accountUid);

    UnaryResult<int> GetInviteCountAsync(long accountUid);

    UnaryResult<Dtos.ListReferralInviteesResult> ListInviteesAsync(Dtos.ListReferralInviteesQuery query);

    UnaryResult<Dtos.AccountReferralAdminWireDto?> GetAccountReferralAdminAsync(long accountUid);

    UnaryResult<bool> UnlinkInviterAsync(long accountUid);
}
