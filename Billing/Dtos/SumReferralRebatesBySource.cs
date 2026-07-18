using System.Text.Json.Serialization;
using Meeko.Common.Web;
using MessagePack;

namespace Meeko.Contracts.Billing;

[MessagePackObject]
public sealed class SumReferralRebatesBySourceQuery
{
    /// <summary>返利受益人（邀请人）账户。</summary>
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long BeneficiaryAccountUid { get; set; }

    /// <summary>来源账户（被邀请人）集合；为空返回空结果。</summary>
    [Key(1)] public long[] SourceAccountUids { get; set; } = [];
}

[MessagePackObject]
public sealed class ReferralRebateSourceSumDto
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long SourceAccountUid { get; set; }

    [Key(1)] public decimal RebateTotal { get; set; }
}

[MessagePackObject]
public sealed class SumReferralRebatesBySourceResult
{
    [Key(0)] public ReferralRebateSourceSumDto[] Items { get; set; } = [];
}
