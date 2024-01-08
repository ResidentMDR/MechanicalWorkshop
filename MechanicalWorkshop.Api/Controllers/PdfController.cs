using MechanicalWorkshop.Api.Pdf;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MechanicalWorkshop.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PdfController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        public PdfController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("GetPdf")]
        public async Task<IActionResult> GetPdfReport()
        {
            PdfService.GetExamplePdf();
            return Ok();
        }
    }
}
