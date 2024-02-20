using System.Text.Json.Serialization;
using Pennywise.API.Interfaces.Entities;

namespace Pennywise.API.Models.Entities
{

    public class Modified : IModified
    {
        [JsonPropertyName("account_id")] public string Id { get; set; } = Guid.NewGuid().ToString();

        [JsonPropertyName("amount")] public double Amount { get; set; }

        [JsonPropertyName("iso_currency_code")]
        public string? IsoCurrencyCode { get; set; }

        [JsonPropertyName("unofficial_currency_code")]
        public string? UnofficialCurrencyCode { get; set; }

        [JsonIgnore]
        [JsonPropertyName("category")]
        public string? Category { get; set; }

        [JsonIgnore]
        [JsonPropertyName("category_id")]
        public string? CategoryId { get; set; }

        [JsonPropertyName("check_number")] public string? CheckNumber { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; } = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month,
                System.DateTime.Now.Day, System.DateTime.Now.Hour, System.DateTime.Now.Minute,
                System.DateTime.Now.Second)
            .ToString("u");

        [JsonPropertyName("location")] public Location Location { get; set; } = new();

        [JsonPropertyName("merchant_name")] public string? MerchantName { get; set; }

        [JsonPropertyName("original_description")]
        public string? OriginalDescription { get; set; }

        [JsonPropertyName("payment_meta")] public PaymentMeta PaymentMeta { get; set; } = new();

        [JsonPropertyName("pending")] public bool Pending { get; set; }

        [JsonPropertyName("pending_transaction_id")]
        public string? PendingTransactionId { get; set; }

        [JsonPropertyName("account_owner")] public string? AccountOwner { get; set; }

        [JsonPropertyName("transaction_id")] public string TransactionId { get; set; } = Guid.NewGuid().ToString();

        [JsonIgnore]
        [JsonPropertyName("transaction_type")]
        public string? TransactionType { get; set; }

        [JsonPropertyName("logo_url")] public string? LogoUrl { get; set; }

        [JsonPropertyName("website")] public string? Website { get; set; }

        [JsonPropertyName("authorized_date")] public string? AuthorizedDate { get; set; }

        [JsonPropertyName("authorized_datetime")]
        public string? AuthorizedDateTime { get; set; }

        [JsonPropertyName("datetime")] public string? DateTime { get; set; }

        [JsonPropertyName("payment_channel")] public string PaymentChannel { get; set; } = string.Empty;

        [JsonPropertyName("personal_finance_category")]
        public PersonalFinanceCategory PersonalFinanceCategory { get; set; } = new();
    }
}