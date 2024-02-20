using System.Text.Json.Serialization;
using Pennywise.API.Interfaces.Responses;

/*******************************************************************

 Link to Plaid documentation explaining the structure of this model:
 https://plaid.com/docs/api/tokens/#itempublic_tokenexchange
 returned in response from a successful call to Plaid endpoint /item/public_token/exchange.

*******************************************************************/

namespace Pennywise.API.Models.Responses
{

    public class PublicTokenExchangeResponse : IPublicTokenExchangeResponse
    {
        [JsonPropertyName("access_token")] public string AccessToken { get; set; } = string.Empty;

        [JsonPropertyName("item_id")] public string ItemId { get; set; } = string.Empty;

        [JsonPropertyName("request_id")] public string RequestId { get; set; } = string.Empty;
    }
}