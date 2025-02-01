namespace Pennywise.API.Interfaces.Entities
{

    public interface IPlaidError
    {
        string ErrorType { get; set; }
        string ErrorCode { get; set; }
        string ErrorMessage { get; set; }
        string? DisplayMessage { get; set; }
        string RequestId { get; set; }
        int? Status { get; set; }
        string DocumentationUrl { get; set; }
        string? SuggestedAction { get; set; }
    }
}