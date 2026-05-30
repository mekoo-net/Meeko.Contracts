using MagicOnion;

namespace Meeko.Contracts.Billing;

/// <summary>BFF → Billing：账单与用量查询。</summary>
public interface IBillingInvoiceService : IService<IBillingInvoiceService>
{
    UnaryResult<InvoiceDto?> GetInvoiceAsync(long invoiceUid);

    UnaryResult<InvoiceLineDto[]> GetInvoiceLinesAsync(long invoiceUid);

    UnaryResult<InvoiceDto[]> ListInvoicesAsync(ListInvoicesQuery query);

    UnaryResult<UsageRecordDto[]> ListUsageAsync(ListUsageQuery query);
}
