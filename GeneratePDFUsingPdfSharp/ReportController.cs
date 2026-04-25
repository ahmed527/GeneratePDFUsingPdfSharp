using Microsoft.AspNetCore.Mvc;

namespace GeneratePDFUsingGeneratePDFMigraDoc
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        [HttpGet("generate")]
        public IActionResult GeneratePdf()
        {
            var data = new List<ReportData>
{
    new ReportData
    {
        Title = "Trip Details # 123",
        GeneratedBy = "MATP1",
        Items = new List<ReportItem>
        {
            new ReportItem { Id = "1", Description = "Appointment 1", Category = "Work", Status = "Approved", Amount = "150.00" },
            new ReportItem { Id = "2", Description = "Appointment 2", Category = "Medical", Status = "Pending", Amount = "300.50" },
            new ReportItem { Id = "3", Description = "Appointment 3", Category = "School", Status = "Approved", Amount = "45.00" }
        }
    },
    new ReportData
    {
        Title = "Trip Details # 124",
        GeneratedBy = "MATP2",
        Items = new List<ReportItem>
        {
            new ReportItem { Id = "4", Description = "Appointment 4", Category = "Work", Status = "Pending", Amount = "200.00" },
            new ReportItem { Id = "5", Description = "Appointment 5", Category = "Emergency", Status = "Approved", Amount = "120.75" }
        }
    }
};

            var pdfService = new PdfReportMigraDocService();
            byte[] pdfBytes = pdfService.GenerateReport(data);

            return File(pdfBytes, "application/pdf", "TripReport.pdf");
        }
    }
}
