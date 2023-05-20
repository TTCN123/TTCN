using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace QLSV.Models
{
    public partial class QLSVContext : DbContext
    {
        public QLSVContext()
        {
        }

        public QLSVContext(DbContextOptions<QLSVContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblDiem> TblDiems { get; set; }
        public virtual DbSet<TblGiaoVen> TblGiaoVens { get; set; }
        public virtual DbSet<TblMonHoc> TblMonHocs { get; set; }
        public virtual DbSet<TblSinhVien> TblSinhViens { get; set; }
        public virtual DbSet<Tbltaikhoan> Tbltaikhoans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-HOANGCZ;Initial Catalog=QLSV;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblDiem>(entity =>
            {
                entity.HasKey(e => new { e.MaMh, e.MaGv, e.MaSv, e.LanHoc });

                entity.ToTable("tblDiem");

                entity.Property(e => e.MaMh).HasColumnName("MaMH");

                entity.Property(e => e.MaGv).HasColumnName("MaGV");

                entity.Property(e => e.MaSv)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MaSV");

                entity.Property(e => e.Ngaycapnhat)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaycapnhat")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaytao")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nguoicapnhat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nguoicapnhat")
                    .HasDefaultValueSql("('admin')");

                entity.Property(e => e.Nguoitao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nguoitao")
                    .HasDefaultValueSql("('admin')");

                entity.HasOne(d => d.MaGvNavigation)
                    .WithMany(p => p.TblDiems)
                    .HasForeignKey(d => d.MaGv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDiem_tblGiaoVen");

                entity.HasOne(d => d.MaMhNavigation)
                    .WithMany(p => p.TblDiems)
                    .HasForeignKey(d => d.MaMh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDiem_tblMonHoc");

                entity.HasOne(d => d.MaSvNavigation)
                    .WithMany(p => p.TblDiems)
                    .HasForeignKey(d => d.MaSv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDiem_tblSinhVien");
            });

            modelBuilder.Entity<TblGiaoVen>(entity =>
            {
                entity.HasKey(e => e.MaGv);

                entity.ToTable("tblGiaoVen");

                entity.Property(e => e.MaGv).HasColumnName("MaGV");

                entity.Property(e => e.DiaChi).HasMaxLength(150);

                entity.Property(e => e.DienThoai)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Ho)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.Ngaycapnhat)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaycapnhat")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaytao")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nguoicapnhat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nguoicapnhat")
                    .HasDefaultValueSql("('admin')");

                entity.Property(e => e.Nguoitao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nguoitao")
                    .HasDefaultValueSql("('admin')");

                entity.Property(e => e.Ten)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TenDem).HasMaxLength(50);
            });

            modelBuilder.Entity<TblMonHoc>(entity =>
            {
                entity.HasKey(e => e.MaMh);

                entity.ToTable("tblMonHoc");

                entity.Property(e => e.MaMh).HasColumnName("MaMH");

                entity.Property(e => e.Ngaycapnhat)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaycapnhat")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaytao")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nguoicapnhat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nguoicapnhat")
                    .HasDefaultValueSql("('admin')");

                entity.Property(e => e.Nguoitao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nguoitao")
                    .HasDefaultValueSql("('admin')");

                entity.Property(e => e.SoTc).HasColumnName("SoTC");

                entity.Property(e => e.TenMh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TenMH");
            });

            modelBuilder.Entity<TblSinhVien>(entity =>
            {
                entity.HasKey(e => e.MaSv);

                entity.ToTable("tblSinhVien");

                entity.Property(e => e.MaSv)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MaSV");

                entity.Property(e => e.DiaChi).HasMaxLength(150);

                entity.Property(e => e.DienThoai)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Ho)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.Ngaycapnhat)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaycapnhat")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaytao")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nguoicapnhat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nguoicapnhat")
                    .HasDefaultValueSql("('admin')");

                entity.Property(e => e.Nguoitao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nguoitao")
                    .HasDefaultValueSql("('admin')");

                entity.Property(e => e.Ten)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TenDem).HasMaxLength(50);
            });

            modelBuilder.Entity<Tbltaikhoan>(entity =>
            {
                entity.HasKey(e => e.Tentaikhoan);

                entity.ToTable("tbltaikhoan");

                entity.Property(e => e.Tentaikhoan)
                    .HasMaxLength(50)
                    .HasColumnName("tentaikhoan");

                entity.Property(e => e.Matkhau)
                    .HasMaxLength(250)
                    .HasColumnName("matkhau");
            });

            modelBuilder.HasSequence("sinhviensq").StartsAt(1000);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
