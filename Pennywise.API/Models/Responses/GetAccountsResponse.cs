using System.Text.Json.Serialization;
using Pennywise.API.Interfaces.Responses;
using Pennywise.API.Models.Entities;

namespace Pennywise.API.Models.Responses
{

    public class GetAccountsResponse : IGetAccountsResponse
    {
        [JsonPropertyName("accounts")] public List<Account> Accounts { get; set; } = new();

        [JsonPropertyName("item")] public Item Item { get; set; } = new();

        [JsonPropertyName("request_id")] public string RequestId { get; set; } = string.Empty;
    }
}