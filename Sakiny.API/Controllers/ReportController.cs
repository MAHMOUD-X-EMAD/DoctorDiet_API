using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Saking.Reposetory.UnitOfWork;
using Sakiny.DTO;
using Sakiny.Models;
using Sakiny.Services;

namespace Sakiny.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        ReportService _reportService;
        IUnitOfWork _unitOfWork;

        public ReportController(ReportService reportService, IUnitOfWork unitOfWork)
        {
            _reportService = reportService;
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GetAllReports()
        {
            IEnumerable<ReportDto> reports = _reportService.GetAllReports();
            return Ok(reports);
        }

        [HttpGet("{ReportID:int}")]
        public IActionResult GetByReportID(int ReportID) 
        {
          ReportDto reportDto=_reportService.GetByReportID(ReportID);
          return Ok(reportDto);
        }

        [HttpGet("{UserID}")]
        public IActionResult GetReportByUserID(string UserID)
        {
            ReportDto report=_reportService.GetReportByUserID(UserID);
            return Ok(report);
        }

        [HttpPost]
        public IActionResult AddReport(ReportCtreateDto report) 
        {
            _reportService.AddReport(report);
            _unitOfWork.CommitChanges();

            return Ok("Added");
        }

        [HttpPut]
        public IActionResult UpdateReport(Report report, params string[] updatedProp)
        {
         string status  =_reportService.UpdateReport(report, updatedProp);
            _unitOfWork.CommitChanges();

            return Ok(status);
        }


    }
}
