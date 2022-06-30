using NLayer.Core.Models.TransactionModels;
using NLayer.Core.Repositories;
using NLayer.Core.UnitOfWorks;
using NLayer.Data.Models;

namespace NLayer.Repository.Repositories
{
    public class TransactionRepository : GenericRepository<Category>, ITransactionRepository
    {
        protected readonly AppDbContext _transactionContext;
        private readonly IUnitOfWork _unitOfWork;

        public TransactionRepository(AppDbContext context) : base(context)
        {
            _transactionContext = context;
        }

        public async Task<Category> AddUpdateTransactionAsync(Category category)
        {
            await AddAsync(category);
            //Where(c => c.Id == 2).FirstOrDefault();
            //Update(category);

            return category;

        }

        public void Update(Category category)
        {
            category.Name = "Category 2";
            _context.Categories.Update(category);
        }

    }
}
