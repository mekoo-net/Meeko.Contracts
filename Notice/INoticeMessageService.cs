using MagicOnion;

namespace Meeko.Contracts.Notice;

/// <summary>业务通知（活动 / 工单 / 通用）：单条发送。MVP 由调用方提供 Subject/Body，模板渲染后续接入。</summary>
public interface INoticeMessageService : IService<INoticeMessageService>
{
    UnaryResult<SendNoticeResult> SendAsync(SendNoticeCommand cmd);
}
