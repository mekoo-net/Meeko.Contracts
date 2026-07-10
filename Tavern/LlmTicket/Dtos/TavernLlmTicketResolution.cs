using Meeko.Contracts.Tavern.Common;
using MessagePack;

namespace Meeko.Contracts.Tavern.LlmTicket;

[MessagePackObject]
public sealed class TavernLlmTicketResolution
{
    [Key(0)] public long TicketId { get; set; }
    [Key(1)] public long AccountUid { get; set; }
    [Key(2)] public long KeystoneSessionId { get; set; }
    [Key(3)] public TavernAuthSessionStatus SessionStatus { get; set; }
    [Key(4)] public DateTime? SessionExpiresAtUtc { get; set; }
}
