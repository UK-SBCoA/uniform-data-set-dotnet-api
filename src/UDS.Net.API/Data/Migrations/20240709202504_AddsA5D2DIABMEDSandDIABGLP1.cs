using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddsA5D2DIABMEDSandDIABGLP1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "DIABGLP1",
                table: "tbl_A5D2s",
                type: "bit",
                nullable: true,
                comment: "GLP-1 receptor activators");

            migrationBuilder.AddColumn<bool>(
                name: "DIABRECACT",
                table: "tbl_A5D2s",
                type: "bit",
                nullable: true,
                comment: "Other non-insulin, non-GLP-1 receptor activator injection medication");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DIABGLP1",
                table: "tbl_A5D2s");

            migrationBuilder.DropColumn(
                name: "DIABRECACT",
                table: "tbl_A5D2s");
        }
    }
}
