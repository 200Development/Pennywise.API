using System.Text.Json.Serialization;

namespace Pennywise.API.Interfaces.Entities
{

    public interface IOptions
    {
        [JsonPropertyName("include_original_description")]
        bool IncludeOriginalDescription { get; set; }
    }
}