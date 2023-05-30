using DSE.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSE.Repository.DatabaseExtension
{
    public static class DBExtension
    {
        public static void DBExtensionMethod(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<DatabaseContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DevConnection")));
            services.AddDistributedMemoryCache();
        }
    }
}
