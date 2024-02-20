using Pennywise.API.Interfaces.Responses;

namespace Pennywise.API.Models.Responses
{

    public class GetAccessTokenAndLatestCursorResponse : IGetAccessTokenAndLatestCursorResponse
    {
        public string AccessToken { get; set; } = string.Empty;
        public string? NextCursor { get; set; }
    }
}