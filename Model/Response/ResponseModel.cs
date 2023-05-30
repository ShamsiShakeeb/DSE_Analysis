using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSE.Model.Response
{
    public class ResponseModel<T>
    {
        public bool success { set; get; }
        public string Message { set; get; }
        public string ErrorMessage { set; get; }
        public T Data { set; get; } 
    }
}
