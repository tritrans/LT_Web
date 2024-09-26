using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bai2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult index()
        {
            return View();
        }
        public ActionResult sanpham()
        {
            return View();
        }
        public ActionResult dangnhap()
        {
            return View();
        }
        public ActionResult dangky()
        {
            return View();
        }
	}
}