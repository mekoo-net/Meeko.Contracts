using System.Text.Json.Serialization;
using Meeko.Common.Web;
using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class VoucherCodeBatchDto
{
    [Key(0)] public required string Id { get; set; }

    [Key(1)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long TemplateId { get; set; }

    [Key(2)] public string? TemplateName { get; set; }
    [Key(3)] public string? TemplateCode { get; set; }
    [Key(4)] public required string Label { get; set; }
    [Key(5)] public int TotalCount { get; set; }
    [Key(6)] public int RedeemedCount { get; set; }
    [Key(7)] public DateTime? ExpiresAtUtc { get; set; }
    [Key(8)] public VoucherCodeBatchStatus Status { get; set; }
    [Key(9)] public DateTime CreatedAtUtc { get; set; }
}

[MessagePackObject]
public sealed class VoucherCodeBatchListResult
{
    [Key(0)] public VoucherCodeBatchDto[] Items { get; set; } = [];
}

[MessagePackObject]
public sealed class VoucherRedeemCodeDto
{
    [Key(0)] public required string Id { get; set; }
    [Key(1)] public required string Code { get; set; }
    [Key(2)] public VoucherRedeemCodeStatus Status { get; set; }

    [Key(3)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long? RedeemedByUid { get; set; }

    [Key(4)] public DateTime? RedeemedAtUtc { get; set; }
}

[MessagePackObject]
public sealed class ListRedeemCodesResult
{
    [Key(0)] public VoucherRedeemCodeDto[] Items { get; set; } = [];
}

[MessagePackObject]
public sealed class GenerateRedeemCodesCommand
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long TemplateId { get; set; }

    [Key(1)] public string? Label { get; set; }
    [Key(2)] public int Count { get; set; }
    [Key(3)] public DateTime? ExpiresAtUtc { get; set; }
}

[MessagePackObject]
public sealed class ListCodeBatchesQuery
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long? TemplateId { get; set; }

    [Key(1)] public bool IncludeDisabled { get; set; }
}

[MessagePackObject]
public sealed class ListRedeemCodesQuery
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long BatchId { get; set; }

    [Key(1)] public int Take { get; set; } = 1000;
}

[MessagePackObject]
public sealed class RedeemVoucherCodeCommand
{
    [Key(0)] public required string Code { get; set; }

    [Key(1)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long AccountUid { get; set; }
}
