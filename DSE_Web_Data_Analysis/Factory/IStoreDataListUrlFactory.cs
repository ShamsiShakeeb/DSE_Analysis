using DSE.Model.Entity;
using DSE.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSE_Web_Data_Analysis.Factory
{
    public interface IStoreDataListUrlFactory
    {
        Task<dynamic> DataScarpping(int years);
    }
}
