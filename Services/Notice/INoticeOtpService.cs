using MagicOnion;

namespace Meeko.Contracts.Notice;

/// <summary>
/// 验证码 RPC：发送 + 校验。<br/>
/// 调用方需传入 <c>IpAddress</c>（由 Gateway/BFF 透传）以参与限流，
/// 命中限流返回 <c>Success=false</c> 并附带 <c>RetryAfterSeconds</c>。
/// </summary>
public interface INoticeOtpService : IService<INoticeOtpService>
{
    UnaryResult<SendOtpResult> SendAsync(SendOtpCommand cmd);
    UnaryResult<VerifyOtpResult> VerifyAsync(VerifyOtpCommand cmd);
}
