using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddM1Submission2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M1Submission_tbl_M1s_M1FormId",
                table: "M1Submission");

            migrationBuilder.DropForeignKey(
                name: "FK_M1SubmissionError_M1Submission_M1SubmissionId",
                table: "M1SubmissionError");

            migrationBuilder.DropPrimaryKey(
                name: "PK_M1SubmissionError",
                table: "M1SubmissionError");

            migrationBuilder.DropPrimaryKey(
                name: "PK_M1Submission",
                table: "M1Submission");

            migrationBuilder.RenameTable(
                name: "M1SubmissionError",
                newName: "M1SubmissionErrors");

            migrationBuilder.RenameTable(
                name: "M1Submission",
                newName: "M1Submissions");

            migrationBuilder.RenameIndex(
                name: "IX_M1SubmissionError_M1SubmissionId",
                table: "M1SubmissionErrors",
                newName: "IX_M1SubmissionErrors_M1SubmissionId");

            migrationBuilder.RenameIndex(
                name: "IX_M1Submission_M1FormId",
                table: "M1Submissions",
                newName: "IX_M1Submissions_M1FormId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "tbl_M1s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_M1SubmissionErrors",
                table: "M1SubmissionErrors",
                column: "M1SubmissionErrorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_M1Submissions",
                table: "M1Submissions",
                column: "MilestoneSubmissionId");

            migrationBuilder.AddForeignKey(
                name: "FK_M1SubmissionErrors_M1Submissions_M1SubmissionId",
                table: "M1SubmissionErrors",
                column: "M1SubmissionId",
                principalTable: "M1Submissions",
                principalColumn: "MilestoneSubmissionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_M1Submissions_tbl_M1s_M1FormId",
                table: "M1Submissions",
                column: "M1FormId",
                principalTable: "tbl_M1s",
                principalColumn: "FormId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_M1SubmissionErrors_M1Submissions_M1SubmissionId",
                table: "M1SubmissionErrors");

            migrationBuilder.DropForeignKey(
                name: "FK_M1Submissions_tbl_M1s_M1FormId",
                table: "M1Submissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_M1Submissions",
                table: "M1Submissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_M1SubmissionErrors",
                table: "M1SubmissionErrors");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "tbl_M1s");

            migrationBuilder.RenameTable(
                name: "M1Submissions",
                newName: "M1Submission");

            migrationBuilder.RenameTable(
                name: "M1SubmissionErrors",
                newName: "M1SubmissionError");

            migrationBuilder.RenameIndex(
                name: "IX_M1Submissions_M1FormId",
                table: "M1Submission",
                newName: "IX_M1Submission_M1FormId");

            migrationBuilder.RenameIndex(
                name: "IX_M1SubmissionErrors_M1SubmissionId",
                table: "M1SubmissionError",
                newName: "IX_M1SubmissionError_M1SubmissionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_M1Submission",
                table: "M1Submission",
                column: "MilestoneSubmissionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_M1SubmissionError",
                table: "M1SubmissionError",
                column: "M1SubmissionErrorId");

            migrationBuilder.AddForeignKey(
                name: "FK_M1Submission_tbl_M1s_M1FormId",
                table: "M1Submission",
                column: "M1FormId",
                principalTable: "tbl_M1s",
                principalColumn: "FormId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_M1SubmissionError_M1Submission_M1SubmissionId",
                table: "M1SubmissionError",
                column: "M1SubmissionId",
                principalTable: "M1Submission",
                principalColumn: "MilestoneSubmissionId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
