namespace Pennywise.API.Interfaces.Entities
{

    public interface ICounterParties
    {
        string Name { get; set; }
        string? EntityId { get; set; }
        string Type { get; set; }
        string? Website { get; set; }
        string? LogoUrl { get; set; }
        string? ConfidenceLevel { get; set; }
    }
}