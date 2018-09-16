using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodavatarMvc.Models;

namespace CodavatarMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "New project created.";
            ViewBag.NewMsg = "This is a brand new message";
            HomeModel Model = new HomeModel { Id  = "4", Name = "Dragon"};
            ViewBag.Model = Model;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}