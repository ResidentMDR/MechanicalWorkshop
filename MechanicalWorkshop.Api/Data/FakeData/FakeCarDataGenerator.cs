using MechanicalWorkshop.Api.Model;
using Microsoft.EntityFrameworkCore;

namespace MechanicalWorkshop.Api.Data.FakeData
{
    public class FakeCarDataGenerator// : IFakeDataGenerator<Car>
    {
        public List<Car> SeedWithData(ApplicationDbContext context)
        {
            List<Car> list = null;

            using (context = new ApplicationDbContext())
            {
                var customers = context.Customers.ToList();

                list = new List<Car>()
                {
                    new Car()
                    {
                        BrandName = "Audi",
                        ModelName = "A4",
                        VIN = "WJXSP2152DOV",
                        Owner = customers.FirstOrDefault(e => e.Id == 1),
                        CustomerId = 1
                    },
                    //new Car()
                    //{
                    //    BrandName = "Honda",
                    //    ModelName = "Civic",
                    //    VIN = "HWI4251VWFD"
                    //},
                    //new Car()
                    //{
                    //    BrandName = "Mercedes",
                    //    ModelName = "CLA",
                    //    VIN = "GPQJF4012DDF"
                    //},
                }; 

                context.Cars.AddRange(list);
                context.SaveChanges();
            }

            return list;
        }
    }
}
