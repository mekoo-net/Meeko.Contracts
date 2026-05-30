using MagicOnion;

namespace Meeko.Contracts.Billing;

/// <summary>BFF → Billing：订单（OneShot / Subscription / PaygHour / PaygCall）。</summary>
public interface IBillingOrderService : IService<IBillingOrderService>
{
    UnaryResult<PlaceOrderResult> PlaceOrderAsync(PlaceOrderCommand cmd);

    UnaryResult<bool> CancelOrderAsync(long orderUid, string reason);

    UnaryResult<OrderDto?> GetOrderAsync(long orderUid);

    UnaryResult<OrderDto[]> ListOrdersAsync(long accountUid, OrderStatus? status, int take);
}
