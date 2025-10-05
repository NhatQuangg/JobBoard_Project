using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class SaveJobs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPostings_EmployerProfiles_EmployerID",
                table: "JobPostings");

            migrationBuilder.RenameColumn(
                name: "EmployerID",
                table: "JobPostings",
                newName: "EmployerId");

            migrationBuilder.RenameIndex(
                name: "IX_JobPostings_EmployerID",
                table: "JobPostings",
                newName: "IX_JobPostings_EmployerId");

            migrationBuilder.CreateTable(
                name: "SavedJobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SavedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    JobId = table.Column<int>(type: "int", nullable: false),
                    CandidateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedJobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SavedJobs_CandidateProfiles_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "CandidateProfiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SavedJobs_JobPostings_JobId",
                        column: x => x.JobId,
                        principalTable: "JobPostings",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_SavedJobs_CandidateId",
                table: "SavedJobs",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_SavedJobs_JobId",
                table: "SavedJobs",
                column: "JobId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPostings_EmployerProfiles_EmployerId",
                table: "JobPostings",
                column: "EmployerId",
                principalTable: "EmployerProfiles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPostings_EmployerProfiles_EmployerId",
                table: "JobPostings");

            migrationBuilder.DropTable(
                name: "SavedJobs");

            migrationBuilder.RenameColumn(
                name: "EmployerId",
                table: "JobPostings",
                newName: "EmployerID");

            migrationBuilder.RenameIndex(
                name: "IX_JobPostings_EmployerId",
                table: "JobPostings",
                newName: "IX_JobPostings_EmployerID");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPostings_EmployerProfiles_EmployerID",
                table: "JobPostings",
                column: "EmployerID",
                principalTable: "EmployerProfiles",
                principalColumn: "Id");
        }
    }
}
