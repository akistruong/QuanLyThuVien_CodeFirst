using System;
using System.Collections.Generic;

#nullable disable

namespace QLTV2._0.Models
{
    public partial class Hinhanh
    {
        public int IdAnh { get; set; }
        public string Masach { get; set; }
        public string Url { get; set; }

        public virtual Sach MasachNavigation { get; set; }
    }
}
