using System;
using System.Collections.Generic;

#nullable disable

namespace QLTV2._0.Models
{
    public partial class Nxb
    {
        public Nxb()
        {
            Saches = new HashSet<Sach>();
        }

        public int IdNxb { get; set; }
        public string Diachi { get; set; }
        public string Sdt { get; set; }
        public string Manxb { get; set; }
        public string Tennxb { get; set; }

        public virtual ICollection<Sach> Saches { get; set; }
    }
}
