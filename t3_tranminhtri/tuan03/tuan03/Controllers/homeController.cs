using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tuan03.Models;

namespace tuan03.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /home/
        public ActionResult Index()
        {
           
            return View();
        }
        public ActionResult MH_xacnhan()
        {

            return View();
        }
         [HttpPost]
        public ActionResult Index(string txt_fullname, string txt_id, string txt_email, string txt_fileimage, string txt_note, string txt_check1, string txt_check2, string txt_check3, string txt_chooseworktime, string txt_selectcourse)
        {
            Session["info"] = new information() { fulname = txt_fullname, idstuident = txt_id, email = txt_email, fileimage = txt_fileimage, note = txt_note, check1 = txt_check1, check2 = txt_check2, check3 = txt_check3, chooseworktime = txt_chooseworktime, selectcourse = txt_selectcourse };
            return RedirectToAction("MH_xacnhan", "home");
           
        }
        // [HttpPost]
        //public ActionResult index_dataAnnottion(information01 inf)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Session["info"] = new information01() { fulname = inf.fulname, idstuident = inf.idstuident, email = inf.email, fileimage = inf.fileimage, note = inf.note, check1 = inf.check1, check2 = inf.check2, check3 = inf.check3, chooseworktime = inf.chooseworktime, selectcourse = inf.selectcourse };
        //        return RedirectToAction("MH_xacnhan", "home");
        //    }
        //    else
        //    {
        ////        return View();
        //    }
    
           
        //}


         //public ActionResult index_dataAnnottion()
         //{

         //    return View();
         //}
	}
}