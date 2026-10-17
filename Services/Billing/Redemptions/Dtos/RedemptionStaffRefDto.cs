using System.Text.Json.Serialization;
using MessagePack;
using Platform.Common.Web;

namespace Meeko.Contracts.Billing.Redemptions;

/// <summary>后台操作人。Billing 只知道 uid，展示名由 BFF 补全。</summary>
[MessagePackObject]
public sealed class RedemptionStaffRefDto
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long Uid { get; set; }

    [Key(1)] public string? DisplayName { get; set; }
}
