using System;
using System.Collections.Generic;

#nullable disable

namespace QLTV2._0.Models
{
    public partial class ChiTietCoupon
    {
        public int IdCtcp { get; set; }
        public string MaCoupon { get; set; }
        public DateTime? Ngaybatdau { get; set; }
        public DateTime? Ngayketthuc { get; set; }
        public int IdHoadon { get; set; }

        public virtual Hoadon IdHoadonNavigation { get; set; }
        public virtual Coupon MaCouponNavigation { get; set; }
    }
}
