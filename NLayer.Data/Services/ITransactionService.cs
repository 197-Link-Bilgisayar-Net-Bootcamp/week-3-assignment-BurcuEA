using NLayer.Core.DTOs;
using NLayer.Core.Models.TransactionModels;
using NLayer.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Services
{
    public interface ITransactionService :IGenericService<Category>
    {
        public Task<Category> AddUpdateTransactionAsync(Category category);
        
        //Task<T> AddAsync(T entity);
    }
}
