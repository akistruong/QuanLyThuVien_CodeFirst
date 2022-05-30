using Microsoft.EntityFrameworkCore.Migrations;

namespace QLTV2._0.Migrations
{
    public partial class AddFk_comments_sach : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Masach",
                table: "Comments",
                type: "char(10)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Masach",
                table: "Comments",
                column: "Masach");

            migrationBuilder.AddForeignKey(
                name: "fk_coments_sach",
                table: "Comments",
                column: "Masach",
                principalTable: "SACH",
                principalColumn: "MASACH",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_coments_sach",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_Masach",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Masach",
                table: "Comments");
        }
    }
}
