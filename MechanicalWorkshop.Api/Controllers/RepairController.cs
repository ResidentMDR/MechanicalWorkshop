using MechanicalWorkshop.Api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MechanicalWorkshop.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class RepairController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public RepairController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("Repairs")]
        public async Task<IActionResult> GetAllRepairs()
        {
            var Repairs = await _dbContext.Repairs.ToListAsync();
            return Ok(Repairs);
        }
    }
}
