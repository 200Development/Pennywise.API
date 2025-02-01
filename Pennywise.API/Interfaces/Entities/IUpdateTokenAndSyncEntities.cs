using Pennywise.API.Models.DTOs;
using Pennywise.API.Models.Entities;

namespace Pennywise.API.Interfaces.Entities
{

    public interface IUpdateTokenAndSyncEntities
    {
        int UserId { get; set; }
        string AccessToken { get; set; }
        Institution Institution { get; set; }
        List<AccountDto> Accounts { get; set; }
    }
}