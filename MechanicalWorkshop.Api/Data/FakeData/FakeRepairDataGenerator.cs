using MechanicalWorkshop.Api.Model;

namespace MechanicalWorkshop.Api.Data.FakeData
{
    public class FakeRepairDataGenerator : IFakeDataGenerator<Repair>
    {
        public FakeRepairDataGenerator()
        {
            
        }

        public List<Repair> SeedWithData()
        {
            var list = new List<Repair>()
            {
                new Repair()
                {
                    Customer = new Customer("Tom", "Hanks"),
                    Car = new Car() {BrandName = "Audi"},
                    Description = "There is some weird noise coming from back of the car when pushing the throttle.",
                    Price = 100
                },
                new Repair()
                {
                    Customer = new Customer("Hank", "Cruise"),
                    Car = new Car() { BrandName = "Honda" },
                    Description = "Replace break pads for new ones.",
                    Price = 300
                },
                new Repair()
                {
                    Customer = new Customer("Elisabeth", "Hotchkins"),
                    Car = new Car() { BrandName = "Mercedes" },
                    Description = "The steering wheel hardly turns.",
                    Price = 1200
                }
            };

            return list;
        }
    }
}
