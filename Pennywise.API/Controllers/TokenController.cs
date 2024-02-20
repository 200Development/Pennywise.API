using Microsoft.AspNetCore.Mvc;
using Pennywise.API.Interfaces.Services;
using Pennywise.API.Models.Entities;

namespace Pennywise.API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TokenController : Controller
    {
        private readonly ITokenService _tokenService;

        public TokenController(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("linktokens")]
        public async Task<IActionResult> CreateLinkTokenAsync()
        {
            var linkToken = await _tokenService.CreateLinkToken();

            return Ok(new { linkToken });
        }

        [HttpPost("publictokenexchange")]
        public async Task<IActionResult> ExchangePublicToken([FromBody] PublicTokenMetadata metadata)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);

            }

            var accounts = await _tokenService.ExchangePublicToken(metadata);

            if (accounts == null)
                return Problem("Unable to exchange public token for access token", statusCode: 500);
            if (!accounts.Any())
                return NoContent();
            return Ok(accounts);
        }
    }
}