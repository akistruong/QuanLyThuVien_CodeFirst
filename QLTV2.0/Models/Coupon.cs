using System;
using System.Collections.Generic;

#nullable disable

namespace QLTV2._0.Models
{
    public partial class Coupon
    {
        public Coupon()
        {
            ChiTietCoupons = new HashSet<ChiTietCoupon>();
        }

        public int IdCoupon { get; set; }
        public string MaCoupon { get; set; }
        public int Giamgia { get; set; }
        public int? Soluong { get; set; }
        public int? Thoigianhieuluc { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdateAt { get; set; }

        public virtual ICollection<ChiTietCoupon> ChiTietCoupons { get; set; }
    }
}
