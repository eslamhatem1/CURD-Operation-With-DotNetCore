using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace taskdayone_Core_.Models
{
    public class Model :DbContext
    {
        public Model(DbContextOptions options):base(options)
        {

        }

        public virtual DbSet<employee> Employees { get; set; }
        public virtual DbSet<department> Departments { get; set; }
    }
}
