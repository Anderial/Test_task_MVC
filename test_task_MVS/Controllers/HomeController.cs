using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test_task_MVS.Models;

namespace test_task_MVS.Controllers
{
    public class HomeController : Controller
    {
        DataContext dataBase = new DataContext();

        public ActionResult Index()
        {
            return View(dataBase.Lists);
        }
        
        public ActionResult Details_list(int? id)
        {
            ListModel List = dataBase.Lists.Find(id);
            if (List == null)
            {
                return HttpNotFound();
            }
            return View(List);
        }

        public ActionResult Add_candidat()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add_candidat(ListModel Lists)
        {
            if (ModelState.IsValid)
            {
                dataBase.Lists.Add(Lists);
                dataBase.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Lists);
        }
    }
}