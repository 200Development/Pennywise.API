using Pennywise.API.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Pennywise.API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TransactionController : Controller
    {
        private readonly ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpPost("sync")]
        public async Task<IActionResult> TransactionsSync([FromBody] string itemId)
        {
            int.TryParse(itemId, out int intItemId);

            var transactions = await _transactionService.GetTransactionsByItemIdAsync(intItemId);



            if (transactions == null)
                return Problem("There was an error getting transactions from Plaid API", null, 500);
            if (!transactions.AddedTransactions.Any() && !transactions.ModifiedTransactions.Any())
                return NoContent();
            return Ok(transactions);
        }
    }
}