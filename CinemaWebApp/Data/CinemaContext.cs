using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CinemaWebApp.Models;

#nullable disable

namespace CinemaWebApp.Data
{
    public partial class CinemaContext : DbContext
    {
        public CinemaContext()
        {
        }

        public CinemaContext(DbContextOptions<CinemaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Должность> Должности { get; set; }
        public virtual DbSet<Жанр> Жанры { get; set; }
        public virtual DbSet<Место> Места { get; set; }
        public virtual DbSet<Репертуар> Репертуары { get; set; }
        public virtual DbSet<Сотрудник> Сотрудники { get; set; }
        public virtual DbSet<Фильм> Фильмы { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseSqlite("Data Source = C:\\Users\\komp\\Desktop\\Karina tereshchenko - project\\CinemaWebApp\\Cinema.db");
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Cinema.db; Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Должность>(entity =>
            {
                entity.HasKey(e => e.КодДолжности);

                entity.ToTable("Должность");

                entity.Property(e => e.КодДолжности)
                    .HasColumnType("INT")
                    .ValueGeneratedNever()
                    .HasColumnName("Код_должности");

                entity.Property(e => e.НаименованиеДолжности)
                    .IsRequired()
                    .HasColumnType("NVARCHAR(50)")
                    .HasColumnName("Наименование_должности");

                entity.Property(e => e.Обязанности)
                    .IsRequired()
                    .HasColumnType("NVARCHAR(50)");

                entity.Property(e => e.Оклад).HasColumnType("FLOAT");

                entity.Property(e => e.Требования)
                    .IsRequired()
                    .HasColumnType("NVARCHAR(50)");
            });

            modelBuilder.Entity<Жанр>(entity =>
            {
                entity.HasKey(e => e.КодЖанра);

                entity.ToTable("Жанр");

                entity.Property(e => e.КодЖанра)
                    .HasColumnType("INT")
                    .ValueGeneratedNever()
                    .HasColumnName("Код_жанра");

                entity.Property(e => e.Наименование)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (50)");

                entity.Property(e => e.Описание)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (100)");
            });

            modelBuilder.Entity<Место>(entity =>
            {
                entity.HasKey(e => e.НомерМеста);

                entity.ToTable("Место");

                entity.Property(e => e.НомерМеста)
                    .HasColumnType("INT")
                    .ValueGeneratedNever()
                    .HasColumnName("Номер_места");

                entity.Property(e => e.Занятость)
                    .IsRequired()
                    .HasColumnType("CHAR (1)");

                entity.Property(e => e.КодСеанса)
                    .HasColumnType("INT")
                    .HasColumnName("Код_сеанса");

                entity.Property(e => e.КодСотрудника)
                    .HasColumnType("INT")
                    .HasColumnName("Код_сотрудника");

                entity.HasOne(d => d.КодСеансаNavigation)
                    .WithMany(p => p.Местоs)
                    .HasForeignKey(d => d.КодСеанса)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Репертуар>(entity =>
            {
                entity.HasKey(e => e.КодСеанса);

                entity.ToTable("Репертуар");

                entity.Property(e => e.КодСеанса)
                    .HasColumnType("INT")
                    .ValueGeneratedNever()
                    .HasColumnName("Код_сеанса");

                entity.Property(e => e.ВремяНачала)
                    .IsRequired()
                    .HasColumnType("DATE")
                    .HasColumnName("Время_начала");

                entity.Property(e => e.ВремяОкончания)
                    .IsRequired()
                    .HasColumnType("DATE")
                    .HasColumnName("Время_окончания");

                entity.Property(e => e.Дата)
                    .IsRequired()
                    .HasColumnType("DATE");

                entity.Property(e => e.ЦенаБилета)
                    .HasColumnType("FLOAT")
                    .HasColumnName("Цена_билета");
            });

            modelBuilder.Entity<Сотрудник>(entity =>
            {
                entity.HasKey(e => e.КодСотрудника);

                entity.ToTable("Сотрудник");

                entity.Property(e => e.КодСотрудника)
                    .HasColumnType("INT")
                    .ValueGeneratedNever()
                    .HasColumnName("Код_сотрудника");

                entity.Property(e => e.Адрес)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (50)");

                entity.Property(e => e.Возраст).HasColumnType("INT");

                entity.Property(e => e.КодДолжности)
                    .HasColumnType("INT")
                    .HasColumnName("Код_должности");

                entity.Property(e => e.ПаспортныеДанные)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (20)")
                    .HasColumnName("Паспортные_данные");

                entity.Property(e => e.Пол)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (10)");

                entity.Property(e => e.Телефон)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (20)");

                entity.Property(e => e.Фио)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (50)")
                    .HasColumnName("ФИО");

                entity.HasOne(d => d.КодДолжностиNavigation)
                    .WithMany(p => p.Сотрудникs)
                    .HasForeignKey(d => d.КодДолжности)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Фильм>(entity =>
            {
                entity.HasKey(e => e.КодФильма);

                entity.ToTable("Фильм");

                entity.Property(e => e.КодФильма)
                    .HasColumnType("INT")
                    .ValueGeneratedNever()
                    .HasColumnName("Код_фильма");

                entity.Property(e => e.Актёры)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (50)");

                entity.Property(e => e.ВозрастныеОграничения)
                    .IsRequired()
                    .HasColumnType("CHAR (3)")
                    .HasColumnName("Возрастные_ограничения");

                entity.Property(e => e.Длительность).HasColumnType("FLOAT");

                entity.Property(e => e.КодЖанра)
                    .HasColumnType("INT")
                    .HasColumnName("Код_жанра");

                entity.Property(e => e.Наименование)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (50)");

                entity.Property(e => e.Описание)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (100)");

                entity.Property(e => e.СтранаПроизводитель)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (50)")
                    .HasColumnName("Страна_производитель");

                entity.Property(e => e.ФирмаПроизводитель)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (50)")
                    .HasColumnName("Фирма_производитель");

                entity.HasOne(d => d.КодЖанраNavigation)
                    .WithMany(p => p.Фильмs)
                    .HasForeignKey(d => d.КодЖанра)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
