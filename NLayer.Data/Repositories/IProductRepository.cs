using NLayer.Core.DTOs;
using NLayer.Data.Models;

namespace NLayer.Core.Repositories
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        Task<List<Product>> GetProductWithCategoryAsync();
        Task<List<Product>> GetProductWithSP();
        Task<List<ProductFull>> GetProductWithFunc();
        Task<List<ProductFull>> GetProductWithView();

    }
}
