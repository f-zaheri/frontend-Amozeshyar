using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Amozeshyar.Migrations
{
    public partial class AddSalt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Salt",
                table: "Professors",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Salt",
                table: "Managers",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Salt",
                table: "Interns",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salt",
                table: "Professors");

            migrationBuilder.DropColumn(
                name: "Salt",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "Salt",
                table: "Interns");
        }
    }
}
