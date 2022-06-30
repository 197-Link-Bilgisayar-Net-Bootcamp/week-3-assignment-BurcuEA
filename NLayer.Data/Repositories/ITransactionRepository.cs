using NLayer.Core.Models.TransactionModels;
using NLayer.Data.Models;

namespace NLayer.Core.Repositories
{
    public interface ITransactionRepository :IGenericRepository<Category>
    {
        Task<Category> AddUpdateTransactionAsync(Category category);
       // Task AddProductTransactionAsync(Product product);

        //Task AddAsync(T entity);


    }
}
