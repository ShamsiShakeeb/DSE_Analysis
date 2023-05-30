using DSE.Repository;
using DSE.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSE.Service.DSEShare
{
    public interface IDSEShare : IRepository<DSE.Model.Entity.DSEShare>
    {
        Task<List<MonthWisePickPointAnalysisBeforeDecemberSchema>> MonthWisePickPointAnalysisBeforeDecember(int month);
    }
}
