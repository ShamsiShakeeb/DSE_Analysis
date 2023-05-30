using DSE.Service.DSEShare;
using DSE.Service.DSEUrlList;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSE.Service.ServiceExtension
{
    public static class ServiceExtension
    {
        public static void ServiceExtensionMethod(this IServiceCollection services)
        {
            services.AddScoped<IDSEUrlListService, DSEUrlListService>();
            services.AddScoped<IDSEShare, DSE.Service.DSEShare.DSEShare>();
        }
    }
}
