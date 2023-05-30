using DSE.Model.Entity;
using DSE.Model.Response;
using DSE.WebScraping.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSE.WebScraping.ScarpDataSet
{
    public interface IDataCollection
    {
        Task<ResponseModel<string>> StoreShareMarketYearWiseClosingReport();
        Task<ResponseModel<List<DSEModel>>> StoreUrl(int year);
    }
}
