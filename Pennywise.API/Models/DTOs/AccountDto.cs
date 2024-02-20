using System.Text.Json.Serialization;
using Pennywise.API.Interfaces.DTOs;

namespace Pennywise.API.Models.DTOs
{

    public class AccountDto : IAccountDto
    {
        [JsonPropertyName("id")] public string AccountId { get; set; } = string.Empty;

        [JsonPropertyName("available_balance")]
        public decimal? AvailableBalance { get; set; }

        [JsonPropertyName("current_balance")] public decimal? CurrentBalance { get; set; }

        [JsonPropertyName("limit")] public decimal? Limit { get; set; }

        [JsonPropertyName("iso_currency_code")]
        public string? IsoCurrencyCode { get; set; }

        [JsonPropertyName("name")] public string Name { get; set; } = string.Empty;

        [JsonPropertyName("type")] public string Type { get; set; } = string.Empty;

        [JsonPropertyName("subtype")] public string? Subtype { get; set; } = string.Empty;
    }
}