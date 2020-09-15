using CrossoverTechnologies.DAL;
using CrossoverTechnologies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CrossoverTechnologies.Controllers
{
    public class AccountController : Controller
    {
        private CrossoverDbContext db = new CrossoverDbContext();

        // GET: Account
        [AllowAnonymous]
        public ActionResult Index(object selectedItemFor = null)
        {
            var customerQuery = from d in db.Customers
                               select d;
            ViewBag.CustomerID = new SelectList(customerQuery, "CustomerID", "Name", selectedItemFor);


            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Customer customerObj)
        {
            using (db)
            {
                var usr = db.Customers.Where(u => u.CustomerID == customerObj.CustomerID).FirstOrDefault();
                if (usr != null)
                {
                    FormsAuthentication.SetAuthCookie(usr.CustomerID.ToString(), false);
                    return RedirectToAction("Index", "Home");

                }
                else
                {
                    ModelState.AddModelError("LoginError", "Username or Password is Incorrect.");
                    return View();
                }
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}