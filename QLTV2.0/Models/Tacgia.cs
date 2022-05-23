using System;
using System.Collections.Generic;

#nullable disable

namespace QLTV2._0.Models
{
    public partial class Tacgia
    {
        public Tacgia()
        {
            Chitiettacgia = new HashSet<Chitiettacgia>();
        }

        public int IdTacgia { get; set; }
        public string Tentacgia { get; set; }

        public virtual ICollection<Chitiettacgia> Chitiettacgia { get; set; }
    }
}
