using System.Text.Json.Serialization;
using Pennywise.API.Interfaces.Entities;

namespace Pennywise.API.Models.Entities
{

    public class Location : ILocation
    {
        [JsonPropertyName("address")] public string? Address { get; set; }

        [JsonPropertyName("city")] public string? City { get; set; }

        [JsonPropertyName("region")] public string? Region { get; set; }

        [JsonPropertyName("postal_code")] public string? PostalCode { get; set; }

        [JsonPropertyName("country")] public string? Country { get; set; }

        [JsonPropertyName("lat")] public double? Lat { get; set; }

        [JsonPropertyName("lon")] public double? Long { get; set; }

        [JsonPropertyName("store_number")] public string? StoreNumber { get; set; }
    }
}