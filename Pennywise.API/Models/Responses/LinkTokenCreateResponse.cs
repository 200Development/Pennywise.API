using System.Text.Json.Serialization;
using Pennywise.API.Interfaces.Responses;

namespace Pennywise.API.Models.Responses
{

    /// <summary>
    /// Model returned in response from a successful call to Plaid endpoint /item/public_token/exchange.
    /// </summary>
    /// <remarks>
    /// See <see href="https://plaid.com/docs/api/tokens/#linktokencreate">for more information</see>
    /// </remarks>
    public class LinkTokenCreateResponse : ILinkTokenCreateResponse
    {
        [JsonPropertyName("link_token")] public string? LinkToken { get; set; }

        [JsonPropertyName("expiration")] public DateTime Expiration { get; set; }

        [JsonPropertyName("request_id")] public string? RequestId { get; set; }
    }
}