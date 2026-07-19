using MagicOnion;

namespace Meeko.Contracts.Notice.Channels;

/// <summary>
/// 渠道管理 RPC：SMTP 渠道 CRUD + 连通性测试。<br/>
/// 调用方需具备平台管理员角色（SuperAdmin 或 Admin；由 Bff 与 Notice 服务侧校验）。
/// </summary>
public interface IChannelAdminService : IService<IChannelAdminService>
{
    UnaryResult<SmtpProviderDto[]> ListSmtpAsync();
    UnaryResult<SmtpProviderDto?> GetSmtpAsync(long id);
    UnaryResult<AdminCommandResult> CreateSmtpAsync(CreateSmtpProviderCommand cmd);
    UnaryResult<AdminCommandResult> UpdateSmtpAsync(UpdateSmtpProviderCommand cmd);
    UnaryResult<AdminCommandResult> DeleteSmtpAsync(long id);
    UnaryResult<TestSmtpProviderResult> TestSmtpAsync(TestSmtpProviderCommand cmd);
}
