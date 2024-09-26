using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using tuan04.Models;
using System.Data.SqlClient;

namespace tuan04.Models
{
    public class ConnectDeparment
    {
        public string constr = System.Configuration.ConfigurationManager.ConnectionStrings["Connect_QL_NhanSu"].ConnectionString;

        public List<Deparment> getData()
        {
            List< Deparment> listDeparment = new List<Deparment>();


            SqlConnection con = new SqlConnection(constr);

            string sql = "select * from tbl_Deparment";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Deparment emp = new Deparment ();
               
                emp.Name = rdr.GetValue(1).ToString();            
                emp.DeptId = Convert.ToInt32(rdr.GetValue(0).ToString());

                listDeparment.Add(emp);

            }
            con.Close();
            return (listDeparment);
        }
        public Deparment Details(string id)
        {
            List< Deparment> listDeparment = new List<Deparment>();


            SqlConnection con = new SqlConnection(constr);

            string sql = "select * from tbl_Deparment";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Deparment emp = new Deparment ();
               
                emp.Name = rdr.GetValue(1).ToString();            
                emp.DeptId = Convert.ToInt32(rdr.GetValue(0).ToString());

                listDeparment.Add(emp);

            }
            
            int ma = int.Parse(id);
            Deparment d = listDeparment.FirstOrDefault(i => i.DeptId == ma);
            return d;
        }
        public int SoNV(string id)
        {
            int ma = int.Parse(id);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = constr;

            string sq1 = "select count(*) from tbl_Employee where DeptId=@MAPB";
            SqlCommand cmd = new SqlCommand(sq1, con);//tao command C1
            cmd.CommandType = CommandType.Text;

            SqlParameter Par = cmd.CreateParameter();
            Par.ParameterName = "@MAPB";
            Par.Value = ma;
            cmd.Parameters.Add(Par);

            con.Open();
            int sl = (int)cmd.ExecuteScalar();
            con.Close();
            return sl;
        }
        public List<Employee> ListEmplByDept(string id)
        {
            List<Employee> listemloyee = new List<Employee>();


            SqlConnection con = new SqlConnection(constr);

            string sql = "select * from tbl_Employee";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Employee emp = new Employee();
                emp.id = Convert.ToInt32(rdr.GetValue(0).ToString());
                emp.Name = rdr.GetValue(1).ToString();
                emp.Gender = rdr.GetValue(2).ToString();
                emp.City = rdr.GetValue(3).ToString();
                emp.DeptId = Convert.ToInt32(rdr.GetValue(4).ToString());

                listemloyee.Add(emp);

            }
            con.Close();
            return (listemloyee);
        }
    }
}
