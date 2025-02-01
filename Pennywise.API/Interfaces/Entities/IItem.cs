namespace Pennywise.API.Interfaces.Entities
{

    public interface IItem
    {
        string Id { get; set; }
        string? InstitutionId { get; set; }
        List<string> AvailableProducts { get; set; }
        List<string> BilledProducts { get; set; }
        List<string> Products { get; set; }
    }
}