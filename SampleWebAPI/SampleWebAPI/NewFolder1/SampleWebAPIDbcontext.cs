using Microsoft.EntityFrameworkCore;
using SampleWebAPI.NewFolder.NewFolder;
using SampleWebAPI.NewFolder1;
using SampleWebAPI.NewFolder2.NewFolder;
using System.Security;

namespace SampleWebAPI.NewFolder1
{
    public class SampleWebAPIDbcontext: DbContext    
    {
        public SampleWebAPIDbcontext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
            
        }

        public DbSet<Difficulty> Difficulties { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Class3> Class3s { get; set; }

        public DbSet<RegistrationClass> Registrationclasses { get; set; }

        public DbSet<Customerclass> Customerclasses { get; set; }

        public DbSet<InventoryClass> Inventoryclasses { get; set; }




    }
}
