using MessagePack;

namespace Meeko.Contracts.Keystone;

[MessagePackObject]
public sealed class AuditEntry
{
    [Key(0)] public required long AccountUid { get; set; }

    /// <summary>user / apikey。</summary>
    [Key(1)] public required string ActorType { get; set; }

    /// <summary>仅 ActorType=apikey 时填。</summary>
    [Key(2)] public long? ActorKeyUid { get; set; }

    /// <summary>例 "iamuser.create" / "apikey.create"。</summary>
    [Key(3)] public required string Action { get; set; }

    [Key(4)] public string? TargetType { get; set; }
    [Key(5)] public string? TargetId { get; set; }
    [Key(6)] public Dictionary<string, string>? Metadata { get; set; }
    [Key(7)] public required string IpAddress { get; set; }
    [Key(8)] public string? UserAgent { get; set; }
}
