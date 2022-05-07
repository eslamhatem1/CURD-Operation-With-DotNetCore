using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace taskdayone_Core_.Models
{
    public class employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public int? age { get; set; }
                
        public int departmentid { get; set; }

        public virtual department Department { get; set; }
    }
}
