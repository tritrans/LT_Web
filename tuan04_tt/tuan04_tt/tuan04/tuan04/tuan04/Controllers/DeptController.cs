using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tuan04.Models;
using System.Data;
using System.Data.SqlClient;

namespace tuan04.Controllers
{
    public class DeptController : Controller
    {
        //
        // GET: /Dept/
        public ActionResult Index()
        {
            return View();
        }
       public ActionResult ShowDetailsDept1(string id)
        {
            ConnectDeparment obj = new ConnectDeparment();
            Deparment dept = obj.Details(id);
            ViewBag.SNV = obj.SoNV(id);
            return View(dept);
        }
       public ActionResult ShowDDLDept()
       {
           ConnectDeparment obj = new ConnectDeparment();
           List<Deparment> deptlist = obj.getData();
           return View(deptlist);
       }
       public ActionResult ShowlistEmplbyDept(string id)
       {
           ConnectDeparment obj = new ConnectDeparment();
           Deparment dept = obj.Details(id);
           //List<Employee> listemp = obj.l;
           ViewBag.SNV = obj.SoNV(id);
           return View(dept);
       }
	}
}