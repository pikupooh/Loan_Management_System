using LoanManagementSystem.Models;
using LoanManagementSystem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoadManagementSystem.API
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
            LoanApplication application = loanApplicationsService.GetApllicationByCustomerId(customerId);
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

        [HttpPost("submitLoanApplication/{LoanTypeName}")]
        public IActionResult SubmitLoanApplication([FromBody] int Id, [FromQuery] string LoanTypeName)
        {
            LoanApplication application = loanApplicationsService.SubmitApplication(Id, LoanTypeName);

            if (application == null)
            {
                return BadRequest();
            }
            return Ok(application);
        }
        
    }
}
