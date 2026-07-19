using MagicOnion;
using Meeko.Contracts.Notice.Channels;

namespace Meeko.Contracts.Notice.Templates;

/// <summary>
/// 模板管理 RPC（按渠道分）：当前实现 Email；SMS / WeChat 后续接入。<br/>
/// 调用方需具备 Admin 角色。修改 / 创建均会写入 <c>email_template_revisions</c> 历史快照。
/// </summary>
public interface ITemplateAdminService : IService<ITemplateAdminService>
{
    UnaryResult<EmailTemplateDto[]> ListEmailAsync();
    UnaryResult<EmailTemplateDto?> GetEmailAsync(string code, string locale);
    UnaryResult<EmailTemplateRevisionDto[]> GetEmailRevisionsAsync(long templateId);
    UnaryResult<AdminCommandResult> CreateEmailAsync(CreateEmailTemplateCommand cmd);
    UnaryResult<AdminCommandResult> UpdateEmailAsync(UpdateEmailTemplateCommand cmd);
}
