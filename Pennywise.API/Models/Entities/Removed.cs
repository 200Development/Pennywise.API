using System.Text.Json.Serialization;
using Pennywise.API.Interfaces.Entities;

namespace Pennywise.API.Models.Entities
{

    public class Removed : IRemoved
    {
        [JsonPropertyName("transaction_id")] public string TransactionId { get; set; } = string.Empty;
    }
}