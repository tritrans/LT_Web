using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace t2_tranminhtri.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /home/
        public ActionResult about()
        {
            return View();
        }
        public ActionResult home()
        {
            return View();
        }
        public ActionResult service()
        {
            return View();
        }
        public ActionResult support()
        {
            return View();
        }
        public ActionResult contact()
        {
            return View();
        }
	}
}