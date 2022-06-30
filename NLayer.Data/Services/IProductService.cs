using NLayer.Core.DTOs;
using NLayer.Data.Models;

namespace NLayer.Core.Services
{
    public interface IProductService :IGenericService<Product>
    {
        Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductWithCategoryAsync();
        Task<List<Product>> GetProductWithSP();
        Task<List<ProductFull>> GetProductWithFunc();
        Task<List<ProductFull>> GetProductWithView();
        
    }
}
