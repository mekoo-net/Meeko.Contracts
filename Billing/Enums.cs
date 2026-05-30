namespace Meeko.Contracts.Billing;

public enum BillingMode : short
{
    OneShot = 0,
    Subscription = 1,
    PaygHour = 2,
    PaygCall = 3,
}

public enum SubscriptionPeriod : short
{
    Monthly = 0,
    Yearly = 1,
}

public enum WalletTxnKind : short
{
    Recharge = 0,
    Hold = 1,
    Commit = 2,
    Release = 3,
    Refund = 4,
    Adjustment = 5,
}

public enum WalletTxnReferenceKind : short
{
    None = 0,
    Recharge = 1,
    Hold = 2,
    Order = 3,
    Subscription = 4,
    Invoice = 5,
    Manual = 6,
}

public enum RechargeStatus : short
{
    Pending = 0,
    Succeeded = 1,
    Failed = 2,
    Expired = 3,
    Refunded = 4,
}

public enum PaymentScene : short
{
    Native = 0,
    H5 = 1,
    JsApi = 2,
    App = 3,
    Pc = 4,
    Manual = 99,
}

public enum OrderStatus : short
{
    Created = 0,
    Provisioning = 1,
    Active = 2,
    Completed = 3,
    Cancelled = 4,
    Failed = 5,
    Suspended = 6,
}

public enum SubscriptionStatus : short
{
    Active = 0,
    PastDue = 1,
    Cancelling = 2,
    Cancelled = 3,
}

public enum HoldStatus : short
{
    Held = 0,
    Committed = 1,
    Released = 2,
    Expired = 3,
}

public enum UsageStatus : short
{
    Settled = 0,
    Adjusted = 1,
    Voided = 2,
}

public enum InvoiceKind : short
{
    Subscription = 0,
    PaygMonthly = 1,
    OneShot = 2,
}

public enum InvoiceStatus : short
{
    Draft = 0,
    Open = 1,
    Paid = 2,
    Void = 3,
}
