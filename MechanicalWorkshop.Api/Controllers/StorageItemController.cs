using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MechanicalWorkshop.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class StorageItemController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public StorageItemController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("StorageItems")]
        public async Task<IActionResult> GetAllStorageItems()
        {
            var storageItems = await _dbContext.StorageItems.ToListAsync();
            return Ok(storageItems);
        }
    }
}
