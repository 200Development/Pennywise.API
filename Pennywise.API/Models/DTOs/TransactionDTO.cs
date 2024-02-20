using Pennywise.API.Interfaces.DTOs;

namespace Pennywise.API.Models.DTOs
{

    public class TransactionDTO : ITransactionDTO
    {
        public string TransactionId { get; set; } = string.Empty;

        public string AccountId { get; set; } = string.Empty;

        public double Amount { get; set; }

        public string? IsoCurrencyCode { get; set; }

        public string Name { get; set; } = string.Empty;

        public string MerchantEntityId { get; set; } = string.Empty;

        public string? MerchantName { get; set; }

        public string? LogoUrl { get; set; }

        public string? Website { get; set; }

        public string Date { get; set; } = string.Empty;

        public string? PrimaryCategory { get; set; } = string.Empty;

        public string? DetailedCategory { get; set; } = string.Empty;

        public string? CategoryConfidenceLevel { get; set; } = string.Empty;

        public string PaymentChannel { get; set; } = string.Empty;
    }
}