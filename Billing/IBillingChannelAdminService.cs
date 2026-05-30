using MagicOnion;

namespace Meeko.Contracts.Billing;

/// <summary>
/// Bff → Billing：支付渠道管理面（list / active / alipay-config / wechat-config）。
/// 配置 GET 返回的敏感字段会被服务侧脱敏（仅显示"已配置"标记 / 后 4 位）；PUT 接收明文，服务侧入库时编码 / 加密。
/// </summary>
public interface IBillingChannelAdminService : IService<IBillingChannelAdminService>
{
    UnaryResult<PaymentChannelDto[]> ListChannelsAsync();

    UnaryResult<ChannelAdminCommandResult> SetActiveAsync(SetChannelActiveCommand cmd);

    UnaryResult<AlipayConfig?> GetAlipayConfigAsync();

    UnaryResult<ChannelAdminCommandResult> PutAlipayConfigAsync(AlipayConfig config);

    UnaryResult<WechatPayConfig?> GetWechatPayConfigAsync();

    UnaryResult<ChannelAdminCommandResult> PutWechatPayConfigAsync(WechatPayConfig config);
}
