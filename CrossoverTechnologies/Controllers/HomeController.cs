﻿using CrossoverTechnologies.DAL;
using CrossoverTechnologies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrossoverTechnologies.Controllers
{
    public class HomeController : Controller
    {
        private CrossoverDbContext db = new CrossoverDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            Customer customerObj = new Customer();
            customerObj.Name = "Sagar NEW";
            customerObj.Email = "sagar@mail.com";
            db.Customers.Add(customerObj);
            db.SaveChanges();
            return View();
        }

        public ActionResult ListSales()
        {

            return View();
        }
    }
}