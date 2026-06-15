using System.Text.Json.Serialization;
using Meeko.Common.Web;
using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class VoucherGrantRuleItemDto
{
    [Key(0)] public required string TemplateId { get; set; }
    [Key(1)] public string? TemplateName { get; set; }
    [Key(2)] public string? TemplateCode { get; set; }
}

[MessagePackObject]
public sealed class VoucherGrantRuleDto
{
    [Key(0)] public required string Id { get; set; }
    [Key(1)] public required string Name { get; set; }
    [Key(2)] public required string TriggerEventType { get; set; }
    [Key(3)] public GrantConditionKind ConditionKind { get; set; }
    [Key(4)] public decimal? ThresholdAmount { get; set; }
    [Key(5)] public string? ScopeProductCode { get; set; }
    [Key(6)] public VoucherGrantRuleItemDto[] Items { get; set; } = [];
    [Key(7)] public DateTime? StartAtUtc { get; set; }
    [Key(8)] public DateTime? EndAtUtc { get; set; }
    [Key(9)] public int? TotalQuota { get; set; }
    [Key(10)] public int GrantedCount { get; set; }
    [Key(11)] public int? PerUserLimit { get; set; }
    [Key(12)] public VoucherGrantRuleStatus Status { get; set; }
    [Key(13)] public DateTime CreatedAtUtc { get; set; }
}

[MessagePackObject]
public sealed class VoucherGrantRuleListResult
{
    [Key(0)] public VoucherGrantRuleDto[] Items { get; set; } = [];
    [Key(1)] public int Total { get; set; }
}

[MessagePackObject]
public sealed class CreateVoucherGrantRuleCommand
{
    [Key(0)] public required string Name { get; set; }
    [Key(1)] public required string TriggerEventType { get; set; }
    [Key(2)] public GrantConditionKind ConditionKind { get; set; }
    [Key(3)] public long[] TemplateIds { get; set; } = [];
    [Key(4)] public decimal? ThresholdAmount { get; set; }
    [Key(5)] public string? ScopeProductCode { get; set; }
    [Key(6)] public DateTime? StartAtUtc { get; set; }
    [Key(7)] public DateTime? EndAtUtc { get; set; }
    [Key(8)] public int? TotalQuota { get; set; }
    [Key(9)] public int? PerUserLimit { get; set; }
}

[MessagePackObject]
public sealed class UpdateVoucherGrantRuleCommand
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long RuleId { get; set; }

    [Key(1)] public required string Name { get; set; }
    [Key(2)] public decimal? ThresholdAmount { get; set; }
    [Key(3)] public string? ScopeProductCode { get; set; }
    [Key(4)] public DateTime? StartAtUtc { get; set; }
    [Key(5)] public DateTime? EndAtUtc { get; set; }
    [Key(6)] public int? TotalQuota { get; set; }
    [Key(7)] public int? PerUserLimit { get; set; }
}

[MessagePackObject]
public sealed class SetVoucherGrantRuleStatusCommand
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long RuleId { get; set; }

    [Key(1)] public VoucherGrantRuleStatus Status { get; set; }
}

[MessagePackObject]
public sealed class ListVoucherGrantRulesQuery
{
    [Key(0)] public string? TriggerEventType { get; set; }
    [Key(1)] public bool IncludeEnded { get; set; }
    [Key(2)] public int Page { get; set; } = 1;
    [Key(3)] public int PageSize { get; set; } = 20;
}

/// <summary>
/// 外部业务方（如 Keystone 注册流程）投递的触发事件，喂给 Billing 自动发券引擎。
/// <see cref="EventKey"/> 决定去重粒度（账户级 / 单笔级）。
/// </summary>
[MessagePackObject]
public sealed class GrantEventCommand
{
    [Key(0)] public required string EventType { get; set; }
    [Key(1)] public required string EventKey { get; set; }

    [Key(2)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long AccountUid { get; set; }

    [Key(3)] public decimal? Amount { get; set; }
    [Key(4)] public string? ProductCode { get; set; }
    [Key(5)] public DateTime? OccurredAtUtc { get; set; }
}
