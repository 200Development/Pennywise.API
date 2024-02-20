namespace Pennywise.API.Interfaces.Entities
{

    public interface ILocation
    {
        string? Address { get; set; }
        string? City { get; set; }
        string? PostalCode { get; set; }
        string? Country { get; set; }
    }
}