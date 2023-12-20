using SampleWebAPI.NewFolder.NewFolder;

namespace SampleWebAPI.NewFolder2.NewFolder
{
    public class InventoryClass
    {
        public Guid Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public String Color { get; set; }

        public string OrderType { get; set; }

        public Guid CustomerClassId { get; set; }
        public Guid RegistrationClassId { get; set; }

        // Navigation properties

        public Customerclass Customerclass { get; set; }
        public RegistrationClass RegistrationClass { get; set; }
    }
}
