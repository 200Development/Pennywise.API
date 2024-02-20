using Pennywise.API.Interfaces.Clients;
using Pennywise.API.Interfaces.DTOs;
using Pennywise.API.Interfaces.Repositories;
using Pennywise.API.Interfaces.Responses;
using Pennywise.API.Interfaces.Services;
using Pennywise.API.Models.DTOs;
using Pennywise.API.Models.Requests;

namespace Pennywise.API.Services
{

    public class TransactionService : ITransactionService
    {
        private readonly IPlaidClient _plaidClient;
        private readonly IPennywiseRepository _pennywiseRepo;

        public TransactionService(IPlaidClient plaidClient, IPennywiseRepository pennywiseRepository)
        {
            _plaidClient = plaidClient;
            _pennywiseRepo = pennywiseRepository;
        }

        public async Task<ITransactionsDTO?> GetTransactionsByItemIdAsync(int itemId)
        {
            try
            {
                var dto = new TransactionsDTO();
                var hasMore = true;
                var cursorAndToken = await _pennywiseRepo.GetAccessTokenAndLatestCursor(itemId);

                if (cursorAndToken == null)
                {
                    return null;
                }

                var request = new TransactionsSyncRequest();
                request.AccessToken = cursorAndToken.AccessToken;
                request.Cursor = cursorAndToken.NextCursor ?? string.Empty;
                request.Count = 100;
                while (hasMore)
                {
                    ITransactionsSyncResponse? response = await _plaidClient.GetTransactionsAsync(request);

                    if (response == null)
                    {
                        return null;
                    }

                    if (!response.Added.Any() && !response.Modified.Any() && !response.Removed.Any())
                    {
                        return dto;
                    }

                    foreach (var addedTransaction in response.Added)
                    {
                        var added = new TransactionDTO();
                        added.AccountId = addedTransaction.AccountId;
                        added.TransactionId = addedTransaction.TransactionId;
                        added.Name = addedTransaction.Name;
                        added.Amount = addedTransaction.Amount;
                        added.IsoCurrencyCode = addedTransaction.IsoCurrencyCode;
                        added.Date = addedTransaction.Date;
                        added.MerchantEntityId = addedTransaction.MerchantEntityId!;
                        added.MerchantName = addedTransaction.MerchantName;
                        added.LogoUrl = addedTransaction.LogoUrl;
                        added.Website = addedTransaction.Website;
                        added.PrimaryCategory = addedTransaction.PersonalFinanceCategory.Primary;
                        added.DetailedCategory = addedTransaction.PersonalFinanceCategory.Detailed;
                        added.CategoryConfidenceLevel = addedTransaction.PersonalFinanceCategory.ConfidenceLevel;
                        added.PaymentChannel = added.PaymentChannel;
                        dto.AddedTransactions.Add(added);
                    }

                    foreach (var modifiedTransaction in response.Modified)
                    {
                        var modified = new TransactionDTO();
                        modified.AccountId = modifiedTransaction.Id;
                        modified.TransactionId = modifiedTransaction.TransactionId;
                        modified.Amount = modifiedTransaction.Amount;
                        modified.IsoCurrencyCode = modifiedTransaction.IsoCurrencyCode;
                        modified.Date = modifiedTransaction.Date;
                        modified.MerchantName = modifiedTransaction.MerchantName;
                        modified.LogoUrl = modifiedTransaction.LogoUrl;
                        modified.Website = modifiedTransaction.Website;
                        modified.PrimaryCategory = modifiedTransaction.PersonalFinanceCategory.Primary;
                        modified.DetailedCategory = modifiedTransaction.PersonalFinanceCategory.Detailed;
                        modified.CategoryConfidenceLevel = modifiedTransaction.PersonalFinanceCategory.ConfidenceLevel;
                        modified.PaymentChannel = modifiedTransaction.PaymentChannel;
                        dto.ModifiedTransactions.Add(modified);
                    }

                    foreach (var removedTransaction in response.Removed)
                    {
                        var removed = new TransactionDTO();
                        removed.TransactionId = removedTransaction.TransactionId;
                        dto.RemovedTransactions.Add(removed);
                    }

                    hasMore = response.HasMore;
                    request.Cursor = response.NextCursor;
                }

                dto.NextCursor = request.Cursor;

                await _pennywiseRepo.SyncTransactionsForItem(dto);

                return dto;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}