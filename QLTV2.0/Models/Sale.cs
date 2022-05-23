using System;
using System.Collections.Generic;

#nullable disable

namespace QLTV2._0.Models
{
    public partial class Sale
    {
        public Sale()
        {
            Chitietsales = new HashSet<Chitietsale>();
        }

        public int IdSale { get; set; }
        public string Masale { get; set; }
        public DateTime? Createdat { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<Chitietsale> Chitietsales { get; set; }
    }
}
