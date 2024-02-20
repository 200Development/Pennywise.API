using System.Text.Json.Serialization;
using Pennywise.API.Interfaces.Entities;

namespace Pennywise.API.Models.Entities
{
    public class Options : IOptions
    {
        [JsonPropertyName("include_original_description")]
        public bool IncludeOriginalDescription { get; set; }
    }
}
