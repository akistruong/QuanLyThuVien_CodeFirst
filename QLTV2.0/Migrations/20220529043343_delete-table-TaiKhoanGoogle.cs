using Microsoft.EntityFrameworkCore.Migrations;

namespace QLTV2._0.Migrations
{
    public partial class deletetableTaiKhoanGoogle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaiKhoanGoogle");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoanGoogle_id_kh",
                table: "TaiKhoanGoogle",
                column: "id_kh");
        }
    }
}
