using MagicOnion;
using Meeko.Contracts.Tavern.Metering.Dtos;

namespace Meeko.Contracts.Tavern.Metering;

/// <summary>
/// Tavern.Gateway → Meeko.Tavern：对话回合按量计量（预扣 / 提交 / 取消）。
/// 平台侧编排在 <c>TavernQuotaMeter</c>，经 Billing Hold/Commit 落账；网关只 RPC 提交用量。
/// </summary>
public interface ITavernLlmBillingService : IService<ITavernLlmBillingService>
{
    UnaryResult<ReserveTavernTurnResult> ReserveAsync(ReserveTavernTurnCommand command);

    UnaryResult<CommitTavernTurnResult> CommitAsync(CommitTavernTurnCommand command);

    UnaryResult<bool> CancelAsync(long reservationId, string reason);
}
