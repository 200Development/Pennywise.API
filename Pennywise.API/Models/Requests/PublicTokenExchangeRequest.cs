using System.Text.Json.Serialization;
using Pennywise.API.Interfaces.Requests;

namespace Pennywise.API.Models.Requests
{

    /// <summary>
    /// Request for call to Plaid endpoint /item/public_token/exchange
    /// </summary>
    /// <remarks>
    /// See <see href="https://plaid.com/docs/api/tokens/#itempublic_tokenexchange">for more information</see>
    /// </remarks>
    public class PublicTokenExchangeRequest : IPublicTokenExchangeRequest
    {
        [JsonPropertyName("public_token")] public string PublicToken { get; set; } = string.Empty;
    }
}