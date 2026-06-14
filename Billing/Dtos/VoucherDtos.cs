using System.Text.Json.Serialization;
using Meeko.Common.Web;
using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class VoucherTemplateDto
{
    [Key(0)] public required string Id { get; set; }
    [Key(1)] public required string Name { get; set; }
    [Key(19)] public required string Code { get; set; }
    [Key(20)] public VoucherApplyMode ApplyMode { get; set; }
    [Key(2)] public VoucherDeductKind DeductKind { get; set; }
    [Key(3)] public decimal FaceValue { get; set; }
    [Key(4)] public decimal ThresholdAmount { get; set; }
    [Key(5)] public decimal? DiscountRate { get; set; }
    [Key(6)] public VoucherScopeKind ScopeKind { get; set; }
    [Key(7)] public string[] ScopeProductCodes { get; set; } = [];
    [Key(8)] public VoucherValidityKind ValidityKind { get; set; }
    [Key(9)] public DateTime? ValidFromUtc { get; set; }
    [Key(10)] public DateTime? ValidToUtc { get; set; }
    [Key(11)] public int? ValidDays { get; set; }
    [Key(12)] public bool Stackable { get; set; }
    [Key(13)] public int? TotalQuota { get; set; }
    [Key(14)] public int IssuedCount { get; set; }
    [Key(15)] public int? PerUserLimit { get; set; }
    [Key(16)] public VoucherTemplateStatus Status { get; set; }
    [Key(17)] public DateTime CreatedAtUtc { get; set; }
    [Key(18)] public DateTime UpdatedAtUtc { get; set; }
}

[MessagePackObject]
public sealed class ListVoucherTemplatesQuery
{
    [Key(0)] public bool IncludeArchived { get; set; }
    [Key(1)] public int Page { get; set; } = 1;
    [Key(2)] public int PageSize { get; set; } = 20;
}

[MessagePackObject]
public sealed class VoucherTemplateListResult
{
    [Key(0)] public VoucherTemplateDto[] Items { get; set; } = [];
    [Key(1)] public int Total { get; set; }
}

[MessagePackObject]
public sealed class CreateVoucherTemplateCommand
{
    [Key(0)] public required string Name { get; set; }
    [Key(1)] public VoucherDeductKind DeductKind { get; set; }
    [Key(14)] public VoucherApplyMode ApplyMode { get; set; }
    [Key(2)] public decimal FaceValue { get; set; }
    [Key(3)] public decimal ThresholdAmount { get; set; }
    [Key(4)] public decimal? DiscountRate { get; set; }
    [Key(5)] public VoucherScopeKind ScopeKind { get; set; }
    [Key(6)] public string[] ScopeProductCodes { get; set; } = [];
    [Key(7)] public VoucherValidityKind ValidityKind { get; set; }
    [Key(8)] public DateTime? ValidFromUtc { get; set; }
    [Key(9)] public DateTime? ValidToUtc { get; set; }
    [Key(10)] public int? ValidDays { get; set; }
    [Key(11)] public bool Stackable { get; set; }
    [Key(12)] public int? TotalQuota { get; set; }
    [Key(13)] public int? PerUserLimit { get; set; }
}

[MessagePackObject]
public sealed class UpdateVoucherTemplateCommand
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long TemplateId { get; set; }

    [Key(1)] public required string Name { get; set; }
    [Key(2)] public VoucherScopeKind ScopeKind { get; set; }
    [Key(3)] public string[] ScopeProductCodes { get; set; } = [];
    [Key(4)] public VoucherValidityKind ValidityKind { get; set; }
    [Key(5)] public DateTime? ValidFromUtc { get; set; }
    [Key(6)] public DateTime? ValidToUtc { get; set; }
    [Key(7)] public int? ValidDays { get; set; }
    [Key(8)] public bool Stackable { get; set; }
    [Key(9)] public int? TotalQuota { get; set; }
    [Key(10)] public int? PerUserLimit { get; set; }
}

[MessagePackObject]
public sealed class SetVoucherTemplateStatusCommand
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long TemplateId { get; set; }

    [Key(1)] public VoucherTemplateStatus Status { get; set; }
}

[MessagePackObject]
public sealed class IssueVouchersCommand
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long TemplateId { get; set; }

    [Key(1)] public long[] AccountUids { get; set; } = [];
    [Key(2)] public required string BatchToken { get; set; }
}

[MessagePackObject]
public sealed class IssueVouchersResult
{
    [Key(0)] public int IssuedCount { get; set; }
    [Key(1)] public int RequestedCount { get; set; }
}

[MessagePackObject]
public sealed class UserVoucherDto
{
    [Key(0)] public required string Id { get; set; }

    [Key(1)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long TemplateId { get; set; }

    [Key(2)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long AccountUid { get; set; }

    [Key(3)] public string? SerialNo { get; set; }
    [Key(4)] public VoucherDeductKind DeductKind { get; set; }
    [Key(5)] public decimal FaceValue { get; set; }
    [Key(6)] public decimal ThresholdAmount { get; set; }
    [Key(7)] public decimal RemainingValue { get; set; }
    [Key(8)] public DateTime ValidFromUtc { get; set; }
    [Key(9)] public DateTime ValidToUtc { get; set; }
    [Key(10)] public UserVoucherStatus Status { get; set; }
    [Key(11)] public DateTime IssuedAtUtc { get; set; }
}

[MessagePackObject]
public sealed class ListUserVouchersQuery
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long AccountUid { get; set; }

    [Key(1)] public int Page { get; set; } = 1;
    [Key(2)] public int PageSize { get; set; } = 20;
}

[MessagePackObject]
public sealed class ListUserVouchersResult
{
    [Key(0)] public UserVoucherDto[] Items { get; set; } = [];
    [Key(1)] public int Total { get; set; }
}

[MessagePackObject]
public sealed class VoucherRedemptionDto
{
    [Key(0)] public required string Id { get; set; }

    [Key(1)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long UserVoucherId { get; set; }

    [Key(2)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long AccountUid { get; set; }

    [Key(3)] public required string ProductCode { get; set; }
    [Key(4)] public decimal AmountDeducted { get; set; }
    [Key(5)] public DateTime OccurredAtUtc { get; set; }
}

[MessagePackObject]
public sealed class ListVoucherRedemptionsQuery
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long AccountUid { get; set; }

    [Key(1)] public int Take { get; set; } = 100;
}

[MessagePackObject]
public sealed class ListVoucherRedemptionsResult
{
    [Key(0)] public VoucherRedemptionDto[] Items { get; set; } = [];
}
