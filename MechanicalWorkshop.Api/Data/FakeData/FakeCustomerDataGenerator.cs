using MechanicalWorkshop.Api.Model;

namespace MechanicalWorkshop.Api.Data.FakeData
{
    public class FakeCustomerDataGenerator
    {
        public FakeCustomerDataGenerator()
        {
            
        }

        public List<Customer> GenerateFakeData()
        {
            var list = new List<Customer>
            {
                new Customer("John", "Doe"),
                new Customer("Jane", "Smith"),
                new Customer("Bob", "Johnson"),
                new Customer("Alice", "Williams"),
                new Customer("Michael", "Davis"),
                new Customer("Emily", "Brown"),
                new Customer("Daniel", "Miller"),
                new Customer("Olivia", "Taylor"),
                new Customer("William", "Moore"),
                new Customer("Sophia", "Anderson")
            };

            return list;
        }

    }
}
