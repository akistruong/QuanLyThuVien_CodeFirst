using Microsoft.EntityFrameworkCore.Migrations;

namespace QLTV2._0.Migrations
{
    public partial class CascadeSach : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_sach_phieunhap",
                table: "SACH");

            migrationBuilder.AddForeignKey(
                name: "fk_sach_phieunhap",
                table: "SACH",
                column: "MAPHIEUNHAP",
                principalTable: "PHIEUNHAP",
                principalColumn: "MAPHIEUNHAP",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_sach_phieunhap",
                table: "SACH");

            migrationBuilder.AddForeignKey(
                name: "fk_sach_phieunhap",
                table: "SACH",
                column: "MAPHIEUNHAP",
                principalTable: "PHIEUNHAP",
                principalColumn: "MAPHIEUNHAP",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
