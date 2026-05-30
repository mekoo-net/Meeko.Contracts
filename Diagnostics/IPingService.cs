using MagicOnion;

namespace Meeko.Contracts.Diagnostics;

/// <summary>
/// 端到端连通性探测：Bff/Jobs → MagicOnion 服务。
/// 不属于任何业务域，平台所有 MagicOnion 服务（Billing/Notice）都实现这个接口。
/// </summary>
public interface IPingService : IService<IPingService>
{
    UnaryResult<PingResponse> PingAsync(PingRequest request);
}
