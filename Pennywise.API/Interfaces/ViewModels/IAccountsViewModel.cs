namespace Pennywise.API.Interfaces.ViewModels{

    public interface IAccountsViewModel
    {
        string AccountId { get; set; }
        string Name { get; set; }
        string Type { get; set; }
        string Subtype { get; set; }
        decimal CurrentBalance { get; set; }
        decimal AvailableBalance { get; set; }
        decimal Limit { get; set; }
        string IsoCurrencyCode { get; set; }
    }
}