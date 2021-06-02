using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaWebApp.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Фирма_производитель",
                table: "Фильм",
                type: "NVARCHAR (50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR (50)");

            migrationBuilder.AlterColumn<string>(
                name: "Страна_производитель",
                table: "Фильм",
                type: "NVARCHAR (50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR (50)");

            migrationBuilder.AlterColumn<string>(
                name: "Описание",
                table: "Фильм",
                type: "NVARCHAR (100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR (100)");

            migrationBuilder.AlterColumn<string>(
                name: "Наименование",
                table: "Фильм",
                type: "NVARCHAR (50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR (50)");

            migrationBuilder.AlterColumn<string>(
                name: "Актёры",
                table: "Фильм",
                type: "NVARCHAR (50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR (50)");

            migrationBuilder.AlterColumn<string>(
                name: "ФИО",
                table: "Сотрудник",
                type: "NVARCHAR (50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR (50)");

            migrationBuilder.AlterColumn<string>(
                name: "Телефон",
                table: "Сотрудник",
                type: "NVARCHAR (20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR (20)");

            migrationBuilder.AlterColumn<string>(
                name: "Паспортные_данные",
                table: "Сотрудник",
                type: "NVARCHAR (20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR (20)");

            migrationBuilder.AlterColumn<string>(
                name: "Адрес",
                table: "Сотрудник",
                type: "NVARCHAR (50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR (50)");

            migrationBuilder.AlterColumn<string>(
                name: "Описание",
                table: "Жанр",
                type: "NVARCHAR (100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR (100)");

            migrationBuilder.AlterColumn<string>(
                name: "Наименование",
                table: "Жанр",
                type: "NVARCHAR (50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR (50)");

            migrationBuilder.AlterColumn<string>(
                name: "Требования",
                table: "Должность",
                type: "NVARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Обязанности",
                table: "Должность",
                type: "NVARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Наименование_должности",
                table: "Должность",
                type: "NVARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Фирма_производитель",
                table: "Фильм",
                type: "VARCHAR (50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR (50)");

            migrationBuilder.AlterColumn<string>(
                name: "Страна_производитель",
                table: "Фильм",
                type: "VARCHAR (50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR (50)");

            migrationBuilder.AlterColumn<string>(
                name: "Описание",
                table: "Фильм",
                type: "VARCHAR (100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR (100)");

            migrationBuilder.AlterColumn<string>(
                name: "Наименование",
                table: "Фильм",
                type: "VARCHAR (50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR (50)");

            migrationBuilder.AlterColumn<string>(
                name: "Актёры",
                table: "Фильм",
                type: "VARCHAR (50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR (50)");

            migrationBuilder.AlterColumn<string>(
                name: "ФИО",
                table: "Сотрудник",
                type: "VARCHAR (50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR (50)");

            migrationBuilder.AlterColumn<string>(
                name: "Телефон",
                table: "Сотрудник",
                type: "VARCHAR (20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR (20)");

            migrationBuilder.AlterColumn<string>(
                name: "Паспортные_данные",
                table: "Сотрудник",
                type: "VARCHAR (20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR (20)");

            migrationBuilder.AlterColumn<string>(
                name: "Адрес",
                table: "Сотрудник",
                type: "VARCHAR (50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR (50)");

            migrationBuilder.AlterColumn<string>(
                name: "Описание",
                table: "Жанр",
                type: "VARCHAR (100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR (100)");

            migrationBuilder.AlterColumn<string>(
                name: "Наименование",
                table: "Жанр",
                type: "VARCHAR (50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR (50)");

            migrationBuilder.AlterColumn<string>(
                name: "Требования",
                table: "Должность",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Обязанности",
                table: "Должность",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Наименование_должности",
                table: "Должность",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(50)");
        }
    }
}
