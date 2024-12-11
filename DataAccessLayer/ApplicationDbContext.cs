using System;
using System.Collections.Generic;
using FreelancerProjectManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FreelancerProjectManagementAPI.DataAccessLayer;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AuditTrail> AuditTrails { get; set; }

    public virtual DbSet<EarningsReportView> EarningsReportViews { get; set; }

    public virtual DbSet<Freelancer> Freelancers { get; set; }

    public virtual DbSet<FreelancerPerformanceView> FreelancerPerformanceViews { get; set; }

    public virtual DbSet<FreelancerProject> FreelancerProjects { get; set; }

    public virtual DbSet<FreelancerRoleMaster> FreelancerRoleMasters { get; set; }

    public virtual DbSet<PaymentStatusMaster> PaymentStatusMasters { get; set; }

    public virtual DbSet<ProgressStatusMaster> ProgressStatusMasters { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<ProjectProgress> ProjectProgresses { get; set; }

    public virtual DbSet<ProjectStatusView> ProjectStatusViews { get; set; }

    public virtual DbSet<ProjectTypeMaster> ProjectTypeMasters { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=EPT\\DEV;Database=FreelancerManagementDB;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AuditTrail>(entity =>
        {
            entity.HasKey(e => e.AuditId).HasName("PK__AuditTra__A17F23B87BC63FC9");

            entity.ToTable("AuditTrail");

            entity.HasIndex(e => e.EntityName, "IDX_AuditTrail_EntityName");

            entity.HasIndex(e => e.Timestamp, "IDX_AuditTrail_Timestamp");

            entity.HasIndex(e => e.UserId, "IDX_AuditTrail_UserID");

            entity.Property(e => e.AuditId).HasColumnName("AuditID");
            entity.Property(e => e.ActionType).HasMaxLength(50);
            entity.Property(e => e.EntityId).HasColumnName("EntityID");
            entity.Property(e => e.EntityName).HasMaxLength(100);
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("IPAddress");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<EarningsReportView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EarningsReportView");

            entity.Property(e => e.FreelanceId).HasColumnName("FreelanceID");
            entity.Property(e => e.FreelancerName).HasMaxLength(100);
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(18)
                .IsUnicode(false);
            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
            entity.Property(e => e.ProjectName).HasMaxLength(100);
            entity.Property(e => e.TotalEarnings).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.TotalHours).HasColumnType("decimal(38, 2)");
        });

        modelBuilder.Entity<Freelancer>(entity =>
        {
            entity.HasKey(e => e.FreelanceId).HasName("PK__Freelanc__5E50CBB586963D71");

            entity.Property(e => e.FreelanceId).HasColumnName("FreelanceID");
            entity.Property(e => e.AvailabilityStatus).HasMaxLength(50);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.RatePerHour).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<FreelancerPerformanceView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FreelancerPerformanceView");

            entity.Property(e => e.FreelanceId).HasColumnName("FreelanceID");
            entity.Property(e => e.FreelancerName).HasMaxLength(100);
            entity.Property(e => e.LastUpdatedProject).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedTask).HasColumnType("datetime");
        });

        modelBuilder.Entity<FreelancerProject>(entity =>
        {
            entity.HasKey(e => e.AssignmentId).HasName("PK__Freelanc__32499E5711E0A86D");

            entity.ToTable("FreelancerProject");

            entity.Property(e => e.AssignmentId).HasColumnName("AssignmentID");
            entity.Property(e => e.AssignedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FreelancerId).HasColumnName("FreelancerID");
            entity.Property(e => e.FreelancerRoleId).HasColumnName("FreelancerRoleID");
            entity.Property(e => e.HourlyRate).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.PaymentStatusId).HasColumnName("PaymentStatusID");
            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
            entity.Property(e => e.TotalHours).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Freelancer).WithMany(p => p.FreelancerProjects)
                .HasForeignKey(d => d.FreelancerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Freelance__Freel__1BFD2C07");

            entity.HasOne(d => d.FreelancerRole).WithMany(p => p.FreelancerProjects)
                .HasForeignKey(d => d.FreelancerRoleId)
                .HasConstraintName("FK_FreelancerProject_FreelancerRoleMaster");

            entity.HasOne(d => d.PaymentStatus).WithMany(p => p.FreelancerProjects)
                .HasForeignKey(d => d.PaymentStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FreelancerProject_PaymentStatus");

            entity.HasOne(d => d.Project).WithMany(p => p.FreelancerProjects)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Freelance__Proje__1CF15040");
        });

        modelBuilder.Entity<FreelancerRoleMaster>(entity =>
        {
            entity.HasKey(e => e.FreelancerRoleId).HasName("PK__Freelanc__30D0E9994E0D814A");

            entity.ToTable("FreelancerRoleMaster");

            entity.HasIndex(e => e.RoleName, "UQ__Freelanc__8A2B61607AF1974A").IsUnique();

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.RoleName).HasMaxLength(100);
        });

        modelBuilder.Entity<PaymentStatusMaster>(entity =>
        {
            entity.HasKey(e => e.PaymentStatusId).HasName("PK__PaymentS__34F8AC1FAC930F64");

            entity.ToTable("PaymentStatusMaster");

            entity.HasIndex(e => e.PaymentStatusName, "UQ__PaymentS__BBAC58DBE8C6014A").IsUnique();

            entity.Property(e => e.PaymentStatusId).HasColumnName("PaymentStatusID");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.PaymentStatusName).HasMaxLength(50);
        });

        modelBuilder.Entity<ProgressStatusMaster>(entity =>
        {
            entity.HasKey(e => e.ProgressStatusId).HasName("PK__Progress__190CDCD7893F65E0");

            entity.ToTable("ProgressStatusMaster");

            entity.HasIndex(e => e.ProgressStatusName, "UQ__Progress__1E4B0D1E0401C527").IsUnique();

            entity.Property(e => e.ProgressStatusId).HasColumnName("ProgressStatusID");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.ProgressStatusName).HasMaxLength(50);
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.ProjectId).HasName("PK__Projects__761ABED04A04D1AC");

            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
            entity.Property(e => e.Budget).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProjectProgress>(entity =>
        {
            entity.HasKey(e => e.ProgressId).HasName("PK__ProjectP__BAE29C854FC63385");

            entity.ToTable("ProjectProgress");

            entity.Property(e => e.ProgressId).HasColumnName("ProgressID");
            entity.Property(e => e.ProgressStatusId).HasColumnName("ProgressStatusID");
            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
            entity.Property(e => e.TaskName).HasMaxLength(100);
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);

            entity.HasOne(d => d.ProgressStatus).WithMany(p => p.ProjectProgresses)
                .HasForeignKey(d => d.ProgressStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProjectProgress_ProgressStatus");

            entity.HasOne(d => d.Project).WithMany(p => p.ProjectProgresses)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ProjectPr__Proje__21B6055D");
        });

        modelBuilder.Entity<ProjectStatusView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ProjectStatusView");

            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
            entity.Property(e => e.ProjectName).HasMaxLength(100);
            entity.Property(e => e.ProjectStatus)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProjectTypeMaster>(entity =>
        {
            entity.HasKey(e => e.ProjectTypeId).HasName("PK__ProjectT__6F245E43079113AE");

            entity.ToTable("ProjectTypeMaster");

            entity.HasIndex(e => e.ProjectTypeName, "UQ__ProjectT__659139EA3A5E7522").IsUnique();

            entity.Property(e => e.ProjectTypeId).HasColumnName("ProjectTypeID");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.ProjectTypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCAC1908369D");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(225);
            entity.Property(e => e.PasswordHash).HasMaxLength(225);
            entity.Property(e => e.Role).HasMaxLength(50);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
