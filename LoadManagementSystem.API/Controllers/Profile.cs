using LoanManagementSystem.Models;
using LoanManagementSystem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace LoadManagementSystem.API
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
            profileService.GetProfileById(id);
            if(profileService == null)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpGet("getAllProfiles")]
        public IActionResult GetAllProfiles()
        {
            List<Profile> profileList = profileService.GetAllProfile();
            return Ok();
        }
    }
}
