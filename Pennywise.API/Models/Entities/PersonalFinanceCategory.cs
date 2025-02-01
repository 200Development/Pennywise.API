using System.Text.Json.Serialization;
using Pennywise.API.Interfaces.Entities;

namespace Pennywise.API.Models.Entities
{

    public class PersonalFinanceCategory : IPersonalFinanceCategory
    {
        [JsonPropertyName("primary")] public string Primary { get; set; } = string.Empty;

        [JsonPropertyName("detailed")] public string Detailed { get; set; } = string.Empty;

        [JsonPropertyName("confidence_level")] public string? ConfidenceLevel { get; set; }
    }
}