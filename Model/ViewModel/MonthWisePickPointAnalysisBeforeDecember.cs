using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSE.Model.ViewModel
{
    public class MonthWisePickPointAnalysisBeforeDecember
    {
      
        public string ThisMonth { set; get; }
        public double ThisMonthShare { set; get; }
        public string NextMonth { set; get; }
        public double NextMonthShare { set; get; }
        public double AvgShare { set; get; }
        public int Year  { set; get; }
    }
    public class MonthWisePickPointAnalysisBeforeDecemberSchema
    {
        public string SectorName { set; get; }
        public string CompanyName { set; get; }
        public string Url { set; get; }
        public List<MonthWisePickPointAnalysisBeforeDecember> monthWisePickPointAnalysisBeforeDecembers { set; get; }
        public int MonthCount { set; get; }
        public int IncreaseRate { set; get; }
        public double AvgShare { set; get; }
    }
}
