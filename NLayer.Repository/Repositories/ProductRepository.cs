using Microsoft.EntityFrameworkCore;
using NLayer.Core.DTOs;
using NLayer.Core.Repositories;
using NLayer.Data.Models;

namespace NLayer.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetProductWithCategoryAsync()
        {
            //Eager Loading
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }

        public async Task<List<Product>> GetProductWithSP()
        {
            return await _context.Products.FromSqlRaw("exec sp_get_products").ToListAsync();
        }

        public async Task<List<ProductFull>> GetProductWithFunc()
        {
            return await _context.ProductFulls.ToListAsync();
        }

        public async Task<List<ProductFull>> GetProductWithView()
        {
            return await _context.ProductFulls.ToListAsync();
        }

    }
}
