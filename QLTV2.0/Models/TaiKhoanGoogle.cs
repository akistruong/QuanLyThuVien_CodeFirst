using System;
using System.Collections.Generic;

#nullable disable

namespace QLTV2._0.Models
{
    public partial class TaiKhoanGoogle
    {
        public int Id { get; set; }
        public string IdGoogle { get; set; }
        public int? IdKh { get; set; }

        public virtual KhachHang IdKhNavigation { get; set; }
    }
}
