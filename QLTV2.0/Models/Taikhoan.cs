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
            Comments = new HashSet<Comments>();
            Replys = new HashSet<Replys>();
        }

        public int IdTaikhoan { get; set; }
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Salt { get; set; }
        public int? Role { get; set; }
        public int? IdKh { get; set; }
        public string? avatar { get; set; }
        public decimal? phiship { get; set; }
        public virtual KhachHang IdKhNavigation { get; set; }
        public virtual ICollection<Hoadon> Hoadons { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<Replys> Replys { get; set; }
    }
}
