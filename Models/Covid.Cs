using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace covidAPI.Models
{
    public class Covid
    {
        
        public int? deaths { get; set; }
        public DateTime? date { get; set; }
        public int? cases { get; set; }
    }
}
