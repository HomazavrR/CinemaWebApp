using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaWebApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Должность",
                columns: table => new
                {
                    Код_должности = table.Column<int>(type: "INT", nullable: false),
                    Наименование_должности = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Оклад = table.Column<double>(type: "FLOAT", nullable: false),
                    Обязанности = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Требования = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Должность", x => x.Код_должности);
                });

            migrationBuilder.CreateTable(
                name: "Жанр",
                columns: table => new
                {
                    Код_жанра = table.Column<int>(type: "INT", nullable: false),
                    Наименование = table.Column<string>(type: "VARCHAR (50)", nullable: false),
                    Описание = table.Column<string>(type: "VARCHAR (100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Жанр", x => x.Код_жанра);
                });

            migrationBuilder.CreateTable(
                name: "Репертуар",
                columns: table => new
                {
                    Код_сеанса = table.Column<int>(type: "INT", nullable: false),
                    Дата = table.Column<DateTime>(type: "DATE", nullable: false),
                    Время_начала = table.Column<DateTime>(type: "DATE", nullable: false),
                    Время_окончания = table.Column<DateTime>(type: "DATE", nullable: false),
                    Цена_билета = table.Column<double>(type: "FLOAT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Репертуар", x => x.Код_сеанса);
                });

            migrationBuilder.CreateTable(
                name: "Сотрудник",
                columns: table => new
                {
                    Код_сотрудника = table.Column<int>(type: "INT", nullable: false),
                    Адрес = table.Column<string>(type: "VARCHAR (50)", nullable: false),
                    Телефон = table.Column<string>(type: "VARCHAR (20)", nullable: false),
                    Паспортные_данные = table.Column<string>(type: "VARCHAR (20)", nullable: false),
                    Пол = table.Column<string>(type: "CHAR (3)", nullable: false),
                    ФИО = table.Column<string>(type: "VARCHAR (50)", nullable: false),
                    Возраст = table.Column<int>(type: "INT", nullable: false),
                    Код_должности = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Сотрудник", x => x.Код_сотрудника);
                    table.ForeignKey(
                        name: "FK_Сотрудник_Должность_Код_должности",
                        column: x => x.Код_должности,
                        principalTable: "Должность",
                        principalColumn: "Код_должности",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Фильм",
                columns: table => new
                {
                    Код_фильма = table.Column<int>(type: "INT", nullable: false),
                    Наименование = table.Column<string>(type: "VARCHAR (50)", nullable: false),
                    Длительность = table.Column<double>(type: "FLOAT", nullable: false),
                    Фирма_производитель = table.Column<string>(type: "VARCHAR (50)", nullable: false),
                    Страна_производитель = table.Column<string>(type: "VARCHAR (50)", nullable: false),
                    Актёры = table.Column<string>(type: "VARCHAR (50)", nullable: false),
                    Возрастные_ограничения = table.Column<string>(type: "CHAR (3)", nullable: false),
                    Описание = table.Column<string>(type: "VARCHAR (100)", nullable: false),
                    Код_жанра = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Фильм", x => x.Код_фильма);
                    table.ForeignKey(
                        name: "FK_Фильм_Жанр_Код_жанра",
                        column: x => x.Код_жанра,
                        principalTable: "Жанр",
                        principalColumn: "Код_жанра",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Место",
                columns: table => new
                {
                    Номер_места = table.Column<int>(type: "INT", nullable: false),
                    Занятость = table.Column<string>(type: "CHAR (1)", nullable: false),
                    Код_сотрудника = table.Column<int>(type: "INT", nullable: false),
                    Код_сеанса = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Место", x => x.Номер_места);
                    table.ForeignKey(
                        name: "FK_Место_Репертуар_Код_сеанса",
                        column: x => x.Код_сеанса,
                        principalTable: "Репертуар",
                        principalColumn: "Код_сеанса",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Место_Код_сеанса",
                table: "Место",
                column: "Код_сеанса");

            migrationBuilder.CreateIndex(
                name: "IX_Сотрудник_Код_должности",
                table: "Сотрудник",
                column: "Код_должности");

            migrationBuilder.CreateIndex(
                name: "IX_Фильм_Код_жанра",
                table: "Фильм",
                column: "Код_жанра");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Место");

            migrationBuilder.DropTable(
                name: "Сотрудник");

            migrationBuilder.DropTable(
                name: "Фильм");

            migrationBuilder.DropTable(
                name: "Репертуар");

            migrationBuilder.DropTable(
                name: "Должность");

            migrationBuilder.DropTable(
                name: "Жанр");
        }
    }
}
