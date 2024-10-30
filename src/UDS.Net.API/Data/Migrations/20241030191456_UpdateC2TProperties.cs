using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateC2TProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MOCBTOTS",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OTRAILA",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OTRAILB",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OTRLALI",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OTRLARR",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OTRLBLI",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OTRLBRR",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VNTPCNC",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VNTTOTW",
                table: "tbl_C2s",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MOCBTOTS",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "OTRAILA",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "OTRAILB",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "OTRLALI",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "OTRLARR",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "OTRLBLI",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "OTRLBRR",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "VNTPCNC",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "VNTTOTW",
                table: "tbl_C2s");
        }
    }
}
