using System.Text.Json.Serialization;
using Pennywise.API.Interfaces.Entities;

namespace Pennywise.API.Models.Entities
{

    public class User : IUser
    {
        [JsonPropertyName("client_user_id")] public required string ClientUserId { get; set; }
    }
}