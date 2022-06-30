using AutoMapper;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.Transactions;
using NLayer.Core.UnitOfWorks;
using NLayer.Data.Models;

namespace NLayer.Service.Services
{
    public class TransactionService : GenericService<Category>, ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITransaction _transaction;
        private readonly IMapper _mapper;

        public TransactionService(IGenericRepository<Category> repository, IUnitOfWork unitOfWork, ITransactionRepository transactionRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _transactionRepository = transactionRepository;
            _mapper = mapper;
        }

        public async Task<Category> AddUpdateTransactionAsync(Category category)
        {
            using (var transaction = _transaction.BegTransactionAsync())
            {
                await _transactionRepository.AddUpdateTransactionAsync(category);
                await _unitOfWork.CommitAsync();

                _transactionRepository.Update(category);
                await _unitOfWork.CommitAsync();

                await _transaction.ComTransactionAsync();
            }
            return category;
        }

    }
}
