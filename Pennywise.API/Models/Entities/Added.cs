using System.Text.Json.Serialization;
using Pennywise.API.Interfaces.Entities;

namespace Pennywise.API.Models.Entities
{

    public class Added : IAdded
    {
        [JsonPropertyName("transaction_id")] public string TransactionId { get; set; } = string.Empty;

        [JsonPropertyName("account_id")] public string AccountId { get; set; } = string.Empty;

        [JsonPropertyName("name")] public string Name { get; set; } = string.Empty;

        [JsonPropertyName("amount")] public double Amount { get; set; }

        [JsonPropertyName("iso_currency_code")]
        public string? IsoCurrencyCode { get; set; }

        [JsonPropertyName("merchant_entity_id")]
        public string? MerchantEntityId { get; set; }

        [JsonPropertyName("merchant_name")] public string? MerchantName { get; set; }

        [JsonPropertyName("logo_url")] public string? LogoUrl { get; set; }

        [JsonPropertyName("website")] public string? Website { get; set; }

        [JsonPropertyName("date")] public string Date { get; set; } = string.Empty;

        [JsonPropertyName("personal_finance_category")]
        public PersonalFinanceCategory PersonalFinanceCategory { get; set; } = new();

        [JsonPropertyName("payment_channel")] public string PaymentChannel { get; set; } = string.Empty;

        [JsonIgnore]
        [JsonPropertyName("unofficial_currency_code")]
        public string? UnofficialCurrencyCode { get; set; }

        [Obsolete("deprecated")]
        [JsonIgnore]
        [JsonPropertyName("category")]
        public string? Category { get; set; }

        [Obsolete("deprecated")]
        [JsonIgnore]
        [JsonPropertyName("category_id")]
        public string? CategoryId { get; set; }

        [JsonIgnore]
        [JsonPropertyName("check_number")]
        public string? CheckNumber { get; set; }

        [JsonIgnore]
        [JsonPropertyName("location")]
        public Location Location { get; set; } = new();

        [JsonIgnore]
        [JsonPropertyName("original_description")]
        public string? OriginalDescription { get; set; }

        [JsonIgnore]
        [JsonPropertyName("payment_meta")]
        public PaymentMeta PaymentMeta { get; set; } = new();

        [JsonIgnore]
        [JsonPropertyName("pending")]
        public bool Pending { get; set; }

        [JsonIgnore]
        [JsonPropertyName("pending_transaction_id")]
        public string? PendingTransactionId { get; set; }

        [JsonIgnore]
        [JsonPropertyName("account_owner")]
        public string? AccountOwner { get; set; }

        [Obsolete("deprecated")]
        [JsonIgnore]
        [JsonPropertyName("transaction_type")]
        public string? TransactionType { get; set; }

        [JsonIgnore]
        [JsonPropertyName("authorized_date")]
        public string? AuthorizedDate { get; set; }

        [JsonIgnore]
        [JsonPropertyName("authorized_datetime")]
        public string? AuthorizedDateTime { get; set; }

        [JsonIgnore]
        [JsonPropertyName("datetime")]
        public string? DateTime { get; set; }

        [JsonIgnore]
        [JsonPropertyName("transaction_code")]
        public string? TransactionCode { get; set; }

        [JsonIgnore]
        [JsonPropertyName("personal_finance_category_icon_url")]
        public string PersonalFinanceCategoryIconUrl { get; set; } = string.Empty;

        [JsonIgnore]
        [JsonPropertyName("counterparties")]
        public List<CounterParties> CounterParties { get; set; } = new();
    }
}