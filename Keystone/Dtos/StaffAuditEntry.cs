using MessagePack;

namespace Meeko.Contracts.Keystone;

[MessagePackObject]
public sealed class StaffAuditEntry
{
    [Key(0)] public required long StaffUid { get; set; }
    [Key(1)] public required string Action { get; set; }
    [Key(2)] public long? TargetAccountUid { get; set; }
    [Key(3)] public string? TargetType { get; set; }
    [Key(4)] public string? TargetId { get; set; }
    [Key(5)] public Dictionary<string, string>? Metadata { get; set; }
    [Key(6)] public required string IpAddress { get; set; }
    [Key(7)] public string? UserAgent { get; set; }
}
