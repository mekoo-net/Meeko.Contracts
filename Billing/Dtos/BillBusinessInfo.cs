using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class BillBusinessInfo
{
    [Key(0)] public required string Domain { get; set; }
    [Key(1)] public string? ProductCode { get; set; }
}
