using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaWebApp.Migrations
{
    public partial class fix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Пол",
                table: "Сотрудник",
                type: "NVARCHAR (10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "CHAR (3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Пол",
                table: "Сотрудник",
                type: "CHAR (3)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR (10)");
        }
    }
}
