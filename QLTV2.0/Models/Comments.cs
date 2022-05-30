using System;
using System.Collections.Generic;

namespace QLTV2._0.Models
{
    public partial class Comments
    {
        public Comments()
        {
           
            Replys = new HashSet<Replys>();
        }
        public int IdComment { get; set; }
        public string UserName { get; set; }
        public string Masach { get; set; }
        public string Content { get; set; }
        public DateTime? Createdat { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int Likes { get; set; }
        public virtual Sach SachNavigation { get; set; }
        public virtual Taikhoan TaiKhoanNavigation { get; set; }
        public virtual ICollection<Replys> Replys { get; set; }
    }
}
