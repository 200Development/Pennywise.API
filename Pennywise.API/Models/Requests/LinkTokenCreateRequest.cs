using System.Text.Json.Serialization;
using Pennywise.API.Interfaces.Entities;
using Pennywise.API.Interfaces.Requests;

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
        [JsonPropertyName("user")] public IUser? User { get; set; }

        [JsonPropertyName("client_name")] public string? ClientName { get; set; }

        [JsonPropertyName("products")] public IList<string>? Products { get; set; }

        [JsonPropertyName("country_codes")] public IList<string>? CountryCodes { get; set; }

        [JsonPropertyName("language")] public string? Language { get; set; }

        [JsonPropertyName("required_if_supported_products")]
        public IList<string>? RequiredIfSupportedProducts { get; set; }

        [JsonPropertyName("webhook")] public string? Webhook { get; set; }

        [JsonPropertyName("redirect_uri")] public string? RedirectUri { get; set; }
    }
}