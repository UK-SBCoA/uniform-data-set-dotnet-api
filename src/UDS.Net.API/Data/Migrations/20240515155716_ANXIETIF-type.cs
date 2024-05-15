using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class ANXIETIFtype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ANXIETIF",
                table: "tbl_D1as",
                type: "int",
                nullable: true,
                comment: "14a. Anxiety disorder (primary/contributing/non-contributing)",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "14a. Anxiety disorder (primary/contributing/non-contributing)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "ANXIETIF",
                table: "tbl_D1as",
                type: "bit",
                nullable: true,
                comment: "14a. Anxiety disorder (primary/contributing/non-contributing)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "14a. Anxiety disorder (primary/contributing/non-contributing)");
        }
    }
}
