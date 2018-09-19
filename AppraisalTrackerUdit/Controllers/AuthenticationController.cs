using AppraisalTrackerUdit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppraisalTrackerUdit.Controllers
{
    public class AuthenticationController : Controller
    {
        
        AuthenticationRepo repo = new AuthenticationRepo();
        string empName;
        //// GET: Authentication
        [HttpGet]
        //[AllowAnonymous]
        public ActionResult Index()
        {
            //List<Authentication> authList = repo.ShowEmployees();
            return View();
        }

        [HttpPost]
        public ActionResult Index(Authentication auth)
        {
            using (EmployeeContext db = new EmployeeContext())
            {
                var query = db.Authentications.SingleOrDefault(u=>u.UserName==auth.UserName && u.Password==auth.Password);
                if (query !=null)
                {
                    return RedirectToAction("KuchBHiLIkhDE");
                }
                else
                {
                    ModelState.AddModelError("","User name or Password is wrong");
                }
            }
            return View();

        }

        public ActionResult TempIndex()
        {
            //List<Authentication> authList = repo.ShowEmployees();
            return View();
        }

        [HttpPost]
        public ActionResult TempIndex(Authentication auth)
        {
            using (EmployeeContext db = new EmployeeContext())
            {
                var query = db.Authentications.SingleOrDefault(u => u.UserName == auth.UserName && u.Password == auth.Password);
                if (query != null)
                {
                     var q1 = db.Employees.Where(x => x.EmpId == query.Employees.EmpId);
                    // employeeId = Convert.ToInt32(q1.ToList().Select(x => x.EmpId));
                    //ViewBag.eid = employeeId;
                    //Session["Emp Id"] = query.Employees.EmpId.ToString();
                    Session["User Name"] = query.UserName.ToString();
                    //return RedirectToAction("KuchBHiLIkhDE");

                    

                    return RedirectToAction("TempKRA");
                }
                else
                {
                    ModelState.AddModelError("", "User name or Password is wrong");
                }
            }
            return View();

        }

        [HttpGet]
        public ActionResult TempKRA()
        {
            //KRADetails kra = new KRADetails();
            //kra.Employees.EmpName = empName;
            ////kra.EmpId = employeeId;
            //return View(kra);
            return View();
        }

        [HttpPost]
        public ActionResult TempKRA(KRADetails kra)
        {

            return View();
        }


        //[HttpPost]
        //public ActionResult Index(FormCollection collection)
        //{
        //    Authentication auth = new Authentication();
        //    string userName = collection["uname"];
        //    string password= collection["psw"];

        //    foreach (var item in db.Authentications)
        //    {
        //        if (item.UserName.Equals(userName))
        //        {
        //            if (item.Password.Equals(password))
        //            {
        //               return View("KuchBHiLIkhDE");
        //            }
        //        }

        //    }
        //    return RedirectToAction("Index");
        //}

        public ActionResult KuchBHiLIkhDE()
        {
            return View();
        }
    }
}