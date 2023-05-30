using DSE.WebScraping.ScarpDataSet;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DSE.WebScraping.WebScarpingExtension
{
    public static class WebScrapingExtensionMethod
    {
        public static void ScrapingExtensionMethod(this IServiceCollection services)
        {
            services.AddScoped<IDataCollection, DataCollection>();
        }
    }
}
