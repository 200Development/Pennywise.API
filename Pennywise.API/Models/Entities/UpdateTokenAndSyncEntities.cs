using Pennywise.API.Interfaces.DTOs;
using Pennywise.API.Interfaces.Entities;
using Pennywise.API.Models.DTOs;

namespace Pennywise.API.Models.Entities
{

    /// <summary>
    /// Model for SQL Stored Procedure Pennywise.dbo.usp_UpdateTokenAndSyncEntities
    /// </summary>
    public class UpdateTokenAndSyncEntities : IUpdateTokenAndSyncEntities
    {
        public int UserId { get; set; }

        public string AccessToken { get; set; } = string.Empty;

        public Institution Institution { get; set; } = new();

        public List<AccountDto> Accounts { get; set; } = new();
    }
}