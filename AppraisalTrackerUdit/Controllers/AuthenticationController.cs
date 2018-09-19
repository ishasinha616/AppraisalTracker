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
        EmployeeContext db = new EmployeeContext();
        AuthenticationRepo repo = new AuthenticationRepo();

        //// GET: Authentication
        [HttpGet]
        //[AllowAnonymous]
        public ActionResult Index()
        {
            //List<Authentication> authList = repo.ShowEmployees();
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            Authentication auth = new Authentication();
            string userName = collection["uname"];
            string password= collection["psw"];

            foreach (var item in db.Authentications)
            {
                if (item.UserName.Equals(userName))
                {
                    if (item.Password.Equals(password))
                    {
                       return View("KuchBHiLIkhDE");
                    }
                }
                
            }
            return RedirectToAction("Index");
        }

        public ActionResult KuchBHiLIkhDE()
        {
            return View();
        }
    }
}