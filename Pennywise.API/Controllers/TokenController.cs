using Microsoft.AspNetCore.Mvc;
using Pennywise.API.Interfaces.Clients;
using Pennywise.API.Models.Entities;
using Pennywise.API.Models.Requests;

namespace Pennywise.API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TokenController : Controller
    {
        private readonly IPlaidClient _plaidClient;
        private readonly PlaidSettings _plaidSettings;

        public TokenController(IPlaidClient plaidClient, PlaidSettings plaidSettings)
        {
            _plaidClient = plaidClient;
            _plaidSettings = plaidSettings;
        }

        [HttpPost("linktoken")]
        public async Task<IActionResult> CreateLinkTokenAsync()
        {
            var request = new LinkTokenCreateRequest
            {
                ClientId = _plaidSettings.ClientId,
                Secret = _plaidSettings.PlaidSandboxSecret,
                ClientName = "JR Parsons, LLC",
                User = new User
                {
                    ClientUserId = "uniqueClientUserId"
                },
                Products = new List<string> { "transactions" },
                Language = "en",
                CountryCodes = new List<string> { "US" }
            };

            var linkToken = await _plaidClient.LinkTokenCreateAsync(request);

            return Ok(new { linkToken });
        }

        [HttpPost("publictokenexchange")]
        public async Task<IActionResult> ExchangePublicToken([FromBody] PublicTokenMetadata metadata)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);

            }

            var request = new PublicTokenExchangeRequest();
            var publicToken = await _plaidClient.ExchangePublicTokenAsync(request);

            return Ok(publicToken);
        }
    }
}