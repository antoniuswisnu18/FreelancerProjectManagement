﻿// <auto-generated />
using System;
using FreelancerProjectManagementAPI.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FreelancerProjectManagementAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250213064728_recreateDB")]
    partial class recreateDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FreelancerProjectManagementAPI.Models.AuditTrail", b =>
                {
                    b.Property<int>("AuditId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AuditID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuditId"));

                    b.Property<string>("ActionType")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EntityId")
                        .HasColumnType("int")
                        .HasColumnName("EntityID");

                    b.Property<string>("EntityName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Ipaddress")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("IPAddress");

                    b.Property<DateTime>("Timestamp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AuditId")
                        .HasName("PK__AuditTra__A17F23B87BC63FC9");

                    b.HasIndex(new[] { "EntityName" }, "IDX_AuditTrail_EntityName");

                    b.HasIndex(new[] { "Timestamp" }, "IDX_AuditTrail_Timestamp");

                    b.HasIndex(new[] { "UserId" }, "IDX_AuditTrail_UserID");

                    b.ToTable("AuditTrail", (string)null);
                });

            modelBuilder.Entity("FreelancerProjectManagementAPI.Models.EarningsReportView", b =>
                {
                    b.Property<int>("FreelanceId")
                        .HasColumnType("int")
                        .HasColumnName("FreelanceID");

                    b.Property<string>("FreelancerName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasMaxLength(18)
                        .IsUnicode(false)
                        .HasColumnType("varchar(18)");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("int")
                        .HasColumnName("ProjectID");

                    b.Property<string>("ProjectName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal?>("TotalEarnings")
                        .HasColumnType("decimal(38, 4)");

                    b.Property<decimal?>("TotalHours")
                        .HasColumnType("decimal(38, 2)");

                    b.Property<int?>("TotalProjects")
                        .HasColumnType("int");

                    b.ToTable((string)null);

                    b.ToView("EarningsReportView", (string)null);
                });

            modelBuilder.Entity("FreelancerProjectManagementAPI.Models.Freelancer", b =>
                {
                    b.Property<int>("FreelanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("FreelanceID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FreelanceId"));

                    b.Property<string>("AvailabilityStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("RatePerHour")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<string>("Skills")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.HasKey("FreelanceId")
                        .HasName("PK__Freelanc__5E50CBB586963D71");

                    b.ToTable("Freelancers");
                });

            modelBuilder.Entity("FreelancerProjectManagementAPI.Models.FreelancerPerformanceView", b =>
                {
                    b.Property<int?>("AvgCompletionTime")
                        .HasColumnType("int");

                    b.Property<int?>("CompletedTasks")
                        .HasColumnType("int");

                    b.Property<double?>("CompletionRate")
                        .HasColumnType("float");

                    b.Property<int>("FreelanceId")
                        .HasColumnType("int")
                        .HasColumnName("FreelanceID");

                    b.Property<string>("FreelancerName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("LastUpdatedProject")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("LastUpdatedTask")
                        .HasColumnType("datetime");

                    b.Property<int?>("TotalProjects")
                        .HasColumnType("int");

                    b.Property<int?>("TotalTasks")
                        .HasColumnType("int");

                    b.ToTable((string)null);

                    b.ToView("FreelancerPerformanceView", (string)null);
                });

            modelBuilder.Entity("FreelancerProjectManagementAPI.Models.FreelancerProject", b =>
                {
                    b.Property<int>("AssignmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AssignmentID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AssignmentId"));

                    b.Property<DateTime>("AssignedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("FreelancerId")
                        .HasColumnType("int")
                        .HasColumnName("FreelancerID");

                    b.Property<int?>("FreelancerRoleId")
                        .HasColumnType("int")
                        .HasColumnName("FreelancerRoleID");

                    b.Property<decimal>("HourlyRate")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("PaymentStatusId")
                        .HasColumnType("int")
                        .HasColumnName("PaymentStatusID");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int")
                        .HasColumnName("ProjectID");

                    b.Property<decimal?>("TotalHours")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("AssignmentId")
                        .HasName("PK__Freelanc__32499E5711E0A86D");

                    b.HasIndex("FreelancerId");

                    b.HasIndex("FreelancerRoleId");

                    b.HasIndex("PaymentStatusId");

                    b.HasIndex("ProjectId");

                    b.ToTable("FreelancerProject", (string)null);
                });

            modelBuilder.Entity("FreelancerProjectManagementAPI.Models.FreelancerRoleMaster", b =>
                {
                    b.Property<int>("FreelancerRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FreelancerRoleId"));

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("FreelancerRoleId")
                        .HasName("PK__Freelanc__30D0E9994E0D814A");

                    b.HasIndex(new[] { "RoleName" }, "UQ__Freelanc__8A2B61607AF1974A")
                        .IsUnique();

                    b.ToTable("FreelancerRoleMaster", (string)null);
                });

            modelBuilder.Entity("FreelancerProjectManagementAPI.Models.PaymentStatusMaster", b =>
                {
                    b.Property<int>("PaymentStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PaymentStatusID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentStatusId"));

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PaymentStatusName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PaymentStatusId")
                        .HasName("PK__PaymentS__34F8AC1FAC930F64");

                    b.HasIndex(new[] { "PaymentStatusName" }, "UQ__PaymentS__BBAC58DBE8C6014A")
                        .IsUnique();

                    b.ToTable("PaymentStatusMaster", (string)null);
                });

            modelBuilder.Entity("FreelancerProjectManagementAPI.Models.ProgressStatusMaster", b =>
                {
                    b.Property<int>("ProgressStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProgressStatusID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProgressStatusId"));

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ProgressStatusName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ProgressStatusId")
                        .HasName("PK__Progress__190CDCD7893F65E0");

                    b.HasIndex(new[] { "ProgressStatusName" }, "UQ__Progress__1E4B0D1E0401C527")
                        .IsUnique();

                    b.ToTable("ProgressStatusMaster", (string)null);
                });

            modelBuilder.Entity("FreelancerProjectManagementAPI.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProjectID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectId"));

                    b.Property<decimal>("Budget")
                        .HasColumnType("decimal(15, 2)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.HasKey("ProjectId")
                        .HasName("PK__Projects__761ABED04A04D1AC");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("FreelancerProjectManagementAPI.Models.ProjectProgress", b =>
                {
                    b.Property<int>("ProgressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProgressID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProgressId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly?>("EndDate")
                        .HasColumnType("date");

                    b.Property<int>("ProgressStatusId")
                        .HasColumnType("int")
                        .HasColumnName("ProgressStatusID");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int")
                        .HasColumnName("ProjectID");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ProgressId")
                        .HasName("PK__ProjectP__BAE29C854FC63385");

                    b.HasIndex("ProgressStatusId");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectProgress", (string)null);
                });

            modelBuilder.Entity("FreelancerProjectManagementAPI.Models.ProjectStatusView", b =>
                {
                    b.Property<int?>("CompletedTasks")
                        .HasColumnType("int");

                    b.Property<double?>("CompletionPercentage")
                        .HasColumnType("float");

                    b.Property<int?>("DelayedTasks")
                        .HasColumnType("int");

                    b.Property<int?>("InProgressTasks")
                        .HasColumnType("int");

                    b.Property<int?>("PendingTasks")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int")
                        .HasColumnName("ProjectID");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ProjectStatus")
                        .IsRequired()
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)");

                    b.Property<int?>("TotalTasks")
                        .HasColumnType("int");

                    b.ToTable((string)null);

                    b.ToView("ProjectStatusView", (string)null);
                });

            modelBuilder.Entity("FreelancerProjectManagementAPI.Models.ProjectTypeMaster", b =>
                {
                    b.Property<int>("ProjectTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProjectTypeID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectTypeId"));

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ProjectTypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ProjectTypeId")
                        .HasName("PK__ProjectT__6F245E43079113AE");

                    b.HasIndex(new[] { "ProjectTypeName" }, "UQ__ProjectT__659139EA3A5E7522")
                        .IsUnique();

                    b.ToTable("ProjectTypeMaster", (string)null);
                });

            modelBuilder.Entity("FreelancerProjectManagementAPI.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(225)
                        .HasColumnType("nvarchar(225)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(225)
                        .HasColumnType("nvarchar(225)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("UserId")
                        .HasName("PK__Users__1788CCAC1908369D");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FreelancerProjectManagementAPI.Models.FreelancerProject", b =>
                {
                    b.HasOne("FreelancerProjectManagementAPI.Models.Freelancer", "Freelancer")
                        .WithMany("FreelancerProjects")
                        .HasForeignKey("FreelancerId")
                        .IsRequired()
                        .HasConstraintName("FK__Freelance__Freel__1BFD2C07");

                    b.HasOne("FreelancerProjectManagementAPI.Models.FreelancerRoleMaster", "FreelancerRole")
                        .WithMany("FreelancerProjects")
                        .HasForeignKey("FreelancerRoleId")
                        .HasConstraintName("FK_FreelancerProject_FreelancerRoleMaster");

                    b.HasOne("FreelancerProjectManagementAPI.Models.PaymentStatusMaster", "PaymentStatus")
                        .WithMany("FreelancerProjects")
                        .HasForeignKey("PaymentStatusId")
                        .IsRequired()
                        .HasConstraintName("FK_FreelancerProject_PaymentStatus");

                    b.HasOne("FreelancerProjectManagementAPI.Models.Project", "Project")
                        .WithMany("FreelancerProjects")
                        .HasForeignKey("ProjectId")
                        .IsRequired()
                        .HasConstraintName("FK__Freelance__Proje__1CF15040");

                    b.Navigation("Freelancer");

                    b.Navigation("FreelancerRole");

                    b.Navigation("PaymentStatus");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("FreelancerProjectManagementAPI.Models.ProjectProgress", b =>
                {
                    b.HasOne("FreelancerProjectManagementAPI.Models.ProgressStatusMaster", "ProgressStatus")
                        .WithMany("ProjectProgresses")
                        .HasForeignKey("ProgressStatusId")
                        .IsRequired()
                        .HasConstraintName("FK_ProjectProgress_ProgressStatus");

                    b.HasOne("FreelancerProjectManagementAPI.Models.Project", "Project")
                        .WithMany("ProjectProgresses")
                        .HasForeignKey("ProjectId")
                        .IsRequired()
                        .HasConstraintName("FK__ProjectPr__Proje__21B6055D");

                    b.Navigation("ProgressStatus");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("FreelancerProjectManagementAPI.Models.Freelancer", b =>
                {
                    b.Navigation("FreelancerProjects");
                });

            modelBuilder.Entity("FreelancerProjectManagementAPI.Models.FreelancerRoleMaster", b =>
                {
                    b.Navigation("FreelancerProjects");
                });

            modelBuilder.Entity("FreelancerProjectManagementAPI.Models.PaymentStatusMaster", b =>
                {
                    b.Navigation("FreelancerProjects");
                });

            modelBuilder.Entity("FreelancerProjectManagementAPI.Models.ProgressStatusMaster", b =>
                {
                    b.Navigation("ProjectProgresses");
                });

            modelBuilder.Entity("FreelancerProjectManagementAPI.Models.Project", b =>
                {
                    b.Navigation("FreelancerProjects");

                    b.Navigation("ProjectProgresses");
                });
#pragma warning restore 612, 618
        }
    }
}
