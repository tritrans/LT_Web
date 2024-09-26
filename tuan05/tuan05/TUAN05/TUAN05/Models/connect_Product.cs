using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using TUAN05.Models;
using System.Data.SqlClient;

namespace TUAN05.Models
{
    public class connect_Product
    {public string constr = System.Configuration.ConfigurationManager.ConnectionStrings["Connect1"].ConnectionString;

        public List<product> getData()
        {
            List<product> listEmloyee = new List<product>();
                     
           
                SqlConnection con = new SqlConnection(constr);

                string sql = "select * from SanPham";
                
                SqlCommand cmd = new  SqlCommand(sql,con);
                cmd.CommandType=CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    product emp = new product();
                    emp. Masp = Convert.ToInt32(rdr.GetValue(0).ToString());
                    emp.TenSP = rdr.GetValue(1).ToString();
                    emp.DuongDan = rdr.GetValue(2).ToString();
                    emp.Gia = Convert.ToDouble(rdr.GetValue(3).ToString());
                    emp.Mota = rdr.GetValue(4).ToString();
                    emp.Maloai = Convert.ToInt32(rdr.GetValue(5).ToString());

                    listEmloyee.Add(emp);

                }
                con.Close();
                return (listEmloyee);
            
        }
        public List<loai_product> getData1()
        {
            List<loai_product> listEmloyee = new List<loai_product>();


            SqlConnection con = new SqlConnection(constr);

            string sql = "SP_GETDATA3TABLE";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                loai_product emp = new loai_product();
                emp.Masp = Convert.ToInt32(rdr.GetValue(0).ToString());
                emp.TenSP = rdr.GetValue(1).ToString();
                emp.DuongDan = rdr.GetValue(2).ToString();
                emp.Gia = Convert.ToDouble(rdr.GetValue(3).ToString());
                emp.Mota = rdr.GetValue(4).ToString();
                emp.Maloai = Convert.ToInt32(rdr.GetValue(5).ToString());
                emp.Tenloai = rdr.GetValue(6).ToString();
                listEmloyee.Add(emp);

            }
            con.Close();
            return (listEmloyee);
        }
        public int delete(string id)
        {
            int ma = int.Parse(id);
            SqlConnection con = new SqlConnection(constr);
            int kt = 0;
            con.Open();
            string sql = "delete from SanPham where MaSP=@masp";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlParameter par = new SqlParameter("@masp", ma);
            cmd.Parameters.Add(par);
            kt = cmd.ExecuteNonQuery();
            con.Close();
            return kt;
        }
        public List<product> search(string txt_search)
        {
            List<product> listEmloyee = new List<product>();


            SqlConnection con = new SqlConnection(constr);

            string sql = "select * from SanPham where TenSP like '%' + @ten+'%'";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlParameter par = new SqlParameter("@ten", txt_search);
            cmd.Parameters.Add(par);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                product emp = new product();
                emp.Masp = Convert.ToInt32(rdr.GetValue(0).ToString());
                emp.TenSP = rdr.GetValue(1).ToString();
                emp.DuongDan = rdr.GetValue(2).ToString();
                emp.Gia = Convert.ToDouble(rdr.GetValue(3).ToString());
                emp.Mota = rdr.GetValue(4).ToString();
                emp.Maloai = Convert.ToInt32(rdr.GetValue(5).ToString());

                listEmloyee.Add(emp);

            }
            con.Close();
            return (listEmloyee);

        }
        public List<product> sort(int DDL_TenSP, int DDl_GiaSP)
        {
            List<product> listEmloyee = new List<product>();


            SqlConnection con = new SqlConnection(constr);

            string sql = "";
            if (DDL_TenSP == 0 && DDl_GiaSP == 0)
            {
                sql = "select* from SanPham";
            }
            if (DDL_TenSP == 1 && DDl_GiaSP == 0)
            {
                sql = "select* from SanPham order by TenSP ASC";
            }
            if (DDL_TenSP == 2 && DDl_GiaSP == 0)
            {
                sql = "select* from SanPham order by TenSP DESC";
            }
            if (DDL_TenSP == 0 && DDl_GiaSP == 1)
            {
                sql = "select* from SanPham order by Gia ASC";
            }
            if (DDL_TenSP == 0 && DDl_GiaSP == 2)
            {
                sql = "select* from SanPham order by Gia DESC";
            }

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;       
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                product emp = new product();
                emp.Masp = Convert.ToInt32(rdr.GetValue(0).ToString());
                emp.TenSP = rdr.GetValue(1).ToString();
                emp.DuongDan = rdr.GetValue(2).ToString();
                emp.Gia = Convert.ToDouble(rdr.GetValue(3).ToString());
                emp.Mota = rdr.GetValue(4).ToString();
                emp.Maloai = Convert.ToInt32(rdr.GetValue(5).ToString());

                listEmloyee.Add(emp);

            }
            con.Close();
            return (listEmloyee);

        }
        }
    }
