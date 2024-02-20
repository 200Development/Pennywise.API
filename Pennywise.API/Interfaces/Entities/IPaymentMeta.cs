namespace Pennywise.API.Interfaces.Entities
{

    public interface IPaymentMeta
    {
        string? ReferenceNumber { get; set; }
        string? PPDId { get; set; }
        string? Payee { get; set; }
        string? Payer { get; set; }
        string? PaymentMethod { get; set; }
    }
}