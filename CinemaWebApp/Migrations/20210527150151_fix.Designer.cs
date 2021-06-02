﻿// <auto-generated />
using System;
using CinemaWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CinemaWebApp.Migrations
{
    [DbContext(typeof(CinemaContext))]
    [Migration("20210527150151_fix")]
    partial class fix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CinemaWebApp.Models.Должность", b =>
                {
                    b.Property<int>("КодДолжности")
                        .HasColumnType("INT")
                        .HasColumnName("Код_должности");

                    b.Property<string>("НаименованиеДолжности")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)")
                        .HasColumnName("Наименование_должности");

                    b.Property<string>("Обязанности")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<double>("Оклад")
                        .HasColumnType("FLOAT");

                    b.Property<string>("Требования")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.HasKey("КодДолжности");

                    b.ToTable("Должность");
                });

            modelBuilder.Entity("CinemaWebApp.Models.Жанр", b =>
                {
                    b.Property<int>("КодЖанра")
                        .HasColumnType("INT")
                        .HasColumnName("Код_жанра");

                    b.Property<string>("Наименование")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (50)");

                    b.Property<string>("Описание")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (100)");

                    b.HasKey("КодЖанра");

                    b.ToTable("Жанр");
                });

            modelBuilder.Entity("CinemaWebApp.Models.Место", b =>
                {
                    b.Property<int>("НомерМеста")
                        .HasColumnType("INT")
                        .HasColumnName("Номер_места");

                    b.Property<string>("Занятость")
                        .IsRequired()
                        .HasColumnType("CHAR (1)");

                    b.Property<int>("КодСеанса")
                        .HasColumnType("INT")
                        .HasColumnName("Код_сеанса");

                    b.Property<int>("КодСотрудника")
                        .HasColumnType("INT")
                        .HasColumnName("Код_сотрудника");

                    b.HasKey("НомерМеста");

                    b.HasIndex("КодСеанса");

                    b.ToTable("Место");
                });

            modelBuilder.Entity("CinemaWebApp.Models.Репертуар", b =>
                {
                    b.Property<int>("КодСеанса")
                        .HasColumnType("INT")
                        .HasColumnName("Код_сеанса");

                    b.Property<DateTime>("ВремяНачала")
                        .HasColumnType("DATE")
                        .HasColumnName("Время_начала");

                    b.Property<DateTime>("ВремяОкончания")
                        .HasColumnType("DATE")
                        .HasColumnName("Время_окончания");

                    b.Property<DateTime>("Дата")
                        .HasColumnType("DATE");

                    b.Property<double>("ЦенаБилета")
                        .HasColumnType("FLOAT")
                        .HasColumnName("Цена_билета");

                    b.HasKey("КодСеанса");

                    b.ToTable("Репертуар");
                });

            modelBuilder.Entity("CinemaWebApp.Models.Сотрудник", b =>
                {
                    b.Property<int>("КодСотрудника")
                        .HasColumnType("INT")
                        .HasColumnName("Код_сотрудника");

                    b.Property<string>("Адрес")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (50)");

                    b.Property<int>("Возраст")
                        .HasColumnType("INT");

                    b.Property<int>("КодДолжности")
                        .HasColumnType("INT")
                        .HasColumnName("Код_должности");

                    b.Property<string>("ПаспортныеДанные")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (20)")
                        .HasColumnName("Паспортные_данные");

                    b.Property<string>("Пол")
                        .IsRequired()
                        .HasColumnType("CHAR (3)");

                    b.Property<string>("Телефон")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (20)");

                    b.Property<string>("Фио")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (50)")
                        .HasColumnName("ФИО");

                    b.HasKey("КодСотрудника");

                    b.HasIndex("КодДолжности");

                    b.ToTable("Сотрудник");
                });

            modelBuilder.Entity("CinemaWebApp.Models.Фильм", b =>
                {
                    b.Property<int>("КодФильма")
                        .HasColumnType("INT")
                        .HasColumnName("Код_фильма");

                    b.Property<string>("Актёры")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (50)");

                    b.Property<string>("ВозрастныеОграничения")
                        .IsRequired()
                        .HasColumnType("CHAR (3)")
                        .HasColumnName("Возрастные_ограничения");

                    b.Property<double>("Длительность")
                        .HasColumnType("FLOAT");

                    b.Property<int>("КодЖанра")
                        .HasColumnType("INT")
                        .HasColumnName("Код_жанра");

                    b.Property<string>("Наименование")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (50)");

                    b.Property<string>("Описание")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (100)");

                    b.Property<string>("СтранаПроизводитель")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (50)")
                        .HasColumnName("Страна_производитель");

                    b.Property<string>("ФирмаПроизводитель")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (50)")
                        .HasColumnName("Фирма_производитель");

                    b.HasKey("КодФильма");

                    b.HasIndex("КодЖанра");

                    b.ToTable("Фильм");
                });

            modelBuilder.Entity("CinemaWebApp.Models.Место", b =>
                {
                    b.HasOne("CinemaWebApp.Models.Репертуар", "КодСеансаNavigation")
                        .WithMany("Местоs")
                        .HasForeignKey("КодСеанса")
                        .IsRequired();

                    b.Navigation("КодСеансаNavigation");
                });

            modelBuilder.Entity("CinemaWebApp.Models.Сотрудник", b =>
                {
                    b.HasOne("CinemaWebApp.Models.Должность", "КодДолжностиNavigation")
                        .WithMany("Сотрудникs")
                        .HasForeignKey("КодДолжности")
                        .IsRequired();

                    b.Navigation("КодДолжностиNavigation");
                });

            modelBuilder.Entity("CinemaWebApp.Models.Фильм", b =>
                {
                    b.HasOne("CinemaWebApp.Models.Жанр", "КодЖанраNavigation")
                        .WithMany("Фильмs")
                        .HasForeignKey("КодЖанра")
                        .IsRequired();

                    b.Navigation("КодЖанраNavigation");
                });

            modelBuilder.Entity("CinemaWebApp.Models.Должность", b =>
                {
                    b.Navigation("Сотрудникs");
                });

            modelBuilder.Entity("CinemaWebApp.Models.Жанр", b =>
                {
                    b.Navigation("Фильмs");
                });

            modelBuilder.Entity("CinemaWebApp.Models.Репертуар", b =>
                {
                    b.Navigation("Местоs");
                });
#pragma warning restore 612, 618
        }
    }
}
