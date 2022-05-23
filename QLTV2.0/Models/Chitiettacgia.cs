using System;
using System.Collections.Generic;

#nullable disable

namespace QLTV2._0.Models
{
    public partial class Chitiettacgia
    {
        public string Masach { get; set; }
        public int IdTacgia { get; set; }

        public virtual Tacgia IdTacgiaNavigation { get; set; }
        public virtual Sach MasachNavigation { get; set; }
    }
}
