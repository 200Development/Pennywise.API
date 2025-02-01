namespace Pennywise.API.Interfaces.Responses
{

    public interface ILinkTokenCreateResponse
    {
        string? LinkToken { get; set; }
        DateTime Expiration { get; set; }
        string? RequestId { get; set; }
    }
}