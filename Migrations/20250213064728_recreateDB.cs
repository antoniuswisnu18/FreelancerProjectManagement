using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FreelancerProjectManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class recreateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditTrail",
                columns: table => new
                {
                    AuditID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ActionType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EntityName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EntityID = table.Column<int>(type: "int", nullable: true),
                    Timestamp = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AuditTra__A17F23B87BC63FC9", x => x.AuditID);
                });

            migrationBuilder.CreateTable(
                name: "FreelancerRoleMaster",
                columns: table => new
                {
                    FreelancerRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Freelanc__30D0E9994E0D814A", x => x.FreelancerRoleId);
                });

            migrationBuilder.CreateTable(
                name: "Freelancers",
                columns: table => new
                {
                    FreelanceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Skills = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RatePerHour = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    AvailabilityStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Freelanc__5E50CBB586963D71", x => x.FreelanceID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentStatusMaster",
                columns: table => new
                {
                    PaymentStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentStatusName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PaymentS__34F8AC1FAC930F64", x => x.PaymentStatusID);
                });

            migrationBuilder.CreateTable(
                name: "ProgressStatusMaster",
                columns: table => new
                {
                    ProgressStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgressStatusName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Progress__190CDCD7893F65E0", x => x.ProgressStatusID);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Budget = table.Column<decimal>(type: "decimal(15,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Projects__761ABED04A04D1AC", x => x.ProjectID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTypeMaster",
                columns: table => new
                {
                    ProjectTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ProjectT__6F245E43079113AE", x => x.ProjectTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__1788CCAC1908369D", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "FreelancerProject",
                columns: table => new
                {
                    AssignmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FreelancerID = table.Column<int>(type: "int", nullable: false),
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    HourlyRate = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    TotalHours = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    AssignedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    PaymentStatusID = table.Column<int>(type: "int", nullable: false),
                    FreelancerRoleID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Freelanc__32499E5711E0A86D", x => x.AssignmentID);
                    table.ForeignKey(
                        name: "FK_FreelancerProject_FreelancerRoleMaster",
                        column: x => x.FreelancerRoleID,
                        principalTable: "FreelancerRoleMaster",
                        principalColumn: "FreelancerRoleId");
                    table.ForeignKey(
                        name: "FK_FreelancerProject_PaymentStatus",
                        column: x => x.PaymentStatusID,
                        principalTable: "PaymentStatusMaster",
                        principalColumn: "PaymentStatusID");
                    table.ForeignKey(
                        name: "FK__Freelance__Freel__1BFD2C07",
                        column: x => x.FreelancerID,
                        principalTable: "Freelancers",
                        principalColumn: "FreelanceID");
                    table.ForeignKey(
                        name: "FK__Freelance__Proje__1CF15040",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ProjectID");
                });

            migrationBuilder.CreateTable(
                name: "ProjectProgress",
                columns: table => new
                {
                    ProgressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    TaskName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    UpdatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProgressStatusID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ProjectP__BAE29C854FC63385", x => x.ProgressID);
                    table.ForeignKey(
                        name: "FK_ProjectProgress_ProgressStatus",
                        column: x => x.ProgressStatusID,
                        principalTable: "ProgressStatusMaster",
                        principalColumn: "ProgressStatusID");
                    table.ForeignKey(
                        name: "FK__ProjectPr__Proje__21B6055D",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ProjectID");
                });

            migrationBuilder.CreateIndex(
                name: "IDX_AuditTrail_EntityName",
                table: "AuditTrail",
                column: "EntityName");

            migrationBuilder.CreateIndex(
                name: "IDX_AuditTrail_Timestamp",
                table: "AuditTrail",
                column: "Timestamp");

            migrationBuilder.CreateIndex(
                name: "IDX_AuditTrail_UserID",
                table: "AuditTrail",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FreelancerProject_FreelancerID",
                table: "FreelancerProject",
                column: "FreelancerID");

            migrationBuilder.CreateIndex(
                name: "IX_FreelancerProject_FreelancerRoleID",
                table: "FreelancerProject",
                column: "FreelancerRoleID");

            migrationBuilder.CreateIndex(
                name: "IX_FreelancerProject_PaymentStatusID",
                table: "FreelancerProject",
                column: "PaymentStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_FreelancerProject_ProjectID",
                table: "FreelancerProject",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "UQ__Freelanc__8A2B61607AF1974A",
                table: "FreelancerRoleMaster",
                column: "RoleName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__PaymentS__BBAC58DBE8C6014A",
                table: "PaymentStatusMaster",
                column: "PaymentStatusName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Progress__1E4B0D1E0401C527",
                table: "ProgressStatusMaster",
                column: "ProgressStatusName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectProgress_ProgressStatusID",
                table: "ProjectProgress",
                column: "ProgressStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectProgress_ProjectID",
                table: "ProjectProgress",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "UQ__ProjectT__659139EA3A5E7522",
                table: "ProjectTypeMaster",
                column: "ProjectTypeName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditTrail");

            migrationBuilder.DropTable(
                name: "FreelancerProject");

            migrationBuilder.DropTable(
                name: "ProjectProgress");

            migrationBuilder.DropTable(
                name: "ProjectTypeMaster");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "FreelancerRoleMaster");

            migrationBuilder.DropTable(
                name: "PaymentStatusMaster");

            migrationBuilder.DropTable(
                name: "Freelancers");

            migrationBuilder.DropTable(
                name: "ProgressStatusMaster");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
