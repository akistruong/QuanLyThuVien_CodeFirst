using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace QLTV2._0.Models
{
    public partial class QuanLyThuVien30Context : DbContext
    {
        IConfiguration _configuration { get; }
        public QuanLyThuVien30Context(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public QuanLyThuVien30Context(DbContextOptions<QuanLyThuVien30Context> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietCoupon> ChiTietCoupons { get; set; }
        public virtual DbSet<Chitiethoadon> Chitiethoadons { get; set; }
        public virtual DbSet<Chitietsale> Chitietsales { get; set; }
        public virtual DbSet<Chitiettacgia> Chitiettacgia { get; set; }
        public virtual DbSet<Coupon> Coupons { get; set; }
        public virtual DbSet<Hinhanh> Hinhanhs { get; set; }
        public virtual DbSet<Hoadon> Hoadons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Nxb> Nxbs { get; set; }
        public virtual DbSet<Phieunhap> Phieunhaps { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Tacgia> Tacgia { get; set; }
        public virtual DbSet<TaiKhoanGoogle> TaiKhoanGoogles { get; set; }
        public virtual DbSet<Taikhoan> Taikhoans { get; set; }
        public virtual DbSet<Theloai> Theloais { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationSection ConnectStringsSection = _configuration.GetSection("ConnectStrings");
                optionsBuilder.UseSqlServer(ConnectStringsSection["SqlString"]);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ChiTietCoupon>(entity =>
            {
                entity.HasKey(e => new { e.MaCoupon, e.IdHoadon })
                    .HasName("pk_ctcp");

                entity.ToTable("ChiTietCoupon");

                entity.Property(e => e.MaCoupon)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IdHoadon).HasColumnName("ID_HOADON");

                entity.Property(e => e.IdCtcp)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_ctcp");

                entity.Property(e => e.Ngaybatdau)
                    .HasColumnType("date")
                    .HasColumnName("ngaybatdau");

                entity.Property(e => e.Ngayketthuc)
                    .HasColumnType("date")
                    .HasColumnName("ngayketthuc");

                entity.HasOne(d => d.IdHoadonNavigation)
                    .WithMany(p => p.ChiTietCoupons)
                    .HasForeignKey(d => d.IdHoadon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ctcp_hoadon");

                entity.HasOne(d => d.MaCouponNavigation)
                    .WithMany(p => p.ChiTietCoupons)
                    .HasForeignKey(d => d.MaCoupon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ctcp_coupon");
            });

            modelBuilder.Entity<Chitiethoadon>(entity =>
            {
                entity.HasKey(e => new { e.Masach, e.IdHoadon })
                    .HasName("pk_cthd");

                entity.ToTable("CHITIETHOADON");

                entity.Property(e => e.Masach)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MASACH")
                    .IsFixedLength(true);

                entity.Property(e => e.IdHoadon).HasColumnName("ID_HOADON");

                entity.Property(e => e.Dongia)
                    .HasColumnType("money")
                    .HasColumnName("DONGIA");

                entity.Property(e => e.IdCthd)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_cthd");

                entity.Property(e => e.Slmua).HasColumnName("SLMUA");

                entity.Property(e => e.Thanhtien)
                    .HasColumnType("money")
                    .HasColumnName("THANHTIEN");

                entity.HasOne(d => d.IdHoadonNavigation)
                    .WithMany(p => p.Chitiethoadons)
                    .HasForeignKey(d => d.IdHoadon)
                    .HasConstraintName("FK_cthd_idHoadon");

                entity.HasOne(d => d.MasachNavigation)
                    .WithMany(p => p.Chitiethoadons)
                    .HasForeignKey(d => d.Masach).OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_cthd_MASACH");
            });

            modelBuilder.Entity<Chitietsale>(entity =>
            {
                entity.HasKey(e => new { e.Masach, e.Masale });

                entity.ToTable("CHITIETSALE");

                entity.Property(e => e.Masach)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MASACH")
                    .IsFixedLength(true);

                entity.Property(e => e.Masale)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MASALE")
                    .IsFixedLength(true);

                entity.Property(e => e.Discount)
                    .HasColumnName("DISCOUNT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NgayBatDau)
                    .HasColumnType("date")
                    .HasColumnName("NGAY_BAT_DAU");

                entity.Property(e => e.NgayKetThuc)
                    .HasColumnType("date")
                    .HasColumnName("NGAY_KET_THUC");

                entity.HasOne(d => d.MasachNavigation)
                    .WithMany(p => p.Chitietsales)
                    .HasForeignKey(d => d.Masach)
                    .HasConstraintName("FK_cts_Sach");

                entity.HasOne(d => d.MasaleNavigation)
                    .WithMany(p => p.Chitietsales)
                    .HasForeignKey(d => d.Masale)
                    .HasConstraintName("FK_cts_sale");
            });

            modelBuilder.Entity<Chitiettacgia>(entity =>
            {
                entity.HasKey(e => new { e.Masach, e.IdTacgia });

                entity.ToTable("CHITIETTACGIA");

                entity.Property(e => e.Masach)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MASACH")
                    .IsFixedLength(true);

                entity.Property(e => e.IdTacgia).HasColumnName("ID_TACGIA");

                entity.HasOne(d => d.IdTacgiaNavigation)
                    .WithMany(p => p.Chitiettacgia)
                    .HasForeignKey(d => d.IdTacgia)
                    .HasConstraintName("fk_cttg_tacgia");

                entity.HasOne(d => d.MasachNavigation)
                    .WithMany(p => p.Chitiettacgia)
                    .HasForeignKey(d => d.Masach)
                    .HasConstraintName("fk_cttg_masach");
            });

            modelBuilder.Entity<Coupon>(entity =>
            {
                entity.HasKey(e => e.MaCoupon)
                    .HasName("pk_coupon");

                entity.ToTable("Coupon");

                entity.Property(e => e.MaCoupon)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("createdAt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Giamgia).HasColumnName("giamgia");

                entity.Property(e => e.IdCoupon)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_coupon");

                entity.Property(e => e.Soluong).HasDefaultValueSql("((0))");

                entity.Property(e => e.Thoigianhieuluc).HasColumnName("thoigianhieuluc");

                entity.Property(e => e.UpdateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updateAt")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Hinhanh>(entity =>
            {
                entity.HasKey(e => e.IdAnh);

                entity.ToTable("HINHANH");

                entity.Property(e => e.IdAnh).HasColumnName("ID_ANH");

                entity.Property(e => e.Masach)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MASACH")
                    .IsFixedLength(true);

                entity.Property(e => e.Url)
                    .HasColumnType("text")
                    .HasColumnName("url");

                entity.HasOne(d => d.MasachNavigation)
                    .WithMany(p => p.Hinhanhs)
                    .HasForeignKey(d => d.Masach)
                    .HasConstraintName("FK_SACH");
            });

            modelBuilder.Entity<Hoadon>(entity =>
            {
                entity.HasKey(e => e.IdHoadon)
                    .HasName("pk_hoadon");

                entity.ToTable("HOADON");

                entity.Property(e => e.IdHoadon).HasColumnName("ID_HOADON");

                entity.Property(e => e.Createdat)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDAT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Discount)
                    .HasColumnType("money")
                    .HasColumnName("discount");

                entity.Property(e => e.IdKh).HasColumnName("id_kh");

                entity.Property(e => e.Phiship)
                    .HasColumnType("money")
                    .HasColumnName("phiship");

                entity.Property(e => e.Soluong).HasColumnName("soluong");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TongHoaDon).HasColumnType("money");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserName)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("USER_NAME")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdKhNavigation)
                    .WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.IdKh)
                    .HasConstraintName("fk_kh");

                entity.HasOne(d => d.UserNameNavigation)
                    .WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.UserName)
                    .HasConstraintName("fk_user");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.IdKh)
                    .HasName("pk_kh");

                entity.ToTable("KhachHang");

                entity.Property(e => e.IdKh).HasColumnName("id_kh");

                entity.Property(e => e.DiaChi).HasColumnType("ntext");

                entity.Property(e => e.Gioitinh).HasColumnName("gioitinh");

                entity.Property(e => e.Ngaysinh)
                    .HasColumnType("date")
                    .HasColumnName("ngaysinh");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TenKhachHang)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Nxb>(entity =>
            {
                entity.HasKey(e => e.Manxb)
                    .IsClustered(false);

                entity.ToTable("NXB");

                entity.Property(e => e.Manxb)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MANXB")
                    .IsFixedLength(true);

                entity.Property(e => e.Diachi)
                    .HasColumnType("text")
                    .HasColumnName("DIACHI");

                entity.Property(e => e.IdNxb)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_NXB");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SDT")
                    .IsFixedLength(true);

                entity.Property(e => e.Tennxb)
                    .HasMaxLength(50)
                    .HasColumnName("TENNXB");
            });

            modelBuilder.Entity<Phieunhap>(entity =>
            {
                entity.HasKey(e => e.Maphieunhap)
                    .IsClustered(false);

                entity.ToTable("PHIEUNHAP");

                entity.Property(e => e.Maphieunhap)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MAPHIEUNHAP")
                    .IsFixedLength(true);

                entity.Property(e => e.Createdat)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDAT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Gianhap)
                    .HasColumnType("money")
                    .HasColumnName("GIANHAP");

                entity.Property(e => e.IdPhieunhap)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_PHIEUNHAP");

                entity.Property(e => e.Soluongnhap).HasColumnName("SOLUONGNHAP");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Sach>(entity =>
            {
                entity.HasKey(e => e.Masach)
                    .IsClustered(false);

                entity.ToTable("SACH");

                entity.Property(e => e.Masach)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MASACH")
                    .IsFixedLength(true);

                entity.Property(e => e.Createdat)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDAT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Giaban)
                    .HasColumnType("money")
                    .HasColumnName("GIABAN");

                entity.Property(e => e.IdSach)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_SACH").Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);

                entity.Property(e => e.Img)
                    .HasColumnType("text")
                    .HasColumnName("IMG");

                entity.Property(e => e.Manxb)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MANXB")
                    .IsFixedLength(true);

                entity.Property(e => e.Maphieunhap)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MAPHIEUNHAP")
                    .IsFixedLength(true);

                entity.Property(e => e.Matheloai)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MATHELOAI")
                    .IsFixedLength(true);

                entity.Property(e => e.Mota).HasColumnType("ntext");

                entity.Property(e => e.Slton).HasColumnName("SLTON");

                entity.Property(e => e.Tensach)
                    .HasMaxLength(50)
                    .HasColumnName("TENSACH");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ManxbNavigation)
                    .WithMany(p => p.Saches)
                    .HasForeignKey(d => d.Manxb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_nxb");

                entity.HasOne(d => d.MaphieunhapNavigation)
                    .WithMany(p => p.Saches)
                    .HasForeignKey(d => d.Maphieunhap)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_sach_phieunhap");

                entity.HasOne(d => d.MatheloaiNavigation)
                    .WithMany(p => p.Saches)
                    .HasForeignKey(d => d.Matheloai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_theloai");
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.HasKey(e => e.Masale)
                    .IsClustered(false);

                entity.ToTable("SALE");

                entity.Property(e => e.Masale)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MASALE")
                    .IsFixedLength(true);

                entity.Property(e => e.Createdat)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDAT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdSale)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_SALE");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Tacgia>(entity =>
            {
                entity.HasKey(e => e.IdTacgia)
                    .IsClustered(false);

                entity.ToTable("TACGIA");

                entity.Property(e => e.IdTacgia).HasColumnName("ID_TACGIA");

                entity.Property(e => e.Tentacgia)
                    .HasMaxLength(30)
                    .HasColumnName("TENTACGIA");
            });

            modelBuilder.Entity<TaiKhoanGoogle>(entity =>
            {
                entity.HasKey(e => e.IdGoogle)
                    .HasName("PK__TaiKhoan__26387A7E113CA94B");

                entity.ToTable("TaiKhoanGoogle");

                entity.Property(e => e.IdGoogle)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("id_google")
                    .IsFixedLength(true);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.IdKh).HasColumnName("id_kh");

                entity.HasOne(d => d.IdKhNavigation)
                    .WithMany(p => p.TaiKhoanGoogles)
                    .HasForeignKey(d => d.IdKh)
                    .HasConstraintName("fk_google");
            });

            modelBuilder.Entity<Taikhoan>(entity =>
            {
                entity.HasKey(e => e.UserName)
                    .IsClustered(false);

                entity.ToTable("TAIKHOAN");
                entity.Property(e => e.phiship).HasColumnName("PhiShip").HasColumnType("money");
                entity.Property(e => e.UserName)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("USER_NAME")
                    .IsFixedLength(true);

                entity.Property(e => e.IdKh).HasColumnName("id_kh");

                entity.Property(e => e.IdTaikhoan)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_TAIKHOAN");

                entity.Property(e => e.Password)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD")
                    .IsFixedLength(true);

                entity.Property(e => e.Salt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SALT")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdKhNavigation)
                    .WithMany(p => p.Taikhoans)
                    .HasForeignKey(d => d.IdKh)
                    .HasConstraintName("fk_tk");
            });

            modelBuilder.Entity<Theloai>(entity =>
            {
                entity.HasKey(e => e.Matheloai)
                    .IsClustered(false);

                entity.ToTable("THELOAI");

                entity.Property(e => e.Matheloai)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MATHELOAI")
                    .IsFixedLength(true);

                entity.Property(e => e.IdTheloai)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_THELOAI").Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);

                entity.Property(e => e.Tentheloai)
                    .HasMaxLength(30)
                    .HasColumnName("TENTHELOAI");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
