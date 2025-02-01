using Pennywise.API.Interfaces.ViewModels;

namespace Pennywise.API.Models.ViewModels
{

    public class AccountsViewModel : IAccountsViewModel
    {
        public string AccountId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Subtype { get; set; } = string.Empty;
        public decimal CurrentBalance { get; set; }
        public decimal AvailableBalance { get; set; }
        public decimal Limit { get; set; }
        public string IsoCurrencyCode { get; set; } = string.Empty;
    }
}