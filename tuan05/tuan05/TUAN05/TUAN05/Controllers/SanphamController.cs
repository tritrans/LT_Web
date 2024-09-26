using System;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TUAN05.Models;
using System.Data;
using System.Data.SqlClient;

namespace TUAN05.Controllers
{
    public class SanphamController : Controller
    {
        //
        // GET: /Sanpham/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Showproduct()
        {
            connect_Product obj = new connect_Product();
            List<product> empList = obj.getData();
            return View(empList);
        }
        public ActionResult Showproduct01()
        {
            connect_Product obj = new connect_Product();
            List<loai_product> empList = obj.getData1();
            return View(empList);
        }
        public ActionResult Deleteproduct(string id)
        {
            connect_Product obj = new connect_Product();
            obj.delete(id);
            return RedirectToAction("Showproduct01", "Sanpham");
        }
        public ActionResult searchproduct(string txt_search)
        {
            connect_Product obj = new connect_Product();
            List<product> empList = obj.search(txt_search);
            ViewBag.sl = empList.Count();
            return View(empList);
        }
        public ActionResult sortproduct(int DDL_TenSP, int DDl_GiaSP)
        {
            connect_Product obj = new connect_Product();
            List<product> empList = obj.sort(DDL_TenSP,DDl_GiaSP);
            //ViewBag.sl = empList.Count();
            return View(empList);
        }
	}
}