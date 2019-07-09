using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class HomeController : Controller
    {

        TestContext db = new TestContext();
        public ActionResult Index()
        {
            return View(db.Clients.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Client client)
        {
            db.Clients.Add(client);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        //public ActionResult Index()
        //{
        //    ViewBag.Title = "Home Page";

        //    return View();
        //}
    }
}
