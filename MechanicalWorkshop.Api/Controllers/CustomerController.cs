using MechanicalWorkshop.Api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MechanicalWorkshop.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private IList<Customer> _customers;

        public CustomerController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("customers")]
        public async Task<IActionResult> GetAllCustomers()
        {
            var customers = await _dbContext.Customers.ToListAsync();
            return Ok(customers);
        }

        [HttpGet($"customers/1")]
        public Customer GetCustomerById(int id)
        {
            return new Customer(id);
        }

        [HttpPost("addCustomer")]
        public void AddCustomer()
        {
            _dbContext.Customers.Add(new Customer("Stephen", "Black"));
        }

        [HttpDelete("{id}")]
        public void DeleteCustomerById(int id)
        {
            var recordToRemove = _dbContext.Customers.FirstOrDefault(x => x.Id == id);

            _dbContext.Customers.Remove(recordToRemove);
        }
    }
}
