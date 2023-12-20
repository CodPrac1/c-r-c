using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValueController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetValues()
        {
            string[] Values = new String[] { "1", "2", "3" };
            return Ok(Values);
        }

    }
}
