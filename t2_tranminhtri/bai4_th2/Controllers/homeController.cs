using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bai4_th2.Models;

namespace bai4_th2.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /home/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index1()
        {
            var nv = new nhanvien();

            return View();
        }
	}
}