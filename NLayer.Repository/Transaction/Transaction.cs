using NLayer.Core.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Transaction
{
    public class Transaction : ITransaction
    {
        private readonly AppDbContext _context;
        public Transaction(AppDbContext context)
        {
            _context = context;
        }

        public async Task BegTransactionAsync()
        {
             await _context.Database.BeginTransactionAsync();
        }
        public async Task ComTransactionAsync()
        {
            await _context.Database.CommitTransactionAsync(); 
        }
    }
}
