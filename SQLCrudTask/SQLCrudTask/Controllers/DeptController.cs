using System;
using SQLCrudTask.Models;
using SQLCrudTask.Models.Database;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SQLCrudTask.Controllers
{
    public class DeptController : Controller
    {
        // GET: Dept
        /*public ActionResult Index()
        {
            Database db = new Database();
            var depts = db.Depts.GetAll();
            return View(depts);
        }
        public ActionResult Add()
        {
            Dept d = new Dept();
            return View(d);
        }
        [HttpPost]
        public ActionResult Add(Dept d)
        {
            if(ModelState.IsValid)
            {
                Database db = new Database();
                db.Depts.Insert(d);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(Dept d)
        {
            Databse db = new Databse();
            db.Depts.Update(d);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            Database db = new Database();
            db.Depts.Delete(id);
            return RedirectToAction("Index");
        }*/
    }
}