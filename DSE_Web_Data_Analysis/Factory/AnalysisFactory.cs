using DSE.Service.DSEShare;
using DSE.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSE_Web_Data_Analysis.Factory
{
    public class AnalysisFactory : IAnalysisFactory
    {
        private readonly IDSEShare _dSEShare;
        public AnalysisFactory(IDSEShare dSEShare)
        {
            _dSEShare = dSEShare;
        }
        public async Task<List<MonthWisePickPointAnalysisBeforeDecemberSchema>> MonthWisePickPointAnalysisBeforeDecemberReport(int month)
        {
            var data = await _dSEShare.MonthWisePickPointAnalysisBeforeDecember(month);
            var order = data.OrderByDescending(x => x.MonthCount)
                .ThenByDescending(x => x.IncreaseRate)
                .ThenByDescending(x => x.AvgShare)
                .ToList();
            return order;
        }
    }
}
