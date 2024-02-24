using Microsoft.AspNetCore.Mvc;
using Pennywise.API.Interfaces.Repositories;

namespace Pennywise.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MetricsController : Controller
    {
        private readonly IPennywiseRepository _pennywiseRepository;

        public MetricsController(IPennywiseRepository pennywiseRepository)
        {
            _pennywiseRepository = pennywiseRepository;
        }

        [HttpPost("useravgmonthlysavings")]
        public async Task<IActionResult> GetAvgMonthlySpendingByUserIdAsync([FromBody] int userId)
        {
            try
            {
                var metrics = await _pennywiseRepository.GetAvgMonthlySpendingByUserIdAsync(userId);
                return Ok(metrics);
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }
    }
}
