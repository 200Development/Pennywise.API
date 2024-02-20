using System.Text.Json.Serialization;
using Pennywise.API.Interfaces.Entities;
using Newtonsoft.Json;

namespace Pennywise.API.Models.Entities
{

    /// <summary>
    /// Returned in metadata object from a successful call to Plaid endpoint /link/token/create
    /// </summary>
    /// <remarks>
    /// See <see href="https://plaid.com/docs/link/web/#onsuccess">for more information</see>
    /// </remarks>
    public class Institution : IInstitution
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("institution_id")]
        [JsonPropertyName("institution_id")]
        public string InstitutionId { get; set; } = string.Empty;
    }
}