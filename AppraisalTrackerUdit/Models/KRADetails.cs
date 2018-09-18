using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppraisalTrackerUdit.Models
{
    public class KRADetails
    {
        [Key]
        public int EmpId { get; set; }
        public string Skills { get; set; }
        public double Weightage { get; set; }
        public double Rating { get; set; }
        public string StartingDate { get; set; }
        public string EndDate { get; set; }
        public string FeedbackRating { get; set; }
        public string FeedbackEscalate { get; set; }
        public Employee Employees { get; set; }
    }
}