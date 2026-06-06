using MagicOnion;

namespace Meeko.Contracts.Billing;

/// <summary>Bff → Billing：计费产品注册表管理。</summary>
public interface IBillingProductService : IService<IBillingProductService>
{
    UnaryResult<ProductListResult> ListProductsAsync(bool includeInactive = false);

    UnaryResult<ProductDto?> GetProductAsync(string code);

    UnaryResult<ProductDto> RegisterProductAsync(RegisterProductCommand cmd);

    UnaryResult<ProductDto> UpdateProductAsync(UpdateProductCommand cmd);

    UnaryResult<ProductDto> SetActiveAsync(SetProductActiveCommand cmd);
}
