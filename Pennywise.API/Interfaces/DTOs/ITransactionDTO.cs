namespace Pennywise.API.Interfaces.DTOs{

    public interface ITransactionDTO
    {
        string AccountId { get; set; }
        double Amount { get; set; }
        string? IsoCurrencyCode { get; set; }
        string Date { get; set; }
        string Name { get; set; }
        string MerchantEntityId { get; set; }
        string? MerchantName { get; set; }
        string? PrimaryCategory { get; set; }
        string? DetailedCategory { get; set; }
        string? CategoryConfidenceLevel { get; set; }
        string PaymentChannel { get; set; }
        string TransactionId { get; set; }
        string? LogoUrl { get; set; }
        string? Website { get; set; }
    }
}