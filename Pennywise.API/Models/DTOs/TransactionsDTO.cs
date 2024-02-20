using Pennywise.API.Interfaces.DTOs;

namespace Pennywise.API.Models.DTOs
{

    public class TransactionsDTO : ITransactionsDTO
    {
        public List<TransactionDTO> AddedTransactions { get; set; } = new();
        public List<TransactionDTO> ModifiedTransactions { get; set; } = new();
        public List<TransactionDTO> RemovedTransactions { get; set; } = new();
        public string? NextCursor { get; set; }

    }
}