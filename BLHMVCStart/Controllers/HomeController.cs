using BLHMVCStart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BLHMVCStart.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult EnterUserData()
        {
            return View("EnterUserData");
        }

        [HttpPost]
        public ActionResult ShowUserData(string Firstname, string Lastname, string EmailAddress, string DateOfBirth)
        {
            var mdl = new UserDataModel();
            mdl.FirstName = Firstname;
            mdl.LastName = Lastname;
            mdl.EmailAddress = EmailAddress;
            mdl.DateOfBirth = DateOfBirth;
            return View(mdl);
        }
    }
}