using Microsoft.EntityFrameworkCore;
using DSE.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSE.Repository.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        public DbSet<DSEModel> DSEUrlList { get; set; }
        public DbSet<DSEShare> DSEShare { get; set; }
        
    }
}
