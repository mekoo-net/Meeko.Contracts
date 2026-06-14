using System.Text.Json.Serialization;
using Meeko.Common.Web;
using MessagePack;

namespace Meeko.Contracts.Billing;

/// <summary>
/// 账单扣费明细聚合对象。一笔用量扣费账单的"钱从哪来"拆分：先用代金券抵扣，
/// 不足部分再扣钱包余额。仅用量扣费（Commit）类账单有值，充值等加钱类为 null。
/// </summary>
[MessagePackObject]
public sealed class BillDeductionDto
{
    /// <summary>应扣总额（= 代金券抵扣 + 余额扣除），等于账单原价。</summary>
    [Key(0)] public decimal Total { get; set; }

    /// <summary>代金券抵扣合计。</summary>
    [Key(1)] public decimal VoucherDeducted { get; set; }

    /// <summary>钱包余额实际扣除额。</summary>
    [Key(2)] public decimal BalanceDeducted { get; set; }

    /// <summary>各张代金券的抵扣明细（按用户券聚合）。</summary>
    [Key(3)] public BillVoucherDeductionDto[] VoucherItems { get; set; } = [];
}

/// <summary>单张代金券在某账单上的抵扣额。</summary>
[MessagePackObject]
public sealed class BillVoucherDeductionDto
{
    [Key(0)]
    [JsonConverter(typeof(LongToStringConverter))]
    public long UserVoucherId { get; set; }

    /// <summary>券面序列号（如 VC...），便于对账定位；可空。</summary>
    [Key(2)] public string? SerialNo { get; set; }

    [Key(1)] public decimal AmountDeducted { get; set; }
}
