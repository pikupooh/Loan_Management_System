using LoanManagementSystem.Models;
using LoanManagementSystem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoadManagementSystem.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class EMICalculator : ControllerBase
    {
        EMICalculatorService emicalculatorservice;
        public EMICalculator()
        {
            emicalculatorservice = new EMICalculatorService();
        }

        [HttpGet("calculateEmi")]
        public IActionResult CalculateEMI([FromQuery] int months, float amount,float rate)
        {
            float totalAmount = 0;
            float emi;
            float r = rate / (12 * 100);
            emi = (amount * r * (float)Math.Pow(1 + r, months))/(float)(Math.Pow(1 + r, months) - 1);
            totalAmount = emi * months;
            return Ok(totalAmount);
        }
    }
}
