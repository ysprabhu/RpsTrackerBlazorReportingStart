using Microsoft.AspNetCore.Mvc;
using Telerik.Reporting.Services;
using Telerik.Reporting.Services.AspNetCore;

namespace RPS.Web.Server.Controller
{
  [Route("api/reports")]
  [ApiController]
  public class ReportsController : ReportsControllerBase
  {
        public ReportsController(IReportServiceConfiguration reportServiceConfig) : base(reportServiceConfig)
        {
            
        }
    }
}
