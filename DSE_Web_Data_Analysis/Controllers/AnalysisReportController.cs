using DSE_Web_Data_Analysis.Factory;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSE_Web_Data_Analysis.Controllers
{
    public class AnalysisReportController : Controller
    {
        private readonly IAnalysisFactory _analysisFactory;
        public AnalysisReportController(IAnalysisFactory analysisFactory)
        {
            _analysisFactory = analysisFactory;
        }
        static List<DSE.Model.ViewModel.MonthWisePickPointAnalysisBeforeDecemberSchema> staticList = new
            List<DSE.Model.ViewModel.MonthWisePickPointAnalysisBeforeDecemberSchema>();

        [Route("AnalysisReport/MonthWisePickPointAnalysisBeforeDecemberReport/{month}")]
        public async Task<IActionResult> MonthWisePickPointAnalysisBeforeDecemberReport(int month)
        {
            var data = await _analysisFactory.MonthWisePickPointAnalysisBeforeDecemberReport(month);
            staticList = data;
            return View(data);
        }
        [Route("AnalysisReport/YearWise/{sectorName}/{companyName}")]
        public IActionResult YearWiseReportingSchema(string sectorName , string companyName)
        {
            var data = staticList;
            var result = data.Where(x => x.SectorName == sectorName && x.CompanyName == companyName)
                .Select(x => x.monthWisePickPointAnalysisBeforeDecembers)
                .FirstOrDefault();
            return View(result);
        }

    }
}
