using Pennywise.API.Interfaces.Entities;
using Pennywise.API.Interfaces.ViewModels;

namespace Pennywise.API.Interfaces.Services
{

    public interface ITokenService
    {
        public Task<string> CreateLinkToken();
        public Task<IList<IAccountsViewModel>?> ExchangePublicToken(IPublicTokenMetadata metadata);
    }
}