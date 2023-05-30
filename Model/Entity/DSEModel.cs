using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSE.Model.Entity
{
    public class DSEModel
    {
        [Key]
        public int Id { set; get; }
        public string Sector { set; get; }
        public string CompanyName { set; get; }
        public string Url { set; get; }
    }
}
