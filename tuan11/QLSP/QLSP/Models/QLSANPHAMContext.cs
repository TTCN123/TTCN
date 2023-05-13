using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace QLSP.models
{
    public partial class QLSANPHAMContext : DbContext
    {
        public QLSANPHAMContext()
        {
        }

        public QLSANPHAMContext(DbContextOptions<QLSANPHAMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LoaiSp> LoaiSps { get; set; }
        public virtual DbSet<Sp> Sps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-HOANGCZ;Initial Catalog=QLSANPHAM;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<LoaiSp>(entity =>
            {
                entity.HasKey(e => e.Maloai)
                    .HasName("PK__LoaiSP__734B3AEAE407A072");

                entity.ToTable("LoaiSP");

                entity.Property(e => e.Maloai)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maloai")
                    .IsFixedLength(true);

                entity.Property(e => e.Tenloai)
                    .HasMaxLength(50)
                    .HasColumnName("tenloai");
            });

            modelBuilder.Entity<Sp>(entity =>
            {
                entity.HasKey(e => e.Masp)
                    .HasName("PK__SP__7A217672CA034561");

                entity.ToTable("SP");

                entity.Property(e => e.Masp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("masp")
                    .IsFixedLength(true);

                entity.Property(e => e.Dongia).HasColumnName("dongia");

                entity.Property(e => e.Maloai)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("maloai")
                    .IsFixedLength(true);

                entity.Property(e => e.Sl).HasColumnName("sl");

                entity.Property(e => e.Tensp)
                    .HasMaxLength(50)
                    .HasColumnName("tensp");

                entity.HasOne(d => d.MaloaiNavigation)
                    .WithMany(p => p.Sps)
                    .HasForeignKey(d => d.Maloai)
                    .HasConstraintName("fk_SP_loaiSP");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
