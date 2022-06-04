using Microsoft.EntityFrameworkCore.Migrations;

namespace QLTV2._0.Migrations
{
    public partial class casecade_fk_hoadon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_kh",
                table: "HOADON");

            migrationBuilder.AddForeignKey(
                name: "fk_kh",
                table: "HOADON",
                column: "id_kh",
                principalTable: "KhachHang",
                principalColumn: "id_kh",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_kh",
                table: "HOADON");

            migrationBuilder.AddForeignKey(
                name: "fk_kh",
                table: "HOADON",
                column: "id_kh",
                principalTable: "KhachHang",
                principalColumn: "id_kh",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
