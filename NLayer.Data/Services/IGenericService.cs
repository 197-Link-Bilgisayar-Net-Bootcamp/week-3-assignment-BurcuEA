using System.Linq.Expressions;

namespace NLayer.Core.Services
{
    public interface IGenericService<T> where T :class // IGenericRepository -- dönüş tipleri farklı
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task<T> AddAsync(T entity);
        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
        Task RemoveRangeAsync(IEnumerable<T> entities);



        //Task<bool> AddUpdateTransactionAsync(T entity);


    }
}
