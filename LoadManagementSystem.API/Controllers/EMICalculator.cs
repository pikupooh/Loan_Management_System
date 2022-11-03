using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoadManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EMICalculator : ControllerBase
    {
        [HttpGet]
        public IActionResult CalculateEMI()
        {
            return Ok();
        }
    }
}
