using System;
using System.Collections.Generic;

#nullable disable

namespace QLTV2._0.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            Hoadons = new HashSet<Hoadon>();
            Taikhoans = new HashSet<Taikhoan>();
        }

        public int IdKh { get; set; }
        public string TenKhachHang { get; set; }
        public bool? Gioitinh { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Hoadon> Hoadons { get; set; }
        public virtual ICollection<Taikhoan> Taikhoans { get; set; }
    }
}
