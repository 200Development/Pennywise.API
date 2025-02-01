using Pennywise.API.Models.Entities;

namespace Pennywise.API.Interfaces.Responses
{

    public interface IGetAccountsResponse
    {
        List<Account> Accounts { get; set; }
        Item Item { get; set; }
        string RequestId { get; set; }
    }
}