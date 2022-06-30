using System.Linq.Expressions;

namespace NLayer.Core.Repositories
{
    public interface IGenericRepository<T> where T :class
    {
        Task<T> GetByIdAsync(int id);

        //productRepository.GetAll(x=>x.Id>5).OrderBy().Tolist();
        IQueryable<T> GetAll();

        //productRepository.Where(x=>x.Id>5).OrderBy().TolistAsync();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);

        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

       
    }
}
