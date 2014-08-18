using NinjaTurtlesApp.Web.Adapters;
using NinjaTurtlesApp.Web.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NinjaTurtlesApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private INinjaTurtle _adapter;
        public HomeController()
        {
            _adapter = new TMNTAdapter();
        }
        public ActionResult Index()
        {
            return View(_adapter.GetAllTurtles());
        }
        public ActionResult Details(int id)
        {
            return View(_adapter.GetTurtle(id));
        }
        public ActionResult Create()
        {
            return View(_adapter.GetAllTurtles());
        }
        [HttpPost]
        public ActionResult Create(string name, string color, string description,string pictureLg,string pictureSm, string personality, string weapons)
        {
            _adapter.CreateTurtle(name, color, description, pictureLg, pictureSm, personality, weapons);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            return View(_adapter.GetTurtle(id));
        }
        [HttpPost]
        public ActionResult Edit(int id, string name, string color, string description, string pictureLg, string pictureSm, string personality, string weapons)
        {
            _adapter.EditTurtle(id, name, color, description, pictureLg, pictureSm, personality, weapons);
            return RedirectToAction("Details", new { id });
        }
        public ActionResult Delete(int id)
        {
            _adapter.DeleteTurtle(id);
            return RedirectToAction("Index");
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
    }
}