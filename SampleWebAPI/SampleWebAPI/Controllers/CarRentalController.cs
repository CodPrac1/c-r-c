using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleWebAPI.NewFolder2.NewFolder;
using Microsoft.EntityFrameworkCore;
using SampleWebAPI.NewFolder2;
using SampleWebAPI.NewFolder1;

namespace SampleWebAPI.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class CarRentalController : ControllerBase
    {
        private readonly SampleWebAPIDbcontext dbContext;

        public CarRentalController(SampleWebAPIDbcontext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]

        public IActionResult GetAll()
        {
            var registration = dbContext.Registrationclasses.ToList();
           /*   var registration = new List<RegistrationClass>
            {
                new RegistrationClass
                {
                    Id = Guid.NewGuid(),
                    UserName = "Animal",
                    Date = "12/13/2023",
                    ReturnDate = "12/16/2023",
                    Payment = "FirstFreeCouponApplied"
                },
                new RegistrationClass
                {
                    Id = Guid.NewGuid(),
                    UserName = "Arjun Reddy",
                    Date = "12/12/2023",
                    ReturnDate = "12/16/2023",
                    Payment = "FirstFreeCouponApplied"
                }

            };*/
            return Ok(registration);
        }
    }
}
