namespace Pennywise.API.Interfaces.DTOs
{

    public interface IAccountDto
    {
        string AccountId { get; set; }
        decimal? AvailableBalance { get; set; }
        decimal? CurrentBalance { get; set; }
        decimal? Limit { get; set; }
        string? IsoCurrencyCode { get; set; }
        string Name { get; set; }
        string Type { get; set; }
        string? Subtype { get; set; }
    }
}