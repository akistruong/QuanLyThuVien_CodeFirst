using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QLTV2._0.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coupon",
                columns: table => new
                {
                    MaCoupon = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    id_coupon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    giamgia = table.Column<int>(type: "int", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    thoigianhieuluc = table.Column<int>(type: "int", nullable: true),
                    createdAt = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    updateAt = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_coupon", x => x.MaCoupon);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    id_kh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhachHang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    gioitinh = table.Column<bool>(type: "bit", nullable: true),
                    ngaysinh = table.Column<DateTime>(type: "date", nullable: true),
                    Sdt = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    DiaChi = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_kh", x => x.id_kh);
                });

            migrationBuilder.CreateTable(
                name: "NXB",
                columns: table => new
                {
                    MANXB = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    ID_NXB = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DIACHI = table.Column<string>(type: "text", nullable: true),
                    SDT = table.Column<string>(type: "char(12)", unicode: false, fixedLength: true, maxLength: 12, nullable: true),
                    TENNXB = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NXB", x => x.MANXB)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "PHIEUNHAP",
                columns: table => new
                {
                    MAPHIEUNHAP = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    ID_PHIEUNHAP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SOLUONGNHAP = table.Column<int>(type: "int", nullable: true),
                    GIANHAP = table.Column<decimal>(type: "money", nullable: true),
                    CREATEDAT = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PHIEUNHAP", x => x.MAPHIEUNHAP)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "SALE",
                columns: table => new
                {
                    MASALE = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    ID_SALE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CREATEDAT = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALE", x => x.MASALE)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "TACGIA",
                columns: table => new
                {
                    ID_TACGIA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENTACGIA = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TACGIA", x => x.ID_TACGIA)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "THELOAI",
                columns: table => new
                {
                    MATHELOAI = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    ID_THELOAI = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENTHELOAI = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_THELOAI", x => x.MATHELOAI)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "TAIKHOAN",
                columns: table => new
                {
                    USER_NAME = table.Column<string>(type: "char(35)", unicode: false, fixedLength: true, maxLength: 35, nullable: false),
                    ID_TAIKHOAN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PASSWORD = table.Column<string>(type: "char(14)", unicode: false, fixedLength: true, maxLength: 14, nullable: true),
                    SALT = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    Role = table.Column<int>(type: "int", nullable: true),
                    id_kh = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAIKHOAN", x => x.USER_NAME)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "fk_tk",
                        column: x => x.id_kh,
                        principalTable: "KhachHang",
                        principalColumn: "id_kh",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoanGoogle",
                columns: table => new
                {
                    id_google = table.Column<string>(type: "char(30)", unicode: false, fixedLength: true, maxLength: 30, nullable: false),
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_kh = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TaiKhoan__26387A7E113CA94B", x => x.id_google);
                    table.ForeignKey(
                        name: "fk_google",
                        column: x => x.id_kh,
                        principalTable: "KhachHang",
                        principalColumn: "id_kh",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SACH",
                columns: table => new
                {
                    MASACH = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    ID_SACH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MANXB = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    MAPHIEUNHAP = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    MATHELOAI = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    TENSACH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GIABAN = table.Column<decimal>(type: "money", nullable: true),
                    IMG = table.Column<string>(type: "text", nullable: true),
                    SLTON = table.Column<int>(type: "int", nullable: true),
                    CREATEDAT = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Mota = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SACH", x => x.MASACH)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "fk_nxb",
                        column: x => x.MANXB,
                        principalTable: "NXB",
                        principalColumn: "MANXB",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_sach_phieunhap",
                        column: x => x.MAPHIEUNHAP,
                        principalTable: "PHIEUNHAP",
                        principalColumn: "MAPHIEUNHAP",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_theloai",
                        column: x => x.MATHELOAI,
                        principalTable: "THELOAI",
                        principalColumn: "MATHELOAI",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HOADON",
                columns: table => new
                {
                    ID_HOADON = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CREATEDAT = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    USER_NAME = table.Column<string>(type: "char(35)", unicode: false, fixedLength: true, maxLength: 35, nullable: true),
                    TongHoaDon = table.Column<decimal>(type: "money", nullable: true),
                    phiship = table.Column<decimal>(type: "money", nullable: true),
                    discount = table.Column<decimal>(type: "money", nullable: true),
                    soluong = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    id_kh = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_hoadon", x => x.ID_HOADON);
                    table.ForeignKey(
                        name: "fk_kh",
                        column: x => x.id_kh,
                        principalTable: "KhachHang",
                        principalColumn: "id_kh",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_user",
                        column: x => x.USER_NAME,
                        principalTable: "TAIKHOAN",
                        principalColumn: "USER_NAME",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CHITIETSALE",
                columns: table => new
                {
                    MASACH = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    MASALE = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    DISCOUNT = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    NGAY_BAT_DAU = table.Column<DateTime>(type: "date", nullable: true),
                    NGAY_KET_THUC = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHITIETSALE", x => new { x.MASACH, x.MASALE });
                    table.ForeignKey(
                        name: "FK_cts_Sach",
                        column: x => x.MASACH,
                        principalTable: "SACH",
                        principalColumn: "MASACH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cts_sale",
                        column: x => x.MASALE,
                        principalTable: "SALE",
                        principalColumn: "MASALE",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CHITIETTACGIA",
                columns: table => new
                {
                    MASACH = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    ID_TACGIA = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHITIETTACGIA", x => new { x.MASACH, x.ID_TACGIA });
                    table.ForeignKey(
                        name: "fk_cttg_masach",
                        column: x => x.MASACH,
                        principalTable: "SACH",
                        principalColumn: "MASACH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_cttg_tacgia",
                        column: x => x.ID_TACGIA,
                        principalTable: "TACGIA",
                        principalColumn: "ID_TACGIA",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HINHANH",
                columns: table => new
                {
                    ID_ANH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MASACH = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    url = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HINHANH", x => x.ID_ANH);
                    table.ForeignKey(
                        name: "FK_SACH",
                        column: x => x.MASACH,
                        principalTable: "SACH",
                        principalColumn: "MASACH",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietCoupon",
                columns: table => new
                {
                    MaCoupon = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    ID_HOADON = table.Column<int>(type: "int", nullable: false),
                    id_ctcp = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ngaybatdau = table.Column<DateTime>(type: "date", nullable: true),
                    ngayketthuc = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ctcp", x => new { x.MaCoupon, x.ID_HOADON });
                    table.ForeignKey(
                        name: "fk_ctcp_coupon",
                        column: x => x.MaCoupon,
                        principalTable: "Coupon",
                        principalColumn: "MaCoupon",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_ctcp_hoadon",
                        column: x => x.ID_HOADON,
                        principalTable: "HOADON",
                        principalColumn: "ID_HOADON",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CHITIETHOADON",
                columns: table => new
                {
                    MASACH = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
                    ID_HOADON = table.Column<int>(type: "int", nullable: false),
                    SLMUA = table.Column<int>(type: "int", nullable: true),
                    THANHTIEN = table.Column<decimal>(type: "money", nullable: true),
                    DONGIA = table.Column<decimal>(type: "money", nullable: true),
                    id_cthd = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cthd", x => new { x.MASACH, x.ID_HOADON });
                    table.ForeignKey(
                        name: "FK_cthd_idHoadon",
                        column: x => x.ID_HOADON,
                        principalTable: "HOADON",
                        principalColumn: "ID_HOADON",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cthd_MASACH",
                        column: x => x.MASACH,
                        principalTable: "SACH",
                        principalColumn: "MASACH",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietCoupon_ID_HOADON",
                table: "ChiTietCoupon",
                column: "ID_HOADON");

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETHOADON_ID_HOADON",
                table: "CHITIETHOADON",
                column: "ID_HOADON");

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETSALE_MASALE",
                table: "CHITIETSALE",
                column: "MASALE");

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETTACGIA_ID_TACGIA",
                table: "CHITIETTACGIA",
                column: "ID_TACGIA");

            migrationBuilder.CreateIndex(
                name: "IX_HINHANH_MASACH",
                table: "HINHANH",
                column: "MASACH");

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_id_kh",
                table: "HOADON",
                column: "id_kh");

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_USER_NAME",
                table: "HOADON",
                column: "USER_NAME");

            migrationBuilder.CreateIndex(
                name: "IX_SACH_MANXB",
                table: "SACH",
                column: "MANXB");

            migrationBuilder.CreateIndex(
                name: "IX_SACH_MAPHIEUNHAP",
                table: "SACH",
                column: "MAPHIEUNHAP");

            migrationBuilder.CreateIndex(
                name: "IX_SACH_MATHELOAI",
                table: "SACH",
                column: "MATHELOAI");

            migrationBuilder.CreateIndex(
                name: "IX_TAIKHOAN_id_kh",
                table: "TAIKHOAN",
                column: "id_kh");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoanGoogle_id_kh",
                table: "TaiKhoanGoogle",
                column: "id_kh");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietCoupon");

            migrationBuilder.DropTable(
                name: "CHITIETHOADON");

            migrationBuilder.DropTable(
                name: "CHITIETSALE");

            migrationBuilder.DropTable(
                name: "CHITIETTACGIA");

            migrationBuilder.DropTable(
                name: "HINHANH");

            migrationBuilder.DropTable(
                name: "TaiKhoanGoogle");

            migrationBuilder.DropTable(
                name: "Coupon");

            migrationBuilder.DropTable(
                name: "HOADON");

            migrationBuilder.DropTable(
                name: "SALE");

            migrationBuilder.DropTable(
                name: "TACGIA");

            migrationBuilder.DropTable(
                name: "SACH");

            migrationBuilder.DropTable(
                name: "TAIKHOAN");

            migrationBuilder.DropTable(
                name: "NXB");

            migrationBuilder.DropTable(
                name: "PHIEUNHAP");

            migrationBuilder.DropTable(
                name: "THELOAI");

            migrationBuilder.DropTable(
                name: "KhachHang");
        }
    }
}
