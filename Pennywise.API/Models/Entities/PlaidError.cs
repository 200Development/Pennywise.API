using System.Text.Json.Serialization;
using Pennywise.API.Interfaces.Entities;

namespace Pennywise.API.Models.Entities
{

    public class PlaidError : IPlaidError
    {
        [JsonPropertyName("error_type")] public string ErrorType { get; set; } = string.Empty;

        [JsonPropertyName("error_code")] public string ErrorCode { get; set; } = string.Empty;

        [JsonPropertyName("error_message")] public string ErrorMessage { get; set; } = string.Empty;

        [JsonPropertyName("display_message")] public string? DisplayMessage { get; set; } = string.Empty;

        [JsonPropertyName("request_id")] public string RequestId { get; set; } = string.Empty;

        [JsonPropertyName("causes")] public List<PlaidError> Causes { get; set; } = new();

        [JsonPropertyName("status")] public int? Status { get; set; }

        [JsonPropertyName("documentation_url")]
        public string DocumentationUrl { get; set; } = string.Empty;

        [JsonPropertyName("suggested_action")] public string? SuggestedAction { get; set; }
    }
}