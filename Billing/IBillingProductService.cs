using MagicOnion;

namespace Meeko.Contracts.Billing;

/// <summary>Bff → Billing：计费产品注册表管理。</summary>
public interface IBillingProductService : IService<IBillingProductService>
{
    UnaryResult<ProductListResult> ListProductsAsync(bool includeInactive = false);

    UnaryResult<ProductDto?> GetProductAsync(string code);

    UnaryResult<DiscoveredProductListResult> DiscoverProductsAsync();

    UnaryResult<ProductDto> RegisterDiscoveredProductAsync(RegisterDiscoveredProductCommand cmd);

    UnaryResult<bool> UnregisterProductAsync(string code);

    UnaryResult<ProductDto> UpdateProductAsync(UpdateProductCommand cmd);
}
