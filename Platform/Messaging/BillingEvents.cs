namespace Meeko.Contracts.Messaging;

/// <summary>
/// 充值成功集成事件。仅由真正的充值发布（手工充值 / 三方支付），由 Billing 内部消费者（推荐返利、自动发券）订阅。
/// 经 MassTransit + RabbitMQ 投递，发布方使用 EF 事务型 outbox 保证与入账同事务。
/// </summary>
public sealed record RechargeSucceeded
{
    public required long AccountUid { get; init; }
    public required long RechargeId { get; init; }
    public required decimal Amount { get; init; }
    public string? Provider { get; init; }
    public string? ProductCode { get; init; }
    public long? OperatorUid { get; init; }
    public DateTime OccurredAtUtc { get; init; }
}

/// <summary>
/// 账户注册成功集成事件。由 Keystone 注册流程发布，Billing 自动发券引擎订阅（如「注册送券」）。
/// </summary>
public sealed record AccountRegistered
{
    public required long AccountUid { get; init; }
    public DateTime OccurredAtUtc { get; init; }
}
