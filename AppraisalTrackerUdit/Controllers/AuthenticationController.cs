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
        [AllowAnonymous]
        public ActionResult Index(string returnUrl)
        {
            List<Authentication> authList = repo.ShowEmployees();
            return View(authList);
        }
        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            Authentication auth = new Authentication();
            string userName = collection["uname"];

            //foreach (var item in auth)
            //{

            //}
            


            return View();
        }
    }
}