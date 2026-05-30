using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class BillRefInfo
{
    /// <summary>recharge / order / subscription / invoice / hold / manual。</summary>
    [Key(0)] public required string Type { get; set; }
    [Key(1)] public required string Id { get; set; }
}
