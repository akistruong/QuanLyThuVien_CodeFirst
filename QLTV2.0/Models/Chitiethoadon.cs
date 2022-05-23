using System;
using System.Collections.Generic;

#nullable disable

namespace QLTV2._0.Models
{
    public partial class Chitiethoadon
    {
        public string Masach { get; set; }
        public int? Slmua { get; set; }
        public decimal? Thanhtien { get; set; }
        public int IdHoadon { get; set; }
        public decimal? Dongia { get; set; }
        public int IdCthd { get; set; }

        public virtual Hoadon IdHoadonNavigation { get; set; }
        public virtual Sach MasachNavigation { get; set; }
    }
}
