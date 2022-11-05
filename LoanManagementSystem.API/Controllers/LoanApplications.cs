using LoanManagementSystem.Data;
using LoanManagementSystem.Models;
using LoanManagementSystem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanManagementSystem.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanApplications : ControllerBase
    {
        LoanApplicationsService loanApplicationsService;
        public LoanApplications()
        {
            loanApplicationsService = new LoanApplicationsService();
        }

        [HttpGet("getAllApplications")]
        public IActionResult GetAllApllications()
        {
            List<LoanApplication> list = loanApplicationsService.GetAllApllications();
            if (list.Any())
            {
                return Ok(list);
            }
            return NotFound();
        }

        [HttpGet("getApplicationByCustomerId/{customerId}")]
        public IActionResult GetApllicationByCustomerId([FromRoute] int customerId)
        {
            List<LoanApplication> application = loanApplicationsService.GetApllicationByCustomerId(customerId);
            if(application == null)
            {
                return NotFound();
            }

            return Ok(application);
        }

        [HttpGet("getApplicationByApplicationId/{applicationId}")]
        public IActionResult GetApllicationByApplicationId([FromRoute] int applicationId)
        {
            LoanApplication application = loanApplicationsService.GetApllicationByApplicationId(applicationId);
            if (application == null)
            {
                return NotFound();
            }

            return Ok(application);
        }

        [HttpPost("submitLoanApplication")]
        public IActionResult SubmitLoanApplication(int CustomerId, string LoanType, int LoanAmount)
        {
            LoanApplication application = loanApplicationsService.SubmitApplication(CustomerId, LoanType, LoanAmount);

            if (application == null)
            {
                return BadRequest();
            }
            return Ok(application);
        }

    }
}
