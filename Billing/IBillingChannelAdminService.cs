using MagicOnion;

namespace Meeko.Contracts.Billing;

/// <summary>
/// Bff → Billing：支付渠道管理面（list / active / schema-driven config）。
/// 配置 GET 返回的敏感字段会被服务侧脱敏；PUT 接收明文 key-value，服务侧入库。
/// </summary>
public interface IBillingChannelAdminService : IService<IBillingChannelAdminService>
{
    UnaryResult<PaymentChannelDto[]> ListChannelsAsync();

    UnaryResult<ChannelAdminCommandResult> SetActiveAsync(SetChannelActiveCommand cmd);

    UnaryResult<ChannelConfigSchemaDto?> GetChannelSchemaAsync(string code);

    UnaryResult<ChannelConfigValuesDto?> GetChannelConfigAsync(string code);

    UnaryResult<ChannelAdminCommandResult> PutChannelConfigAsync(PutChannelConfigCommand cmd);
}
