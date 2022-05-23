using System;
using System.Collections.Generic;

#nullable disable

namespace QLTV2._0.Models
{
    public partial class Phieunhap
    {
        public Phieunhap()
        {
            Saches = new HashSet<Sach>();
        }

        public int IdPhieunhap { get; set; }
        public string Maphieunhap { get; set; }
        public int? Soluongnhap { get; set; }
        public decimal? Gianhap { get; set; }
        public DateTime? Createdat { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<Sach> Saches { get; set; }
    }
}
