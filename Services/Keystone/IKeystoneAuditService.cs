using MagicOnion;

namespace Meeko.Contracts.Keystone;

/// <summary>
/// 业务服务 → Keystone：写审计日志（KS-ADR-12）。
/// 业务服务不直接写 AuditLogs 表；调本接口让 Keystone 写。
/// IamUser 标识不出 Keystone 边界 —— 由 Keystone 通过当前 Session 反查记录。
/// </summary>
public interface IKeystoneAuditService : IService<IKeystoneAuditService>
{
    UnaryResult AppendAsync(AuditEntry entry);

    UnaryResult AppendStaffAuditAsync(StaffAuditEntry entry);
}
