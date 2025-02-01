using Pennywise.API.Models.DTOs;

namespace Pennywise.API.Interfaces.DTOs
{

    public interface ITransactionsDTO
    {
        public List<TransactionDTO> AddedTransactions { get; set; }
        public List<TransactionDTO> ModifiedTransactions { get; set; }
        public List<TransactionDTO> RemovedTransactions { get; set; }
        public string? NextCursor { get; set; }
    }
}