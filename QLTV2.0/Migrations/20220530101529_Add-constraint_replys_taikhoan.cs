using Microsoft.EntityFrameworkCore.Migrations;

namespace QLTV2._0.Migrations
{
    public partial class Addconstraint_replys_taikhoan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Reply",
                type: "char(35)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reply_UserName",
                table: "Reply",
                column: "UserName");

            migrationBuilder.AddForeignKey(
                name: "fk_reply_taikhoan",
                table: "Reply",
                column: "UserName",
                principalTable: "TAIKHOAN",
                principalColumn: "USER_NAME");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_reply_taikhoan",
                table: "Reply");

            migrationBuilder.DropIndex(
                name: "IX_Reply_UserName",
                table: "Reply");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Reply");
        }
    }
}
