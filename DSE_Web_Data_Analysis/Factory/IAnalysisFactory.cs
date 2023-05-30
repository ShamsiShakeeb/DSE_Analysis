using DSE.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSE_Web_Data_Analysis.Factory
{
    public interface IAnalysisFactory
    {
        Task<List<MonthWisePickPointAnalysisBeforeDecemberSchema>> MonthWisePickPointAnalysisBeforeDecemberReport(int month);
    }
}
