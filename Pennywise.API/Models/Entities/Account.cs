using System.Text.Json.Serialization;
using Pennywise.API.Interfaces.Entities;

namespace Pennywise.API.Models.Entities
{

    /// <summary>
    /// Model returned in metadata object from a successful call to Plaid endpoint /link/token/create
    /// </summary>
    /// <remarks>
    /// See <see href="https://plaid.com/docs/link/web/#onsuccess">for more information</see>
    /// </remarks>
    public class Account : IAccount
    {
        [JsonPropertyName("account_id")] public string AccountId { get; set; } = string.Empty;

        [JsonPropertyName("name")] public string Name { get; set; } = string.Empty;

        [JsonPropertyName("mask")] public string? Mask { get; set; } = string.Empty;

        [JsonPropertyName("type")] public string Type { get; set; } = string.Empty;

        [JsonPropertyName("subtype")] public string? Subtype { get; set; } = string.Empty;

        [JsonPropertyName("verification_status")]
        public string? VerificationStatus { get; set; }

        [JsonPropertyName("class_type")] public string? ClassType { get; set; }

        [JsonPropertyName("balances")] public Balances? Balances { get; set; }

        [JsonPropertyName("official_name")] public string? OfficialName { get; set; }

        [JsonIgnore]
        [JsonPropertyName("persistent_account_id")]
        public string? PersistentAccountId { get; set; }
    }
}