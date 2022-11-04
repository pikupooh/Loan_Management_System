using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoadManagementSystem.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class Payments : ControllerBase
    {
        [HttpGet("getAllPayments")]
        public IActionResult GetAllPayments()
        {
            return Ok();
        }

        [HttpGet("getPaymentsByCustomerId/{customerId}")]
        public IActionResult GetPaymentsByCustomerId([FromRoute] int customerId)
        {
            return Ok();
        }

        [HttpGet("getPaymentsByPaymentId/{applicationId}")]
        public IActionResult GetPaymentsByPaymentId([FromRoute] int applicationId)
        {
            return Ok();
        }


    }
}
