﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QLTV2._0.Models;

namespace QLTV2._0.Migrations
{
    [DbContext(typeof(QuanLyThuVien30Context))]
    [Migration("20220520005805_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QLTV2._0.Models.ChiTietCoupon", b =>
                {
                    b.Property<string>("MaCoupon")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength(true);

                    b.Property<int>("IdHoadon")
                        .HasColumnType("int")
                        .HasColumnName("ID_HOADON");

                    b.Property<int>("IdCtcp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_ctcp")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Ngaybatdau")
                        .HasColumnType("date")
                        .HasColumnName("ngaybatdau");

                    b.Property<DateTime?>("Ngayketthuc")
                        .HasColumnType("date")
                        .HasColumnName("ngayketthuc");

                    b.HasKey("MaCoupon", "IdHoadon")
                        .HasName("pk_ctcp");

                    b.HasIndex("IdHoadon");

                    b.ToTable("ChiTietCoupon");
                });

            modelBuilder.Entity("QLTV2._0.Models.Chitiethoadon", b =>
                {
                    b.Property<string>("Masach")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .HasColumnName("MASACH")
                        .IsFixedLength(true);

                    b.Property<int>("IdHoadon")
                        .HasColumnType("int")
                        .HasColumnName("ID_HOADON");

                    b.Property<decimal?>("Dongia")
                        .HasColumnType("money")
                        .HasColumnName("DONGIA");

                    b.Property<int>("IdCthd")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_cthd")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Slmua")
                        .HasColumnType("int")
                        .HasColumnName("SLMUA");

                    b.Property<decimal?>("Thanhtien")
                        .HasColumnType("money")
                        .HasColumnName("THANHTIEN");

                    b.HasKey("Masach", "IdHoadon")
                        .HasName("pk_cthd");

                    b.HasIndex("IdHoadon");

                    b.ToTable("CHITIETHOADON");
                });

            modelBuilder.Entity("QLTV2._0.Models.Chitietsale", b =>
                {
                    b.Property<string>("Masach")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .HasColumnName("MASACH")
                        .IsFixedLength(true);

                    b.Property<string>("Masale")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .HasColumnName("MASALE")
                        .IsFixedLength(true);

                    b.Property<int?>("Discount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("DISCOUNT")
                        .HasDefaultValueSql("((0))");

                    b.Property<DateTime?>("NgayBatDau")
                        .HasColumnType("date")
                        .HasColumnName("NGAY_BAT_DAU");

                    b.Property<DateTime?>("NgayKetThuc")
                        .HasColumnType("date")
                        .HasColumnName("NGAY_KET_THUC");

                    b.HasKey("Masach", "Masale");

                    b.HasIndex("Masale");

                    b.ToTable("CHITIETSALE");
                });

            modelBuilder.Entity("QLTV2._0.Models.Chitiettacgia", b =>
                {
                    b.Property<string>("Masach")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .HasColumnName("MASACH")
                        .IsFixedLength(true);

                    b.Property<int>("IdTacgia")
                        .HasColumnType("int")
                        .HasColumnName("ID_TACGIA");

                    b.HasKey("Masach", "IdTacgia");

                    b.HasIndex("IdTacgia");

                    b.ToTable("CHITIETTACGIA");
                });

            modelBuilder.Entity("QLTV2._0.Models.Coupon", b =>
                {
                    b.Property<string>("MaCoupon")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength(true);

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("createdAt")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("Giamgia")
                        .HasColumnType("int")
                        .HasColumnName("giamgia");

                    b.Property<int>("IdCoupon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_coupon")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Soluong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("Thoigianhieuluc")
                        .HasColumnType("int")
                        .HasColumnName("thoigianhieuluc");

                    b.Property<DateTime?>("UpdateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("updateAt")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("MaCoupon")
                        .HasName("pk_coupon");

                    b.ToTable("Coupon");
                });

            modelBuilder.Entity("QLTV2._0.Models.Hinhanh", b =>
                {
                    b.Property<int>("IdAnh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_ANH")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Masach")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .HasColumnName("MASACH")
                        .IsFixedLength(true);

                    b.Property<string>("Url")
                        .HasColumnType("text")
                        .HasColumnName("url");

                    b.HasKey("IdAnh");

                    b.HasIndex("Masach");

                    b.ToTable("HINHANH");
                });

            modelBuilder.Entity("QLTV2._0.Models.Hoadon", b =>
                {
                    b.Property<int>("IdHoadon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_HOADON")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Createdat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("CREATEDAT")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<decimal?>("Discount")
                        .HasColumnType("money")
                        .HasColumnName("discount");

                    b.Property<int?>("IdKh")
                        .HasColumnType("int")
                        .HasColumnName("id_kh");

                    b.Property<decimal?>("Phiship")
                        .HasColumnType("money")
                        .HasColumnName("phiship");

                    b.Property<int?>("Soluong")
                        .HasColumnType("int")
                        .HasColumnName("soluong");

                    b.Property<int?>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("status")
                        .HasDefaultValueSql("((0))");

                    b.Property<decimal?>("TongHoaDon")
                        .HasColumnType("money");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("UserName")
                        .HasMaxLength(35)
                        .IsUnicode(false)
                        .HasColumnType("char(35)")
                        .HasColumnName("USER_NAME")
                        .IsFixedLength(true);

                    b.HasKey("IdHoadon")
                        .HasName("pk_hoadon");

                    b.HasIndex("IdKh");

                    b.HasIndex("UserName");

                    b.ToTable("HOADON");
                });

            modelBuilder.Entity("QLTV2._0.Models.KhachHang", b =>
                {
                    b.Property<int>("IdKh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_kh")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi")
                        .HasColumnType("ntext");

                    b.Property<bool?>("Gioitinh")
                        .HasColumnType("bit")
                        .HasColumnName("gioitinh");

                    b.Property<DateTime?>("Ngaysinh")
                        .HasColumnType("date")
                        .HasColumnName("ngaysinh");

                    b.Property<string>("Sdt")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength(true);

                    b.Property<string>("TenKhachHang")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdKh")
                        .HasName("pk_kh");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("QLTV2._0.Models.Nxb", b =>
                {
                    b.Property<string>("Manxb")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .HasColumnName("MANXB")
                        .IsFixedLength(true);

                    b.Property<string>("Diachi")
                        .HasColumnType("text")
                        .HasColumnName("DIACHI");

                    b.Property<int>("IdNxb")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_NXB")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Sdt")
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("char(12)")
                        .HasColumnName("SDT")
                        .IsFixedLength(true);

                    b.Property<string>("Tennxb")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TENNXB");

                    b.HasKey("Manxb")
                        .IsClustered(false);

                    b.ToTable("NXB");
                });

            modelBuilder.Entity("QLTV2._0.Models.Phieunhap", b =>
                {
                    b.Property<string>("Maphieunhap")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .HasColumnName("MAPHIEUNHAP")
                        .IsFixedLength(true);

                    b.Property<DateTime?>("Createdat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("CREATEDAT")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<decimal?>("Gianhap")
                        .HasColumnType("money")
                        .HasColumnName("GIANHAP");

                    b.Property<int>("IdPhieunhap")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_PHIEUNHAP")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Soluongnhap")
                        .HasColumnType("int")
                        .HasColumnName("SOLUONGNHAP");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("Maphieunhap")
                        .IsClustered(false);

                    b.ToTable("PHIEUNHAP");
                });

            modelBuilder.Entity("QLTV2._0.Models.Sach", b =>
                {
                    b.Property<string>("Masach")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .HasColumnName("MASACH")
                        .IsFixedLength(true);

                    b.Property<DateTime?>("Createdat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("CREATEDAT")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<decimal?>("Giaban")
                        .HasColumnType("money")
                        .HasColumnName("GIABAN");

                    b.Property<int>("IdSach")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_SACH")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Img")
                        .HasColumnType("text")
                        .HasColumnName("IMG");

                    b.Property<string>("Manxb")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .HasColumnName("MANXB")
                        .IsFixedLength(true);

                    b.Property<string>("Maphieunhap")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .HasColumnName("MAPHIEUNHAP")
                        .IsFixedLength(true);

                    b.Property<string>("Matheloai")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .HasColumnName("MATHELOAI")
                        .IsFixedLength(true);

                    b.Property<string>("Mota")
                        .HasColumnType("ntext");

                    b.Property<int?>("Slton")
                        .HasColumnType("int")
                        .HasColumnName("SLTON");

                    b.Property<string>("Tensach")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TENSACH");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("Masach")
                        .IsClustered(false);

                    b.HasIndex("Manxb");

                    b.HasIndex("Maphieunhap");

                    b.HasIndex("Matheloai");

                    b.ToTable("SACH");
                });

            modelBuilder.Entity("QLTV2._0.Models.Sale", b =>
                {
                    b.Property<string>("Masale")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .HasColumnName("MASALE")
                        .IsFixedLength(true);

                    b.Property<DateTime?>("Createdat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("CREATEDAT")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("IdSale")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_SALE")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("Masale")
                        .IsClustered(false);

                    b.ToTable("SALE");
                });

            modelBuilder.Entity("QLTV2._0.Models.Tacgia", b =>
                {
                    b.Property<int>("IdTacgia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_TACGIA")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tentacgia")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("TENTACGIA");

                    b.HasKey("IdTacgia")
                        .IsClustered(false);

                    b.ToTable("TACGIA");
                });

            modelBuilder.Entity("QLTV2._0.Models.TaiKhoanGoogle", b =>
                {
                    b.Property<string>("IdGoogle")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("char(30)")
                        .HasColumnName("id_google")
                        .IsFixedLength(true);

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdKh")
                        .HasColumnType("int")
                        .HasColumnName("id_kh");

                    b.HasKey("IdGoogle")
                        .HasName("PK__TaiKhoan__26387A7E113CA94B");

                    b.HasIndex("IdKh");

                    b.ToTable("TaiKhoanGoogle");
                });

            modelBuilder.Entity("QLTV2._0.Models.Taikhoan", b =>
                {
                    b.Property<string>("UserName")
                        .HasMaxLength(35)
                        .IsUnicode(false)
                        .HasColumnType("char(35)")
                        .HasColumnName("USER_NAME")
                        .IsFixedLength(true);

                    b.Property<int?>("IdKh")
                        .HasColumnType("int")
                        .HasColumnName("id_kh");

                    b.Property<int>("IdTaikhoan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_TAIKHOAN")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasMaxLength(14)
                        .IsUnicode(false)
                        .HasColumnType("char(14)")
                        .HasColumnName("PASSWORD")
                        .IsFixedLength(true);

                    b.Property<int?>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Salt")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .HasColumnName("SALT")
                        .IsFixedLength(true);

                    b.HasKey("UserName")
                        .IsClustered(false);

                    b.HasIndex("IdKh");

                    b.ToTable("TAIKHOAN");
                });

            modelBuilder.Entity("QLTV2._0.Models.Theloai", b =>
                {
                    b.Property<string>("Matheloai")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .HasColumnName("MATHELOAI")
                        .IsFixedLength(true);

                    b.Property<int>("IdTheloai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_THELOAI")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tentheloai")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("TENTHELOAI");

                    b.HasKey("Matheloai")
                        .IsClustered(false);

                    b.ToTable("THELOAI");
                });

            modelBuilder.Entity("QLTV2._0.Models.ChiTietCoupon", b =>
                {
                    b.HasOne("QLTV2._0.Models.Hoadon", "IdHoadonNavigation")
                        .WithMany("ChiTietCoupons")
                        .HasForeignKey("IdHoadon")
                        .HasConstraintName("fk_ctcp_hoadon")
                        .IsRequired();

                    b.HasOne("QLTV2._0.Models.Coupon", "MaCouponNavigation")
                        .WithMany("ChiTietCoupons")
                        .HasForeignKey("MaCoupon")
                        .HasConstraintName("fk_ctcp_coupon")
                        .IsRequired();

                    b.Navigation("IdHoadonNavigation");

                    b.Navigation("MaCouponNavigation");
                });

            modelBuilder.Entity("QLTV2._0.Models.Chitiethoadon", b =>
                {
                    b.HasOne("QLTV2._0.Models.Hoadon", "IdHoadonNavigation")
                        .WithMany("Chitiethoadons")
                        .HasForeignKey("IdHoadon")
                        .HasConstraintName("FK_cthd_idHoadon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QLTV2._0.Models.Sach", "MasachNavigation")
                        .WithMany("Chitiethoadons")
                        .HasForeignKey("Masach")
                        .HasConstraintName("FK_cthd_MASACH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdHoadonNavigation");

                    b.Navigation("MasachNavigation");
                });

            modelBuilder.Entity("QLTV2._0.Models.Chitietsale", b =>
                {
                    b.HasOne("QLTV2._0.Models.Sach", "MasachNavigation")
                        .WithMany("Chitietsales")
                        .HasForeignKey("Masach")
                        .HasConstraintName("FK_cts_Sach")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QLTV2._0.Models.Sale", "MasaleNavigation")
                        .WithMany("Chitietsales")
                        .HasForeignKey("Masale")
                        .HasConstraintName("FK_cts_sale")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MasachNavigation");

                    b.Navigation("MasaleNavigation");
                });

            modelBuilder.Entity("QLTV2._0.Models.Chitiettacgia", b =>
                {
                    b.HasOne("QLTV2._0.Models.Tacgia", "IdTacgiaNavigation")
                        .WithMany("Chitiettacgia")
                        .HasForeignKey("IdTacgia")
                        .HasConstraintName("fk_cttg_tacgia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QLTV2._0.Models.Sach", "MasachNavigation")
                        .WithMany("Chitiettacgia")
                        .HasForeignKey("Masach")
                        .HasConstraintName("fk_cttg_masach")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdTacgiaNavigation");

                    b.Navigation("MasachNavigation");
                });

            modelBuilder.Entity("QLTV2._0.Models.Hinhanh", b =>
                {
                    b.HasOne("QLTV2._0.Models.Sach", "MasachNavigation")
                        .WithMany("Hinhanhs")
                        .HasForeignKey("Masach")
                        .HasConstraintName("FK_SACH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MasachNavigation");
                });

            modelBuilder.Entity("QLTV2._0.Models.Hoadon", b =>
                {
                    b.HasOne("QLTV2._0.Models.KhachHang", "IdKhNavigation")
                        .WithMany("Hoadons")
                        .HasForeignKey("IdKh")
                        .HasConstraintName("fk_kh");

                    b.HasOne("QLTV2._0.Models.Taikhoan", "UserNameNavigation")
                        .WithMany("Hoadons")
                        .HasForeignKey("UserName")
                        .HasConstraintName("fk_user");

                    b.Navigation("IdKhNavigation");

                    b.Navigation("UserNameNavigation");
                });

            modelBuilder.Entity("QLTV2._0.Models.Sach", b =>
                {
                    b.HasOne("QLTV2._0.Models.Nxb", "ManxbNavigation")
                        .WithMany("Saches")
                        .HasForeignKey("Manxb")
                        .HasConstraintName("fk_nxb")
                        .IsRequired();

                    b.HasOne("QLTV2._0.Models.Phieunhap", "MaphieunhapNavigation")
                        .WithMany("Saches")
                        .HasForeignKey("Maphieunhap")
                        .HasConstraintName("fk_sach_phieunhap")
                        .IsRequired();

                    b.HasOne("QLTV2._0.Models.Theloai", "MatheloaiNavigation")
                        .WithMany("Saches")
                        .HasForeignKey("Matheloai")
                        .HasConstraintName("fk_theloai")
                        .IsRequired();

                    b.Navigation("ManxbNavigation");

                    b.Navigation("MaphieunhapNavigation");

                    b.Navigation("MatheloaiNavigation");
                });

            modelBuilder.Entity("QLTV2._0.Models.TaiKhoanGoogle", b =>
                {
                    b.HasOne("QLTV2._0.Models.KhachHang", "IdKhNavigation")
                        .WithMany("TaiKhoanGoogles")
                        .HasForeignKey("IdKh")
                        .HasConstraintName("fk_google");

                    b.Navigation("IdKhNavigation");
                });

            modelBuilder.Entity("QLTV2._0.Models.Taikhoan", b =>
                {
                    b.HasOne("QLTV2._0.Models.KhachHang", "IdKhNavigation")
                        .WithMany("Taikhoans")
                        .HasForeignKey("IdKh")
                        .HasConstraintName("fk_tk");

                    b.Navigation("IdKhNavigation");
                });

            modelBuilder.Entity("QLTV2._0.Models.Coupon", b =>
                {
                    b.Navigation("ChiTietCoupons");
                });

            modelBuilder.Entity("QLTV2._0.Models.Hoadon", b =>
                {
                    b.Navigation("ChiTietCoupons");

                    b.Navigation("Chitiethoadons");
                });

            modelBuilder.Entity("QLTV2._0.Models.KhachHang", b =>
                {
                    b.Navigation("Hoadons");

                    b.Navigation("TaiKhoanGoogles");

                    b.Navigation("Taikhoans");
                });

            modelBuilder.Entity("QLTV2._0.Models.Nxb", b =>
                {
                    b.Navigation("Saches");
                });

            modelBuilder.Entity("QLTV2._0.Models.Phieunhap", b =>
                {
                    b.Navigation("Saches");
                });

            modelBuilder.Entity("QLTV2._0.Models.Sach", b =>
                {
                    b.Navigation("Chitiethoadons");

                    b.Navigation("Chitietsales");

                    b.Navigation("Chitiettacgia");

                    b.Navigation("Hinhanhs");
                });

            modelBuilder.Entity("QLTV2._0.Models.Sale", b =>
                {
                    b.Navigation("Chitietsales");
                });

            modelBuilder.Entity("QLTV2._0.Models.Tacgia", b =>
                {
                    b.Navigation("Chitiettacgia");
                });

            modelBuilder.Entity("QLTV2._0.Models.Taikhoan", b =>
                {
                    b.Navigation("Hoadons");
                });

            modelBuilder.Entity("QLTV2._0.Models.Theloai", b =>
                {
                    b.Navigation("Saches");
                });
#pragma warning restore 612, 618
        }
    }
}
