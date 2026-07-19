namespace Meeko.Contracts.Notice;

public enum NoticeChannel
{
    Email = 1,
    Sms   = 2,
}

public enum NoticePurpose
{
    Otp      = 1,
    Activity = 2,
    Ticket   = 3,
    Generic  = 99,
}

public enum NoticeStatus
{
    Queued    = 0,
    Sending   = 1,
    Sent      = 2,
    Failed    = 3,
    Throttled = 4,
}

public enum OtpPurpose
{
    Login          = 1,
    Register       = 2,
    ResetPassword  = 3,
    ChangeEmail    = 4,
    RiskVerify     = 5,
    BindMfa        = 6,
}

public enum OtpVerifyResult
{
    Ok          = 0,
    NotFound    = 1,
    Expired     = 2,
    Mismatch    = 3,
    Locked      = 4,
    AlreadyUsed = 5,
}
