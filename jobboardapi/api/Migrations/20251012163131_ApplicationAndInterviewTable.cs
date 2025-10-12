using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class ApplicationAndInterviewTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Application_CandidateProfiles_CandidateId",
                table: "Application");

            migrationBuilder.DropForeignKey(
                name: "FK_Application_JobPostings_JobId",
                table: "Application");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Application",
                table: "Application");

            migrationBuilder.RenameTable(
                name: "Application",
                newName: "Applications");

            migrationBuilder.RenameIndex(
                name: "IX_Application_JobId",
                table: "Applications",
                newName: "IX_Applications_JobId");

            migrationBuilder.RenameIndex(
                name: "IX_Application_CandidateId",
                table: "Applications",
                newName: "IX_Applications_CandidateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Applications",
                table: "Applications",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Interviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    InterviewType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Location = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Notes = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ScheduledAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ApplicationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interviews_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_ApplicationId",
                table: "Interviews",
                column: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_CandidateProfiles_CandidateId",
                table: "Applications",
                column: "CandidateId",
                principalTable: "CandidateProfiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_JobPostings_JobId",
                table: "Applications",
                column: "JobId",
                principalTable: "JobPostings",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_CandidateProfiles_CandidateId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_JobPostings_JobId",
                table: "Applications");

            migrationBuilder.DropTable(
                name: "Interviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Applications",
                table: "Applications");

            migrationBuilder.RenameTable(
                name: "Applications",
                newName: "Application");

            migrationBuilder.RenameIndex(
                name: "IX_Applications_JobId",
                table: "Application",
                newName: "IX_Application_JobId");

            migrationBuilder.RenameIndex(
                name: "IX_Applications_CandidateId",
                table: "Application",
                newName: "IX_Application_CandidateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Application",
                table: "Application",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_CandidateProfiles_CandidateId",
                table: "Application",
                column: "CandidateId",
                principalTable: "CandidateProfiles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_JobPostings_JobId",
                table: "Application",
                column: "JobId",
                principalTable: "JobPostings",
                principalColumn: "Id");
        }
    }
}
