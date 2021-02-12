using Microsoft.EntityFrameworkCore.Migrations;

namespace Amozeshyar.Migrations
{
    public partial class ProfessorMobile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                table: "Professors",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Professors_Mobile",
                table: "Professors",
                column: "Mobile",
                unique: true,
                filter: "[Mobile] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Professors_Mobile",
                table: "Professors");

            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                table: "Professors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
