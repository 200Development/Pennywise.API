using Pennywise.API.Interfaces.DTOs;

namespace Pennywise.API.Interfaces.Services
{

    public interface ITransactionService
    {
        Task<ITransactionsDTO?> GetTransactionsByItemIdAsync(int itemId);
    }
}