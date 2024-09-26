using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bai4_th2.Models
{
    public class nhanvien
    {
        public int mnv { get; set; }
        public string tennv { get; set; }
        public string gioitinh { get; set; }
        public string hinh { get; set; }

        public nhanvien()
        {
            mnv = 101;
            tennv = "trung";
            gioitinh = "Nam";
            hinh = "hinh01.jpg";

        }

    }
}