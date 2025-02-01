using System.Text.Json.Serialization;
using Pennywise.API.Interfaces.Entities;

namespace Pennywise.API.Models.Entities
{

    public class PaymentMeta : IPaymentMeta
    {
        [JsonPropertyName("reference_number")] public string? ReferenceNumber { get; set; }

        [JsonPropertyName("ppd_id")] public string? PPDId { get; set; }

        [JsonPropertyName("payee")] public string? Payee { get; set; }

        [JsonPropertyName("by_order_of")] public string? ByOrderOf { get; set; }

        [JsonPropertyName("payer")] public string? Payer { get; set; }

        [JsonPropertyName("payment_method")] public string? PaymentMethod { get; set; }

        [JsonPropertyName("payment_processor")]
        public string? PaymentProcessor { get; set; }

        [JsonPropertyName("reason")] public string? Reason { get; set; }
    }
}