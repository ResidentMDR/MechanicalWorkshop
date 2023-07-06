using MechanicalWorkshop.Api.Model;
using Microsoft.AspNetCore.Mvc;

namespace MechanicalWorkshop.Api.Controllers
{
    public class CarsController
    {
        public CarsController()
        {
            _cars = new List<Car>();    
        }

        [HttpGet("api/v1/cars")]
        public IEnumerable<Car> GetAll()
        {
            foreach(var car in _cars)
            {
                _cars.Add(car);
            }

            return _cars;
        }

        [HttpGet($"api/v1/cars/1")]
        public Car GetCarById()
        {
            return new Car();
        }

        [HttpPost("api/v1/addCar")]
        public void AddCar()
        {
            _cars.Add(new Car()
            {

            });
        }

        private List<Car> _cars;
    }
}
