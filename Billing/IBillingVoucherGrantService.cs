using MagicOnion;

namespace Meeko.Contracts.Billing;

/// <summary>
/// 自动发券：业务方投递触发事件驱动发券引擎；后台管理发券规则。
/// <list type="bullet">
/// <item><see cref="DispatchGrantEventAsync"/>：Keystone 等业务方在业务动作完成后调用，喂入触发事件（幂等、容错）。</item>
/// <item>规则 CRUD：Bff 后台管理「注册送 / 充值满 X 送」等自动发券规则。</item>
/// </list>
/// </summary>
public interface IBillingVoucherGrantService : IService<IBillingVoucherGrantService>
{
    /// <summary>投递一个业务触发事件，返回本次实际发出的券张数（跨命中规则汇总）。</summary>
    UnaryResult<int> DispatchGrantEventAsync(GrantEventCommand cmd);

    UnaryResult<VoucherGrantRuleListResult> ListGrantRulesAsync(ListVoucherGrantRulesQuery query);

    UnaryResult<VoucherGrantRuleDto?> GetGrantRuleAsync(long ruleId);

    UnaryResult<VoucherGrantRuleDto> CreateGrantRuleAsync(CreateVoucherGrantRuleCommand cmd);

    UnaryResult<VoucherGrantRuleDto> UpdateGrantRuleAsync(UpdateVoucherGrantRuleCommand cmd);

    UnaryResult<VoucherGrantRuleDto> SetGrantRuleStatusAsync(SetVoucherGrantRuleStatusCommand cmd);
}
