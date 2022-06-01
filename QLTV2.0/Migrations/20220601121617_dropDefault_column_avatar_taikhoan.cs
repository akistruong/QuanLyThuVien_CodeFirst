using Microsoft.EntityFrameworkCore.Migrations;

namespace QLTV2._0.Migrations
{
    public partial class dropDefault_column_avatar_taikhoan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "avatar",
                table: "TAIKHOAN",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true,
                oldDefaultValue: "user--v1.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "avatar",
                table: "TAIKHOAN",
                type: "text",
                nullable: true,
                defaultValue: "user--v1.png",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
