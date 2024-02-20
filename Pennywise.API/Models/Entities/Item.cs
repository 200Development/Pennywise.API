using System.Text.Json.Serialization;
using Pennywise.API.Interfaces.Entities;

namespace Pennywise.API.Models.Entities
{

    public class Item : IItem
    {
        [JsonPropertyName("item_id")] public string Id { get; set; } = string.Empty;

        [JsonPropertyName("institution_id")] public string? InstitutionId { get; set; }

        [JsonPropertyName("webhook")] public string? Webhook { get; set; }

        [JsonPropertyName("error")] public PlaidError? Error { get; set; }

        [JsonPropertyName("available_products")]
        public List<string> AvailableProducts { get; set; } = new();

        [JsonPropertyName("billed_products")] public List<string> BilledProducts { get; set; } = new();

        [JsonPropertyName("products")] public List<string> Products { get; set; } = new();

        [JsonPropertyName("consented_products")]
        public string? ConsentedProducts { get; set; } = string.Empty;

        [JsonPropertyName("consent_expiration_time")]
        public string? ConsentExpirationTime { get; set; }

        [JsonPropertyName("update_type")] public string UpdateType { get; set; } = string.Empty;
    }
}