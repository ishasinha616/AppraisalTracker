using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AppraisalTrackerUdit.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext()
            : base(@"server=OXFORDN11\SQLEXPRESS;uid=sa;pwd=info@123!;database=AT1")
        {

        }

        public DbSet<Authentication> Authentications { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<KRADetails> KRADetails { get; set; }
        public DbSet<Operational> Operationals { get; set; }
        public DbSet<Development> Developments { get; set; }
    }
}