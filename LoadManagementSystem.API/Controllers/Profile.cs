using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoadManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Profile : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            System.Diagnostics.Debug.WriteLine(id);
            return Ok();
        }

        [HttpGet("getAllProfiles")]
        public IActionResult GetAllProfiles()
        {
            System.Diagnostics.Debug.WriteLine("get all profiles");
            return Ok();
        }
    }
}
