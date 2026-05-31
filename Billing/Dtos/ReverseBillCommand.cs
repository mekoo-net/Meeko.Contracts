using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class ReverseBillCommand
{
    [Key(0)] public long BillId { get; set; }
    [Key(1)] public required decimal RefundedAmount { get; set; }
    [Key(2)] public required string Code { get; set; }
    [Key(3)] public string? Note { get; set; }
    [Key(4)] public string? IdempotencyKey { get; set; }
    [Key(5)] public long? OperatorIamUserUid { get; set; }
    [Key(6)] public string? BillSerialNo { get; set; }
}
