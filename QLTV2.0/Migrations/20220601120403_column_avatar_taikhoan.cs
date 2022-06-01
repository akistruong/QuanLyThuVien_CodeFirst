using Microsoft.EntityFrameworkCore.Migrations;

namespace QLTV2._0.Migrations
{
    public partial class column_avatar_taikhoan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "avatar",
                table: "TAIKHOAN",
                type: "text",
                nullable: true,
                defaultValue: "user--v1.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "avatar",
                table: "TAIKHOAN");
        }
    }
}
