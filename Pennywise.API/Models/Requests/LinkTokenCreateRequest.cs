using System.Text.Json.Serialization;
using Pennywise.API.Interfaces.Requests;
using Pennywise.API.Models.Entities;

namespace Pennywise.API.Models.Requests
{

    /// <summary>
    /// Request for call to Plaid endpoint /link/token/create.
    /// </summary>
    /// <remarks>
    /// See <see href="https://plaid.com/docs/api/tokens/#linktokencreate">for more information</see>
    /// </remarks>
    public class LinkTokenCreateRequest : ILinkTokenCreateRequest
    {
        [JsonPropertyName("client_id")] public string? ClientId { get; set; }

        [JsonPropertyName("secret")] public string? Secret { get; set; }

        [JsonPropertyName("user")] public required User User { get; set; }

        [JsonPropertyName("client_name")] public required string ClientName { get; set; }

        [JsonPropertyName("products")] public IList<string>? Products { get; set; }

        [JsonPropertyName("country_codes")] public required IList<string> CountryCodes { get; set; }

        [JsonPropertyName("language")] public required string Language { get; set; }

        [JsonPropertyName("required_if_supported_products")] public IList<string>? RequiredIfSupportedProducts { get; set; }

        [JsonPropertyName("optional_products")] public IList<string>? OptionalProducts { get; set; }

        [JsonPropertyName("additional_consented_products")] public IList<string>? AdditionalConsentedProducts { get; set; }

        [JsonPropertyName("webhook")] public string? Webhook { get; set; }

        [JsonPropertyName("redirect_uri")] public string? RedirectUri { get; set; }

        [JsonPropertyName("access_token")] public string? AccessToken { get; set; }

        [JsonPropertyName("link_customization_name")] public string? LinkCustomizationName { get; set; }

    }
}