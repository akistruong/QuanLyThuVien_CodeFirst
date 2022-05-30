using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace QLTV2._0.Models
{
    public partial class Sach
    {
        public Sach()
        {
            Chitiethoadons = new HashSet<Chitiethoadon>();
            Chitietsales = new HashSet<Chitietsale>();
            Chitiettacgia = new HashSet<Chitiettacgia>();
            Hinhanhs = new HashSet<Hinhanh>();
            Comments = new HashSet<Comments>();
        }

        public int IdSach { get; set; }
        public string Masach { get; set; }
        [Required]
        public string Manxb { get; set; }
        [Required]
        public string Maphieunhap { get; set; }
        [Required]
        public string Matheloai { get; set; }
        public string Tensach { get; set; }
        public decimal? Giaban { get; set; }
        public string Img { get; set; }
        public int? Slton { get; set; }
        public DateTime? Createdat { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Mota { get; set; }

        public virtual Nxb ManxbNavigation { get; set; }
        public virtual Phieunhap MaphieunhapNavigation { get; set; }
        public virtual Theloai MatheloaiNavigation { get; set; }
        public virtual ICollection<Chitiethoadon> Chitiethoadons { get; set; }
        public virtual ICollection<Chitietsale> Chitietsales { get; set; }
        public virtual ICollection<Chitiettacgia> Chitiettacgia { get; set; }
        public virtual ICollection<Hinhanh> Hinhanhs { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
    }
}
