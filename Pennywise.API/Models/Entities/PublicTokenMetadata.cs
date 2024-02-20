using System.Text.Json.Serialization;
using Pennywise.API.Interfaces.Entities;

namespace Pennywise.API.Models.Entities
{

    /// <summary>
    /// Model of Plaid PublicTokenMetadata
    /// </summary>
    /// <remarks>
    /// See <see href="https://plaid.com/docs/link/web/#onsuccess">for more information</see>
    /// </remarks>
    public class PublicTokenMetadata : IPublicTokenMetadata
    {
        [JsonPropertyName("public_token")] public string PublicToken { get; set; } = string.Empty;

        [JsonPropertyName("institution")] public Institution Institution { get; set; } = new();

        [JsonPropertyName("accounts")] public List<Account> Accounts { get; set; } = new();

        [Obsolete("Deprecated. Use accounts instead.  https://plaid.com/docs/link/web/#onsuccess")]
        [JsonIgnore]
        [JsonPropertyName("account")]
        public Account? Account { get; set; }

        [JsonPropertyName("link_session_id")] public string LinkSessionId { get; set; } = string.Empty;

        [JsonPropertyName("transfer_status")] public string? TransferStatus { get; set; }
    }
}