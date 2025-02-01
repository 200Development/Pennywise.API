using Pennywise.API.Interfaces.Entities;
using Pennywise.API.Models.Entities;

namespace Pennywise.API.Interfaces.Requests
{

    public interface ILinkTokenCreateRequest
    {
        User User { get; set; }
        string? ClientName { get; set; }
        IList<string>? Products { get; set; }
    }
}