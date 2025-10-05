using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class JobCategoryPostings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobCategory_Posting_JobCategories_CategoryId",
                table: "JobCategory_Posting");

            migrationBuilder.DropForeignKey(
                name: "FK_JobCategory_Posting_JobPostings_JobId",
                table: "JobCategory_Posting");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobCategory_Posting",
                table: "JobCategory_Posting");

            migrationBuilder.RenameTable(
                name: "JobCategory_Posting",
                newName: "JobCategory_Postings");

            migrationBuilder.RenameIndex(
                name: "IX_JobCategory_Posting_JobId",
                table: "JobCategory_Postings",
                newName: "IX_JobCategory_Postings_JobId");

            migrationBuilder.RenameIndex(
                name: "IX_JobCategory_Posting_CategoryId",
                table: "JobCategory_Postings",
                newName: "IX_JobCategory_Postings_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobCategory_Postings",
                table: "JobCategory_Postings",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobCategory_Postings_JobCategories_CategoryId",
                table: "JobCategory_Postings",
                column: "CategoryId",
                principalTable: "JobCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobCategory_Postings_JobPostings_JobId",
                table: "JobCategory_Postings",
                column: "JobId",
                principalTable: "JobPostings",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobCategory_Postings_JobCategories_CategoryId",
                table: "JobCategory_Postings");

            migrationBuilder.DropForeignKey(
                name: "FK_JobCategory_Postings_JobPostings_JobId",
                table: "JobCategory_Postings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobCategory_Postings",
                table: "JobCategory_Postings");

            migrationBuilder.RenameTable(
                name: "JobCategory_Postings",
                newName: "JobCategory_Posting");

            migrationBuilder.RenameIndex(
                name: "IX_JobCategory_Postings_JobId",
                table: "JobCategory_Posting",
                newName: "IX_JobCategory_Posting_JobId");

            migrationBuilder.RenameIndex(
                name: "IX_JobCategory_Postings_CategoryId",
                table: "JobCategory_Posting",
                newName: "IX_JobCategory_Posting_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobCategory_Posting",
                table: "JobCategory_Posting",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobCategory_Posting_JobCategories_CategoryId",
                table: "JobCategory_Posting",
                column: "CategoryId",
                principalTable: "JobCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobCategory_Posting_JobPostings_JobId",
                table: "JobCategory_Posting",
                column: "JobId",
                principalTable: "JobPostings",
                principalColumn: "Id");
        }
    }
}
