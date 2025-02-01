using Pennywise.API.Interfaces.DTOs;
using Pennywise.API.Interfaces.Entities;
using Pennywise.API.Interfaces.Responses;
using Pennywise.API.Interfaces.ViewModels;

namespace Pennywise.API.Interfaces.Repositories
{

    public interface IPennywiseRepository
    {
        public Task<bool> UpdateTokenAndSyncEntities(IUpdateTokenAndSyncEntities dto);

        public Task<IList<IAccountsViewModel>?> GetAccountsViewModel(int userId);
        public Task<IList<IAvgMonthlySpendingViewModel>> GetAvgMonthlySpendingByUserIdAsync(int userId);
        public Task<IGetAccessTokenAndLatestCursorResponse?> GetAccessTokenAndLatestCursor(int itemId);
        public Task<bool> SyncTransactionsForItem(ITransactionsDTO dto);
    }
}