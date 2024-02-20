using System.Text.Json.Serialization;
using Pennywise.API.Interfaces.Entities;

namespace Pennywise.API.Models.Entities
{

    public class User : IUser
    {
        [JsonPropertyName("client_user_id")] public string? ClientUserId { get; set; }

        [JsonPropertyName("phone_number")] public string? PhoneNumber { get; set; }
    }
}