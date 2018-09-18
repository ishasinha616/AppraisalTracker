using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppraisalTrackerUdit.Models
{
    public class AuthenticationRepo
    {
        EmployeeContext db = new EmployeeContext();

        public List<Authentication> ShowEmployees()
        {
            return db.Authentications.ToList();
        }

    }
}