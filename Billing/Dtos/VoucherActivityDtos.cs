using System.Text.Json.Serialization;
using Meeko.Common.Web;
using Meeko.Contracts.Keystone;
using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class VoucherActivityItemDto
{
    [Key(0)] public required string TemplateId { get; set; }
    [Key(1)] public string? TemplateName { get; set; }
    [Key(2)] public string? TemplateCode { get; set; }
}

[MessagePackObject]
public sealed class VoucherActivityDto
{
    [Key(0)] public required string Id { get; set; }
    [Key(1)] public required string Name { get; set; }
    [Key(2)] public VoucherActivityItemDto[] Items { get; set; } = [];
    [Key(3)] public int PickCount { get; set; }
    [Key(4)] public required string ClaimKey { get; set; }
    [Key(5)] public DateTime? StartAtUtc { get; set; }
    [Key(6)] public DateTime? EndAtUtc { get; set; }
    [Key(7)] public int? TotalQuota { get; set; }
    [Key(8)] public int ClaimedCount { get; set; }
    [Key(9)] public int? PerUserLimit { get; set; }
    [Key(10)] public VoucherActivityStatus Status { get; set; }
    [Key(11)] public DateTime CreatedAtUtc { get; set; }
}

[MessagePackObject]
public sealed class VoucherActivityListResult
{
    [Key(0)] public VoucherActivityDto[] Items { get; set; } = [];
    [Key(1)] public int Total { get; set; }
}

[MessagePackObject]
public sealed class ActivityClaimerDto
{
    [Key(0)] public required string Id { get; set; }

    [Key(1)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long AccountUid { get; set; }

    [Key(2)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long UserVoucherId { get; set; }

    [Key(3)] public DateTime ClaimedAtUtc { get; set; }
    [Key(4)] public string? ClaimIp { get; set; }
    [Key(5)] public UserVoucherStatus Status { get; set; }

    /// <summary>账户联系信息，由 Bff 按当前页 uid 批量补全（Billing 侧留空）。</summary>
    [Key(6)] public AccountContactDto? Contact { get; set; }
}

[MessagePackObject]
public sealed class ActivityClaimersResult
{
    [Key(0)] public ActivityClaimerDto[] Items { get; set; } = [];
    [Key(1)] public int Total { get; set; }
}

[MessagePackObject]
public sealed class CreateVoucherActivityCommand
{
    [Key(0)] public required string Name { get; set; }
    [Key(1)] public long[] TemplateIds { get; set; } = [];
    [Key(2)] public int PickCount { get; set; }
    [Key(3)] public DateTime? StartAtUtc { get; set; }
    [Key(4)] public DateTime? EndAtUtc { get; set; }
    [Key(5)] public int? TotalQuota { get; set; }
    [Key(6)] public int? PerUserLimit { get; set; }
}

[MessagePackObject]
public sealed class UpdateVoucherActivityCommand
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long ActivityId { get; set; }

    [Key(1)] public required string Name { get; set; }
    [Key(2)] public DateTime? StartAtUtc { get; set; }
    [Key(3)] public DateTime? EndAtUtc { get; set; }
    [Key(4)] public int? TotalQuota { get; set; }
    [Key(5)] public int? PerUserLimit { get; set; }
}

[MessagePackObject]
public sealed class SetVoucherActivityStatusCommand
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long ActivityId { get; set; }

    [Key(1)] public VoucherActivityStatus Status { get; set; }
}

[MessagePackObject]
public sealed class ListVoucherActivitiesQuery
{
    [Key(0)]
    [JsonConverter(typeof(NullableLongToStringConverter))]
    public long? TemplateId { get; set; }

    [Key(1)] public bool IncludeEnded { get; set; }
    [Key(2)] public int Page { get; set; } = 1;
    [Key(3)] public int PageSize { get; set; } = 20;
}

[MessagePackObject]
public sealed class ListActivityClaimersQuery
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long ActivityId { get; set; }

    [Key(1)]
    [JsonConverter(typeof(NullableLongToStringConverter))]
    public long? AccountUid { get; set; }

    [Key(2)] public UserVoucherStatus? Status { get; set; }
    [Key(3)] public int Page { get; set; } = 1;
    [Key(4)] public int PageSize { get; set; } = 20;
}
