using System;
using System.Collections.Generic;

#nullable disable

namespace QLTV2._0.Models
{
    public partial class Theloai
    {
        public Theloai()
        {
            Saches = new HashSet<Sach>();
        }

        public int IdTheloai { get; set; }
        public string Matheloai { get; set; }
        public string Tentheloai { get; set; }

        public virtual ICollection<Sach> Saches { get; set; }
    }
}
