using Pennywise.API.Interfaces.Entities;

namespace Pennywise.API.Interfaces.Requests
{

    public interface ILinkTokenCreateRequest
    {
        IUser? User { get; set; }
        string? ClientName { get; set; }
        IList<string>? Products { get; set; }
    }
}