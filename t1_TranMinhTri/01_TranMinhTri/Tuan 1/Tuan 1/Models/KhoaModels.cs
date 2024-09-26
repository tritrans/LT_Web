using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tuan_1.Models
{
    public class KhoaModels
    {
        public string TenKhoa{get;set;}
        public int NamThanhLap { get; set; }
        public string Message { get; set; }

        public KhoaModels()
        {
            TenKhoa = "Khoa CNTT";
                NamThanhLap=2003;
                Message = "Chao mung cac ban den voi HUFI";
        }

    }
}