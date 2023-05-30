using DSE.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DSE.Repository
{
    public interface IRepository<T>
    {
        Task<ResponseModel<T>> Insert(T model);
        IQueryable<T> Get(
           Expression<Func<T, bool>> expression);
        Task<ResponseModel<List<T>>> InsertRange(List<T> model);
    }
}
