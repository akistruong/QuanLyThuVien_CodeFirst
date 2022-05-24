using System;
using System.Collections.Generic;

#nullable disable

namespace QLTV2._0.Models
{
    public partial class Hoadon
    {
        public Hoadon()
        {
            ChiTietCoupons = new HashSet<ChiTietCoupon>();
            Chitiethoadons = new HashSet<Chitiethoadon>();
        }
        public int IdHoadon { get; set; }
        public DateTime? Createdat { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UserName { get; set; }
        public decimal? TongHoaDon { get; set; }
        public decimal? Phiship { get; set; }
        public decimal? Discount { get; set; }
        public int? Soluong { get; set; }
        public int? Status { get; set; }
        public int? IdKh { get; set; }

        public virtual KhachHang IdKhNavigation { get; set; }
        public virtual Taikhoan UserNameNavigation { get; set; }
        public virtual ICollection<ChiTietCoupon> ChiTietCoupons { get; set; }
        public virtual ICollection<Chitiethoadon> Chitiethoadons { get; set; }
    }
}
