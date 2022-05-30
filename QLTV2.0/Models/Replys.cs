using System;

namespace QLTV2._0.Models
{
    public partial class Replys
    {
        public int IdReply { get; set; }
        public int IdComment { get; set; }
        public string UserName { get; set; }
        public string Content { get; set; }
        public DateTime? Createdat { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int Likes { get; set; }
        public virtual Comments CommentsNavigation { get; set; }
        public virtual Taikhoan TaiKhoanNavigation { get; set; }
    }
}
