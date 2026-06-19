using MagicOnion;

namespace Meeko.Contracts.Billing;

/// <summary>
/// Bff → Billing：支付渠道管理面（实例 list / create / delete / active / schema-driven config）。
/// 一个支付类型(driver)可创建多个实例，实例以 Id 定位。
/// 配置 GET 返回的敏感字段会被服务侧脱敏；PUT 接收明文 key-value，服务侧入库。
/// </summary>
public interface IBillingChannelAdminService : IService<IBillingChannelAdminService>
{
    /// <summary>已创建的渠道实例列表。</summary>
    UnaryResult<PaymentChannelDto[]> ListChannelsAsync();

    /// <summary>可创建的支付类型（驱动）列表 + schema，供新建实例选择。</summary>
    UnaryResult<ChannelTypeDto[]> ListChannelTypesAsync();

    /// <summary>新建一个渠道实例（按 driver code）。</summary>
    UnaryResult<ChannelAdminCommandResult> CreateChannelAsync(CreateChannelCommand cmd);

    /// <summary>删除一个渠道实例（单例渠道如手工入账不可删除）。</summary>
    UnaryResult<ChannelAdminCommandResult> DeleteChannelAsync(long channelId);

    UnaryResult<ChannelAdminCommandResult> SetActiveAsync(SetChannelActiveCommand cmd);

    /// <summary>取某实例所属类型的配置 schema。</summary>
    UnaryResult<ChannelConfigSchemaDto?> GetChannelSchemaAsync(long channelId);

    UnaryResult<ChannelConfigValuesDto?> GetChannelConfigAsync(long channelId);

    UnaryResult<ChannelAdminCommandResult> PutChannelConfigAsync(PutChannelConfigCommand cmd);
}
