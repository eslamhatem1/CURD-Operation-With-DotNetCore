using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace taskdayone_Core_.Models
{
    public class department
    {
        [Key]
        public int departmentid { get; set; }
        public string deptname { get; set; }
        public virtual ICollection<employee>Employees { get; set; }

        public department()
        {
            Employees = new HashSet<employee>();
        }
    }
}
