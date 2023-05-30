using DSE.WebScraping.ScarpDataSet;
using DSE.Model.Entity;
using DSE.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSE_Web_Data_Analysis.Factory
{
    public class StoreDataListUrlFactory : IStoreDataListUrlFactory
    {
        private readonly IDataCollection _dataCollection;
        public StoreDataListUrlFactory(IDataCollection dataCollection)
        {
            _dataCollection = dataCollection;
        }
        public async Task<dynamic> DataScarpping(int years)
        {
            var store = await _dataCollection.StoreUrl(years);
            if (!store.success)
                return store;
            var report = await _dataCollection.StoreShareMarketYearWiseClosingReport();
            if (!report.success)
                return report;
            return new ResponseModel<string>()
            {
                success = true,
                Message = "Data Stored Successfully",
                ErrorMessage = null,
                Data = "Response Model Does not Contains any Return Data"
            };
        }


    }
}
