using MechanicalWorkshop.Api.Model;
using Microsoft.AspNetCore.Mvc;

namespace MechanicalWorkshop.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        public CarController()
        {
            _cars = new List<Car>();    
        }

        [HttpGet("cars")]
        public IEnumerable<Car> GetAllCars()
        {
            foreach(var car in _cars)
            {
                yield return car;
            }
        }

        [HttpGet($"cars/1")]
        public Car GetCarById(int id)
        {
            return new Car(id);
        }

        [HttpPost("addCar")]
        public void AddCar()
        {
            _cars.Add(new Car("Audi", "A4"));
        }

        private IList<Car> _cars;
    }
}
