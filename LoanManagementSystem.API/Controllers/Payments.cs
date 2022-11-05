using LoanManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LoanManagementSystem.Services;

namespace LoanManagementSystem.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class Payments : ControllerBase
    {
        private EmiPaymentService emiPaymentService;

        [HttpGet("getAllPayments")]
        public IActionResult GetAllPayments()
        {
            List<EmiPayment> emiPayments = emiPaymentService.GetAllPayments();
            if (emiPayments.Any())
            {
                return Ok(emiPayments);
            }
            return NotFound("No payments");
        }

        [HttpGet("getPaymentsByCustomerId/{customerId}")]
        public IActionResult GetPaymentsByCustomerId([FromRoute] int customerId)
        {
            List<EmiPayment> emiPayments = emiPaymentService.GetPaymentsByCustomerId(customerId);
            if (emiPayments.Any())
            {
                return Ok(emiPayments);
            }
            return NotFound("No payments");
        }

        [HttpGet("getPaymentByPaymentId/{paymentId}")]
        public IActionResult GetPaymentByPaymentId([FromRoute] int paymentId)
        {
            EmiPayment emiPayment = emiPaymentService.GetPaymentByPaymentId(paymentId);
            if (emiPayment != null)
            {
                return Ok(emiPayment);
            }
            return NotFound("No payments");
        }

        [HttpGet("getPaymentsByEmiId/{EmiId}")]
        public IActionResult GetPaymentsByEmiId([FromRoute] int EmilId)
        {
            List<EmiPayment> emiPayment = emiPaymentService.GetPaymentsByEmiId(EmilId);
            if (emiPayment.Any())
            {
                return Ok(emiPayment);
            }
            return NotFound("No payments");
        }


        [HttpPost("addPayment/{EmiId}")]
        public IActionResult AddPayment([FromRoute] int EmiId, int AmountPaid)
        {
            EmiPayment emiPayment = emiPaymentService.AddPayment(EmiId, AmountPaid);
            if(emiPayment != null)
            {
                return Ok(emiPayment);
            }
            return BadRequest("");
        }

    }
}
