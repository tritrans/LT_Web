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
        public int getSl()
        {
            SqlConnection con = new SqlConnection(constr);

            string sql = "select count(*) from tbl_Deparment";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            int sl = (int)cmd.ExecuteScalar();
            con.Close();
            return sl;
        }
    }
}
