namespace Pennywise.API.Interfaces.Entities
{

    public interface IAdded
    {
        string TransactionId { get; set; }
        string AccountId { get; set; }
        string Name { get; set; }
        double Amount { get; set; }
        string? IsoCurrencyCode { get; set; }
        string Date { get; set; }
    }
}