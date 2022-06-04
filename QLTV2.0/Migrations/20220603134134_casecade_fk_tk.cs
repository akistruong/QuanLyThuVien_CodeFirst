using Microsoft.EntityFrameworkCore.Migrations;

namespace QLTV2._0.Migrations
{
    public partial class casecade_fk_tk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_tk",
                table: "TAIKHOAN");

            migrationBuilder.AddForeignKey(
                name: "fk_tk",
                table: "TAIKHOAN",
                column: "id_kh",
                principalTable: "KhachHang",
                principalColumn: "id_kh",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_tk",
                table: "TAIKHOAN");

            migrationBuilder.AddForeignKey(
                name: "fk_tk",
                table: "TAIKHOAN",
                column: "id_kh",
                principalTable: "KhachHang",
                principalColumn: "id_kh",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
