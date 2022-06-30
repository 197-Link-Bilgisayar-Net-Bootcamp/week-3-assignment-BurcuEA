using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.Models.TransactionModels;
using NLayer.Core.Services;
using NLayer.Data.Models;

namespace NLayer.API.Controllers
{
    public class TransactionsController : CustomBaseController
    {
        private readonly ITransactionService _transactionService;

        public TransactionsController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddUpdateTransactionAsync(Category category)
        {
            var cat = await _transactionService.AddUpdateTransactionAsync(category);
            return Ok(cat);
        }
    }
}



