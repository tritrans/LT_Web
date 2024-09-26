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
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult ShowEmloyees()
        {
            List<Employee> listEmloyee = new List<Employee>();
            string constr = "Data Source=MTRI-PC/SQLEXPRESS;Initial Catalog=QL_NhanSu;Integrated Security=True";
            SqlConnection con = new SqlConnection(constr);
            con.ConnectionString = constr;
            try
            {
                con.Open();
                string sql = "select * from tbl_Employee";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    var emp = new Employee();
                    emp.id = (int)row["id"];
                    emp.Name = row["Name"].ToString();
                    emp.Gender = row["Gender"].ToString();
                    emp.City = row["City"].ToString();
                    emp.DeptId = (int)row["DeptId"];

                    listEmloyee.Add(emp);

                }
                return View(listEmloyee);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
            finally
            {
                con.Close();
            }

        }
        public ActionResult Error()
        {
            return View();
        }
        public ActionResult ShowEmloyee()
        {
            ConnetEmloyee obj = new ConnetEmloyee();
            List<Employee> empList = obj.getData();
            ViewBag.sl = obj.getSl();
            return View(empList);
        }

        //=============================================//

        public ActionResult ShowDeparment01()
        {
            List<Deparment> listDeparment = new List<Deparment>();
            string constr = "Data Source=A210PC06;Initial Catalog=QL_NhanSu;Integrated Security=True";
            SqlConnection con = new SqlConnection(constr);
            con.ConnectionString = constr;
            try
            {
                con.Open();
                string sql = "select * from tbl_Deparment";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    var ep = new Deparment();
                  
                    ep.Name = row["Name"].ToString();
                   
                    ep.DeptId = (int)row["DeptId"];

                    listDeparment.Add(ep);

                }
                return View(listDeparment);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
            finally
            {
                con.Close();
            }

        }
        public ActionResult ShowDeparment()
        {
            ConnectDeparment obj = new ConnectDeparment();
            List<Deparment> empList = obj.getData();        
            return View(empList);
        }
        public ActionResult ShowDetailsDept(string id)
        {
            ConnectDeparment obj = new ConnectDeparment();
            Deparment dept = obj.Details(id);
            ViewBag.SNV = obj.SoNV(id);
            return View(dept);
        }
        public ActionResult CreateEmloyyee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateEmloyyee(FormCollection fc)
        {
            ConnetEmloyee obj =new ConnetEmloyee();
            var name = fc["FullName"];
            var gender = fc["Gender"];
            var city = fc["City"];
            var deptID = int.Parse( fc["DeptID"]);

            int kt = obj.insertEmloyee(name, gender, city, deptID);
            if (kt == 1)
            {
                ViewBag.ThongBao = "Thêm thành công";
            }
            else
            {
                ViewBag.ThongBao = "Thêm không thành công";
            }
            return View();
        }
    }
}