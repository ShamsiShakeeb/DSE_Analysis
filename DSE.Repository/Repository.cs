using DSE.Model.Response;
using DSE.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DSE.Repository
{
    public class Repository<T> : IRepository<T> where T : class 
    {
        public readonly DatabaseContext _context;
        public Repository(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<ResponseModel<T>> Insert(T model)
        {
            try
            {
                await _context.AddAsync(model);
                await _context.SaveChangesAsync();
                return new ResponseModel<T>()
                {
                    success = true,
                    Message = "Data Inserted Successfully",
                    ErrorMessage = null,
                    Data = model
                };
            }
            catch(Exception ex)
            {
                return new ResponseModel<T>()
                {
                    success = true,
                    Message = ex.Message,
                    ErrorMessage = "Error Occurred!",
                    Data = model
                };
            }
        }
        public IQueryable<T> Get(
           Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression).AsNoTracking();
        }
        public async Task<ResponseModel<List<T>>> InsertRange(List<T> model)
        {
            try
            {
                _context.Set<T>().AddRange(model);
                await _context.SaveChangesAsync();
                return new ResponseModel<List<T>>()
                {
                    success = true,
                    Message = "Set of Data Insersted Successfully",
                    ErrorMessage = null,
                    Data = model
                };
            }
            catch (Exception ex)
            {
                return new ResponseModel<List<T>>()
                {
                    success = false,
                    Message = "Set of Data Not Insersted",
                    ErrorMessage = ex.Message,
                    Data = model
                };
            }
        }
    }
}
