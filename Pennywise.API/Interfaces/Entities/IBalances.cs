namespace Pennywise.API.Interfaces.Entities
{

    public interface IBalances
    {
        decimal? Available { get; set; }
        decimal? Current { get; set; }
        string? IsoCurrencyCode { get; set; }
        decimal? Limit { get; set; }
        string? LastUpdatedDate { get; set; }
    }
}