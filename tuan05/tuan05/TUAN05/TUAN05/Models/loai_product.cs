using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TUAN05.Models
{
    public class loai_product
    {
        public int Masp { get; set; }
        public string TenSP { get; set; }
        public string DuongDan { get; set; }
        public double Gia { get; set; }
        public string Mota { get; set; }
        public int Maloai { get; set; }
        public string Tenloai { get; set; }
    }
}