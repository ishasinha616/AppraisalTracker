using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppraisalTrackerUdit.Models
{
    public class Authentication
    {
        [Key]
        public int EmpId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Employee Employees { get; set; }
    }
}