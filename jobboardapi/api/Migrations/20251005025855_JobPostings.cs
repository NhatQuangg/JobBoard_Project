using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class JobPostings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Application_JobPosting_JobId",
                table: "Application");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosting_EmployerProfiles_EmployerID",
                table: "JobPosting");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobPosting",
                table: "JobPosting");

            migrationBuilder.RenameTable(
                name: "JobPosting",
                newName: "JobPostings");

            migrationBuilder.RenameIndex(
                name: "IX_JobPosting_EmployerID",
                table: "JobPostings",
                newName: "IX_JobPostings_EmployerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobPostings",
                table: "JobPostings",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_JobPostings_JobId",
                table: "Application",
                column: "JobId",
                principalTable: "JobPostings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPostings_EmployerProfiles_EmployerID",
                table: "JobPostings",
                column: "EmployerID",
                principalTable: "EmployerProfiles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Application_JobPostings_JobId",
                table: "Application");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPostings_EmployerProfiles_EmployerID",
                table: "JobPostings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobPostings",
                table: "JobPostings");

            migrationBuilder.RenameTable(
                name: "JobPostings",
                newName: "JobPosting");

            migrationBuilder.RenameIndex(
                name: "IX_JobPostings_EmployerID",
                table: "JobPosting",
                newName: "IX_JobPosting_EmployerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobPosting",
                table: "JobPosting",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_JobPosting_JobId",
                table: "Application",
                column: "JobId",
                principalTable: "JobPosting",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosting_EmployerProfiles_EmployerID",
                table: "JobPosting",
                column: "EmployerID",
                principalTable: "EmployerProfiles",
                principalColumn: "Id");
        }
    }
}
