using MessagePack;

namespace Meeko.Contracts.Billing.Redemptions;

[MessagePackObject]
public sealed class GetRedemptionOverviewQuery
{
    /// <summary>「今日」的起点。由前端按浏览器本地零点给出，不传按 UTC 零点。</summary>
    [Key(0)] public DateTime? DayStartUtc { get; set; }
}
