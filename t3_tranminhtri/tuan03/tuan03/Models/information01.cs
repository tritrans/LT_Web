using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace tuan03.Models
{
    public class information01
    {
        [Required()]
        [StringLength(50)]
        public string fullname { get; set; }
        [Required()]
        [StringLength(10,ErrorMessage ="Nhập ID không quá 10 ký số")]

        public string idstuident { get; set; }
        [Required(ErrorMessage ="Bắt buộc nhập Email Address!")]
        [EmailAddress(ErrorMessage ="Địa chỉ Email không hợp lệ")]
        public string email { get; set; }
        public string fileimage { get; set; }
        public string note { get; set; }
        public bool check1 { get; set; }
        public bool check2 { get; set; }
        public bool check3 { get; set; }
        public string chooseworktime { get; set; }
        [Required()]
        public int  selectcourse { get; set; }
    }
}