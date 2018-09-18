using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppraisalTrackerUdit.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int ManagerId { get; set; }
        public List<KRADetails> KRADetails { get; set; }
        public List<Authentication> Authentications { get; set; }
    }
}