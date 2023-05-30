using DSE.Repository;
using DSE.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSE.Service.DSEUrlList
{
    public class DSEUrlListService : Repository<DSE.Model.Entity.DSEModel>,IDSEUrlListService
    {
        public DSEUrlListService(DatabaseContext context) : base(context)
        {
        }
    }
}
