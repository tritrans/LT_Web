using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tuan_1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
        public string Index1(string id, string name)
        {
            return "ID=" + id + "Name=" + name;
        }
        public string Index2()
        {
            return "ID=" + Request.QueryString["id"] + "Name=" + Request.QueryString["name"];
        }
        public ActionResult Index3()
        {
            ViewBag.id = Request.QueryString["id"];
            ViewBag.name = Request.QueryString["name"];
            return View();
        }
	}
}