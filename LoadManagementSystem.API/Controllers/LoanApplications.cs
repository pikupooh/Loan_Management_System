using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoadManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanApplications : ControllerBase
    {
        [HttpGet("getAllApplications")]
        public IActionResult GetAllApllications()
        {
            return Ok();
        }

        [HttpGet("getApplicationByCustomerId/{customerId}")]
        public IActionResult GetApllicationByCustomerId([FromRoute] int customerId)
        {
            return Ok();
        }

        [HttpGet("getApplicationByApplicationId/{applicationId}")]
        public IActionResult GetApllicationByApplicationId([FromRoute] int applicationId)
        {
            return Ok();
        }
    }
}
