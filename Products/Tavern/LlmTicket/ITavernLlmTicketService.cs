using MagicOnion;

namespace Meeko.Contracts.Tavern.LlmTicket;

/// <summary>
/// Tavern.Gateway → Meeko.Tavern：sk-api- 会话派生票据校验（introspection）。
/// 验票 = 验关联的 Keystone 会话是否仍有效。
/// </summary>
public interface ITavernLlmTicketService : IService<ITavernLlmTicketService>
{
    /// <summary>解析 sk-api- 凭证；返回 null 表示不存在 / 会话已吊销 / 已过期。</summary>
    UnaryResult<TavernLlmTicketResolution?> ValidateAsync(ValidateTavernLlmTicketQuery query);
}
