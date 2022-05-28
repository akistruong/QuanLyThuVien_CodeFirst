using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace QLTV2._0.Models
{
    public partial class Taikhoan
    {
        public Taikhoan()
        {
            Hoadons = new HashSet<Hoadon>();
        }

        public int IdTaikhoan { get; set; }
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Salt { get; set; }
        public int? Role { get; set; }
        public int? IdKh { get; set; }
        public decimal? phiship { get; set; }
        public virtual KhachHang IdKhNavigation { get; set; }
        public virtual ICollection<Hoadon> Hoadons { get; set; }
    }
}
