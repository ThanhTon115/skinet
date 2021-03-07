using System.Collections.Generic;
using System.Threading.Tasks;
using core.Entities;

namespace core.Interfaces
{
    public interface IProductResponsitory
    {
        Task<Product> GetProductByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetProductAsync();
        Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();
        Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
    }
}