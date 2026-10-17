using System.Text.Json.Serialization;
using MessagePack;
using Platform.Common.Web;

namespace Meeko.Contracts.Billing.Redemptions;

/// <summary>兑换账户。Billing 只知道 uid，邮箱 / 展示名由 BFF 补全。</summary>
[MessagePackObject]
public sealed class RedemptionAccountRefDto
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long Uid { get; set; }

    [Key(1)] public string? Email { get; set; }
    [Key(2)] public string? DisplayName { get; set; }
}
