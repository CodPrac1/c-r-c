
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleWebAPI.NewFolder2.NewFolder;
using Microsoft.EntityFrameworkCore;
using SampleWebAPI.NewFolder2;
using SampleWebAPI.NewFolder1;

namespace SampleWebAPI.NewFolder2.NewFolder

{
    public class RegistrationClass
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string Date { get; set; }

        public string ReturnDate { get; set; }

        public String Payment { get; set; }
    }
}
