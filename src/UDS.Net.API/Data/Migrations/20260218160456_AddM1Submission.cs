using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddM1Submission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "M1Submissions",
                columns: table => new
                {
                    MilestoneSubmissionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ErrorCount = table.Column<int>(type: "int", nullable: true),
                    M1Id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M1Submissions", x => x.MilestoneSubmissionId);
                    table.ForeignKey(
                        name: "FK_M1Submissions_tbl_M1s_M1Id",
                        column: x => x.M1Id,
                        principalTable: "tbl_M1s",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "M1SubmissionErrors",
                columns: table => new
                {
                    M1SubmissionErrorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormKind = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Message = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AssignedTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<int>(type: "int", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Value = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    StatusChangedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M1SubmissionId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M1SubmissionErrors", x => x.M1SubmissionErrorId);
                    table.ForeignKey(
                        name: "FK_M1SubmissionErrors_M1Submissions_M1SubmissionId",
                        column: x => x.M1SubmissionId,
                        principalTable: "M1Submissions",
                        principalColumn: "MilestoneSubmissionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_M1SubmissionErrors_M1SubmissionId",
                table: "M1SubmissionErrors",
                column: "M1SubmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_M1Submissions_M1Id",
                table: "M1Submissions",
                column: "M1Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "M1SubmissionErrors");

            migrationBuilder.DropTable(
                name: "M1Submissions");
        }
    }
}
