using LoanManagementSystem.Models;
using LoanManagementSystem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace LoanManagementSystem.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        ProfileService profileService;
        public ProfileController()
        {
            profileService = new ProfileService();
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            CustomerInfo user = profileService.GetProfileById(id);
            if (user == null)
            {
                return NotFound("User Id not found");
            }

            return Ok(user);
        }

        [HttpGet("getAllProfiles")]
        public IActionResult GetAllProfiles()
        {
            List<CustomerInfo> profileList = profileService.GetAllProfile();
            return Ok(profileList);
        }
    }
}
