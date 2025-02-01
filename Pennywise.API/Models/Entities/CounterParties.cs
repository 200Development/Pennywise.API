using System.Text.Json.Serialization;
using Pennywise.API.Interfaces.Entities;

namespace Pennywise.API.Models.Entities
{

    public class CounterParties : ICounterParties
    {
        [JsonPropertyName("name")] public string Name { get; set; } = string.Empty;

        [JsonPropertyName("entity_id")] public string? EntityId { get; set; }

        [JsonPropertyName("type")] public string Type { get; set; } = string.Empty;

        [JsonPropertyName("website")] public string? Website { get; set; }

        [JsonPropertyName("logo_url")] public string? LogoUrl { get; set; }

        [JsonPropertyName("confidence_level")] public string? ConfidenceLevel { get; set; }
    }
}