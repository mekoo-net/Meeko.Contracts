using MagicOnion;

namespace Meeko.Contracts.Billing;

/// <summary>
/// 自动发券规则后台管理（Bff）。业务触发事件（注册 / 充值成功）已改由 MassTransit + RabbitMQ 投递，
/// 不再经此 gRPC 接口投递。
/// </summary>
public interface IBillingVoucherGrantService : IService<IBillingVoucherGrantService>
{
    UnaryResult<VoucherGrantRuleListResult> ListGrantRulesAsync(ListVoucherGrantRulesQuery query);

    UnaryResult<VoucherGrantRuleDto?> GetGrantRuleAsync(long ruleId);

    UnaryResult<VoucherGrantRuleDto> CreateGrantRuleAsync(CreateVoucherGrantRuleCommand cmd);

    UnaryResult<VoucherGrantRuleDto> UpdateGrantRuleAsync(UpdateVoucherGrantRuleCommand cmd);

    UnaryResult<VoucherGrantRuleDto> SetGrantRuleStatusAsync(SetVoucherGrantRuleStatusCommand cmd);
}
