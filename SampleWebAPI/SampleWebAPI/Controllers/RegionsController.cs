using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleWebAPI.NewFolder.NewFolder;
using SampleWebAPI.NewFolder1;
using System.Security.Permissions;

namespace SampleWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly SampleWebAPIDbcontext dbContext;

        public RegionsController(SampleWebAPIDbcontext dbContext)
        {
            this.dbContext = dbContext;
        }
        // Using Constructor injection
        // Creating construcution shortcut ctordoubletab

        [HttpGet]

        public IActionResult GetAll()
        {
               var regions = new List<Region>
               {
                   new Region
                   {
                       Id = Guid.NewGuid(),
                       Name = "Kondapur",
                       Code = "KDP",
                       RegionImageUrl = "image.url",
                   },
                   new Region
                   {
                       Id = Guid.NewGuid(),
                       Name = "Kokapet",
                       Code = "KKP",
                       RegionImageUrl = "image.url",
                   },
               };

           // var regions = dbContext.Regions.ToList();

            return Ok(regions);
        }
    }
}
