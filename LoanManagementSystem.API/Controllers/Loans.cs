using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoadManagementSystem.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class Loans : ControllerBase
    {
        [HttpGet("getAllLoans")]
        public IActionResult GetAllLoans()
        {
            return Ok();
        }

        [HttpGet("getLoanByLoanId/{LoanId}")]
        public IActionResult GetLoanByLoanId([FromRoute] int LoanId)
        {
            return Ok();
        }

        [HttpGet("getLoanByCustomerId/{CutomerId}")]
        public IActionResult GetLoansByCustomerId([FromRoute] int CustomerId)
        {
            return Ok();
        }

        [HttpGet("getLoanTypeDetails")]
        public IActionResult LoanTypeDetails()
        {
            return Ok();
        }

    }
}
