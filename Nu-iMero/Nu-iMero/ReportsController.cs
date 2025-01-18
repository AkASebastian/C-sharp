using Microsoft.AspNetCore.Mvc;
using Nu_iMero.Services;

namespace Nu_iMero.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly ReportService _reportService;

        public ReportsController()
        {
            _reportService = new ReportService(); // Ideally, use Dependency Injection
        }

        [HttpGet("download")]
        public IActionResult DownloadReport()
        {
            var pdfData = _reportService.GenerateSampleReport();
            return File(pdfData, "application/pdf", "SampleReport.pdf");
        }
    }
}
