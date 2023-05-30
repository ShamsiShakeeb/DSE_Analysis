using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSE.Model.Entity
{
    public class DSEShare
    {
        [Key]
        public int Id { set; get; }
        public DSEModel DSEModel { set; get; }
        public int DseModelId { set; get; }
        public string DateTime { set; get; }
        public double Share { set; get; }
        public int Year { set; get; }
        public int Month { set; get; }
        public int Date { set; get; }
    }
}
