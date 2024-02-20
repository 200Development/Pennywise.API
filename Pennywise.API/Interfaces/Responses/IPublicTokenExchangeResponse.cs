namespace Pennywise.API.Interfaces.Responses
{

    public interface IPublicTokenExchangeResponse
    {
        string AccessToken { get; set; }
        string ItemId { get; set; }
        string RequestId { get; set; }
    }
}