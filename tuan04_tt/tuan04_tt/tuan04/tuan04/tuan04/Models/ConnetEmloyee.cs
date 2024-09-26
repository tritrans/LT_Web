using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using tuan04.Models;
using System.Data.SqlClient;

namespace tuan04.Models
{
    public class ConnetEmloyee
    {
        public string constr = System.Configuration.ConfigurationManager.ConnectionStrings["Connect_QL_NhanSu"].ConnectionString;

        public List<Employee> getData()
        {
            List<Employee> listEmloyee = new List<Employee>();
                     
           
                SqlConnection con = new SqlConnection(constr); 
                
                string sql = "select * from tbl_Employee";
                
                SqlCommand cmd = new  SqlCommand(sql,con);
                cmd.CommandType=CommandType.Text;
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

                    listEmloyee.Add(emp);

                }
                con.Close();
                return (listEmloyee);
            
            
               
            
           
        }
        public int getSl()
        {
            SqlConnection con = new SqlConnection(constr); 
                
                string sql = "select count(*) from tbl_Employee";
                
                SqlCommand cmd = new  SqlCommand(sql,con);
                cmd.CommandType=CommandType.Text;
                con.Open();
                int sl = (int)cmd.ExecuteScalar();
                con.Close();
                return sl;
        }
        public int insertEmloyee(string name, string gender, string city, int deptID)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            int rs = 0;
            string sql1 = "select count(*) from tbl_Employee where Name='" + name + "'";
            SqlCommand cmd1 = new SqlCommand(sql1, con);
            int kt = (int)cmd1.ExecuteScalar();
            if (kt == 0)
            {
                string sql = "insert into tbl_Employee (Name,Gender,City,DeptID)";
                sql += "values(N'" + name + "',N'" + gender + "',N'" + city + "','" + deptID + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                rs = cmd.ExecuteNonQuery();
            }
            con.Close();
            return rs;
        }
    }


    }


