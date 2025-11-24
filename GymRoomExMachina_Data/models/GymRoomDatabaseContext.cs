using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GymRoomExMachina_Data.Models;

public partial class GymRoomDatabaseContext : DbContext
{
    public GymRoomDatabaseContext()
    {
    }

    public GymRoomDatabaseContext(DbContextOptions<GymRoomDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Coach> Coaches { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<Routine> Routines { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-2L7OPJ1\\SQLEXPRESS01;Database=GymRoom Database;Trusted_Connection=True; TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Coach>(entity =>
        {
            entity.HasKey(e => e.IdCoach).HasName("PK__Coach__448A1C7C3E8AEBCD");

            entity.ToTable("Coach");

            entity.HasIndex(e => e.LogInCoach, "UQ__Coach__5C63E8B082E5E072").IsUnique();

            entity.Property(e => e.IdCoach).HasColumnName("idCoach");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.LogInCoach)
                .HasMaxLength(50)
                .HasColumnName("logInCoach");
            entity.Property(e => e.NameCoach)
                .HasMaxLength(50)
                .HasColumnName("nameCoach");
            entity.Property(e => e.PasswordCoach)
                .HasMaxLength(50)
                .HasColumnName("passwordCoach");
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.HasKey(e => e.IdMember).HasName("PK__Member__7399FC4EB7FF3BD6");

            entity.ToTable("Member");

            entity.HasIndex(e => e.LogInMember, "UQ__Member__9E5A4629CFAEE13B").IsUnique();

            entity.Property(e => e.IdMember).HasColumnName("idMember");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Bicep)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("bicep");
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("bodyType");
            entity.Property(e => e.FatKg)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("fatKg");
            entity.Property(e => e.FatPct)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("fatPct");
            entity.Property(e => e.Goal)
                .HasMaxLength(50)
                .HasColumnName("goal");
            entity.Property(e => e.Height)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("height");
            entity.Property(e => e.IdCoach).HasColumnName("idCoach");
            entity.Property(e => e.IdRoutine).HasColumnName("idRoutine");
            entity.Property(e => e.Iliocrestal)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("iliocrestal");
            entity.Property(e => e.LogInMember)
                .HasMaxLength(50)
                .HasColumnName("logInMember");
            entity.Property(e => e.MuscleKg)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("muscleKg");
            entity.Property(e => e.NameMember)
                .HasMaxLength(50)
                .HasColumnName("nameMember");
            entity.Property(e => e.PasswordMember)
                .HasMaxLength(50)
                .HasColumnName("passwordMember");
            entity.Property(e => e.SignUpDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("signUpDate");
            entity.Property(e => e.Subscapular)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("subscapular");
            entity.Property(e => e.Tricep)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("tricep");
            entity.Property(e => e.Waist)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("waist");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("weight");

            entity.HasOne(d => d.IdCoachNavigation).WithMany(p => p.Members)
                .HasForeignKey(d => d.IdCoach)
                .HasConstraintName("FK_Member_Coach");

            entity.HasOne(d => d.IdRoutineNavigation).WithMany(p => p.Members)
                .HasForeignKey(d => d.IdRoutine)
                .HasConstraintName("FK_Member_Routine");
        });

        modelBuilder.Entity<Routine>(entity =>
        {
            entity.HasKey(e => e.IdRoutine).HasName("PK__Routine__99D02BFF6570E6BD");

            entity.ToTable("Routine");

            entity.Property(e => e.IdRoutine).HasColumnName("idRoutine");
            entity.Property(e => e.DescriptionRoutine).HasColumnName("descriptionRoutine");
            entity.Property(e => e.NameRoutine)
                .HasMaxLength(50)
                .HasColumnName("nameRoutine");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
