using DSE.Repository;
using DSE.Repository.Context;
using DSE.Service.DSEUrlList;
using Microsoft.EntityFrameworkCore;
using DSE.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSE.Service.DSEShare
{
    public class DSEShare : Repository<DSE.Model.Entity.DSEShare> , IDSEShare
    {
        private readonly IDSEUrlListService _iDSEUrlListService;
        public DSEShare(DatabaseContext context,
            IDSEUrlListService iDSEUrlListService) : base(context)
        {
            _iDSEUrlListService = iDSEUrlListService;
        }

        private string MonthtoMonthString(int month)
        {
            if (month == 1)
            {
                return "Jan";
            }
            else if (month == 2)
            {
                return "Feb";
            }
            else if (month == 3)
            {
                return "Mar";
            }
            else if (month == 4)
            {
                return "Apr";
            }
            else if (month == 5)
            {
                return "May";
            }
            else if (month == 6)
            {
                return "June";
            }
            else if (month == 7)
            {
                return "Jul";
            }
            else if (month == 8)
            {
                return "Aug";
            }
            else if (month == 9)
            {
                return "Sep";
            }
            else if (month == 10)
            {
                return "Oct";
            }
            else if (month == 11)
            {
                return "Nov";
            }
            else if (month == 12)
            {
                return "Dec";
            }
            return null;
        }

        public async Task<List<MonthWisePickPointAnalysisBeforeDecemberSchema>> MonthWisePickPointAnalysisBeforeDecember(int month)
        {
            var DSEShare = await Get(x => true).ToListAsync();
            var companies = await _iDSEUrlListService.Get(x=>true).OrderBy(x=> x.Id).ToListAsync();
            var perProfits = new List<MonthWisePickPointAnalysisBeforeDecemberSchema>();
            foreach (var c in companies)
            {
                var companyWise = DSEShare.Where(x => x.DseModelId == c.Id).ToList();

                var years = companyWise.Where(x => x.DseModelId == c.Id).Select(x => x.Year).OrderBy(x=>x).Distinct().ToList();

                bool profit = true;

                var perProfit = new List<MonthWisePickPointAnalysisBeforeDecember>();

                double AvgProfit = 0;
                int IncreaseRate = 0;

                foreach (var y in years)
                {
                    try
                    {
                        var thisMonth = companyWise.Where(x => x.DseModelId == c.Id && x.Year == y && x.Month == month).Max(x => x.Share);
                        var nextMonth = companyWise.Where(x => x.DseModelId == c.Id && x.Year == y && x.Month == month + 1).Max(x => x.Share);

                        if (thisMonth > nextMonth)
                        {
                            profit = false;
                            break;
                        }
                        else
                        {
                            var per_profit = new MonthWisePickPointAnalysisBeforeDecember()
                            {
                                Year = y,
                                ThisMonth = MonthtoMonthString(month),
                                ThisMonthShare = thisMonth,
                                NextMonth = MonthtoMonthString(month + 1),
                                NextMonthShare = nextMonth
                            };
                            AvgProfit += (per_profit.NextMonthShare - per_profit.ThisMonthShare);
                            IncreaseRate += (per_profit.NextMonthShare - per_profit.ThisMonthShare) > 0 ? 1 : 0;
                            perProfit.Add(per_profit);
                        }
                    }
                    catch (Exception ex) { }
                }
                if (profit)
                {
                    if (perProfit.Any())
                    {
                        var profits = new MonthWisePickPointAnalysisBeforeDecemberSchema()
                        {
                            SectorName = c.Sector,
                            CompanyName = c.CompanyName,
                            Url = c.Url,
                            MonthCount = perProfit.Count(),
                            AvgShare = AvgProfit / perProfit.Count(),
                            IncreaseRate = IncreaseRate,
                            monthWisePickPointAnalysisBeforeDecembers = perProfit
                        };
                        perProfits.Add(profits);
                    }
                }
            }
            return perProfits;
        }
    }
}
