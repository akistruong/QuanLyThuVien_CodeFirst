using System;
using System.Collections.Generic;

#nullable disable

namespace QLTV2._0.Models
{
    public partial class Chitietsale
    {
        public string Masach { get; set; }
        public string Masale { get; set; }
        public int? Discount { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }

        public virtual Sach MasachNavigation { get; set; }
        public virtual Sale MasaleNavigation { get; set; }
    }
}
