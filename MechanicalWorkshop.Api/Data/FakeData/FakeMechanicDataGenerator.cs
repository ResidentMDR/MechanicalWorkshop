using MechanicalWorkshop.Api.Model;

namespace MechanicalWorkshop.Api.Data.FakeData
{
    public class FakeMechanicDataGenerator : IFakeDataGenerator<Mechanic>
    {
        public List<Mechanic> SeedWithData()
        {
            var list = new List<Mechanic>()
            {
                new Mechanic() { Name = "Tom" },
                new Mechanic() { Name = "John" },
                new Mechanic() { Name = "Luke" }
            };

            return list;
        }
    }
}
