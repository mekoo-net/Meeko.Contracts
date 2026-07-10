using MessagePack;

namespace Meeko.Contracts.Tavern.LlmTicket;

[MessagePackObject]
public sealed class ValidateTavernLlmTicketQuery
{
    /// <summary>客户端 Bearer 携带的 sk-api- 凭证（可含前缀）。</summary>
    [Key(0)] public string Credential { get; set; } = string.Empty;

    [Key(1)] public string? ClientIp { get; set; }
}
