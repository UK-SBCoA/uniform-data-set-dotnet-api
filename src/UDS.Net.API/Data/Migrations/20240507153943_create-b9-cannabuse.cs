using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class createb9cannabuse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "STRUCTAD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "7a1. Atrophy pattern consistent with AD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "7a1. Atrophy pattern conistent with AD");

            migrationBuilder.AlterColumn<int>(
                name: "IMAGEWMH",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "7a3f. Extensive white-matter hyperintensity (CHS score 7-8+)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "7a3f. Extensive white-matter hyperinensity (CHS score 7-8+)");

            migrationBuilder.AddColumn<bool>(
                name: "CANNABUSE",
                table: "tbl_B9s",
                type: "bit",
                nullable: true,
                comment: "Cannabis use");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CANNABUSE",
                table: "tbl_B9s");

            migrationBuilder.AlterColumn<int>(
                name: "STRUCTAD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "7a1. Atrophy pattern conistent with AD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "7a1. Atrophy pattern consistent with AD");

            migrationBuilder.AlterColumn<int>(
                name: "IMAGEWMH",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "7a3f. Extensive white-matter hyperinensity (CHS score 7-8+)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "7a3f. Extensive white-matter hyperintensity (CHS score 7-8+)");
        }
    }
}
