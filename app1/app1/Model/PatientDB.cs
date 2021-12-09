using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace app1.Model
{
    public partial class PatientDB : DbContext
    {
        public PatientDB()
        {
        }

        public PatientDB(DbContextOptions<PatientDB> options)
            : base(options)
        {
        }

        public virtual DbSet<Measure> Measures { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\ELTE\\MyGitHub\\cs-desktop-app\\app1\\Database1.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Measure>(entity =>
            {
                entity.ToTable("Measure");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Critical)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Daytime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.When).HasColumnType("datetime");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Measures)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Measure__Usernam__29221CFB");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__Patient__536C85E539AE548E");

                entity.ToTable("Patient");

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
