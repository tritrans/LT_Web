using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tuan_1.Controllers
{
    public class KhoaController : Controller
    {
        //
        // GET: /Khoa/
        public ActionResult Index()
        {
            Models.KhoaModels KhoaCNTT = new Models.KhoaModels();
            KhoaCNTT.Message = "FIT - HUFI: HOC TAP - NANG DONG - SANG TAO";
            return View(KhoaCNTT);
        }
	}
}