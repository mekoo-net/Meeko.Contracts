using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class BillBusinessInfo
{
    [Key(1)] public string? ProductCode { get; set; }
}
