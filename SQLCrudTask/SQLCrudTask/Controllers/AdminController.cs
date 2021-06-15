using System;
using SQLCrudTask.Models;
using SQLCrudTask.Models.Database;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SQLCrudTask.Controllers
{
    public class AdminController : Controller
    {
        Database db = new Database();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            Admins admin = new Admins();
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admins admin)
        {
            if (db.Verify(admin))
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Login");
        }
    }
}