using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class ListBillsResult
{
    [Key(0)] public required BillDto[] Items { get; set; }
    [Key(1)] public required int Total { get; set; }
}
