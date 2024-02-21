using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class CleanC2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VNTTOTW",
                table: "tbl_C2s",
                newName: "VERBALTEST");

            migrationBuilder.RenameColumn(
                name: "VNTPCNC",
                table: "tbl_C2s",
                newName: "REYMETHOD");

            migrationBuilder.RenameColumn(
                name: "OTRLBRR",
                table: "tbl_C2s",
                newName: "REYDTI");

            migrationBuilder.RenameColumn(
                name: "OTRLBLI",
                table: "tbl_C2s",
                newName: "CERADJ7YES");

            migrationBuilder.RenameColumn(
                name: "OTRLARR",
                table: "tbl_C2s",
                newName: "CERADJ7NO");

            migrationBuilder.RenameColumn(
                name: "OTRLALI",
                table: "tbl_C2s",
                newName: "CERADJ6REC");

            migrationBuilder.RenameColumn(
                name: "OTRAILB",
                table: "tbl_C2s",
                newName: "CERADJ6INT");

            migrationBuilder.RenameColumn(
                name: "OTRAILA",
                table: "tbl_C2s",
                newName: "CERADDTI");

            migrationBuilder.RenameColumn(
                name: "MODCOMM",
                table: "tbl_C2s",
                newName: "CERAD3REC");

            migrationBuilder.AddColumn<int>(
                name: "CERAD1INT",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CERAD1READ",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CERAD1REC",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CERAD2INT",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CERAD2READ",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CERAD2REC",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CERAD3INT",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CERAD3READ",
                table: "tbl_C2s",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CERAD1INT",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "CERAD1READ",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "CERAD1REC",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "CERAD2INT",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "CERAD2READ",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "CERAD2REC",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "CERAD3INT",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "CERAD3READ",
                table: "tbl_C2s");

            migrationBuilder.RenameColumn(
                name: "VERBALTEST",
                table: "tbl_C2s",
                newName: "VNTTOTW");

            migrationBuilder.RenameColumn(
                name: "REYMETHOD",
                table: "tbl_C2s",
                newName: "VNTPCNC");

            migrationBuilder.RenameColumn(
                name: "REYDTI",
                table: "tbl_C2s",
                newName: "OTRLBRR");

            migrationBuilder.RenameColumn(
                name: "CERADJ7YES",
                table: "tbl_C2s",
                newName: "OTRLBLI");

            migrationBuilder.RenameColumn(
                name: "CERADJ7NO",
                table: "tbl_C2s",
                newName: "OTRLARR");

            migrationBuilder.RenameColumn(
                name: "CERADJ6REC",
                table: "tbl_C2s",
                newName: "OTRLALI");

            migrationBuilder.RenameColumn(
                name: "CERADJ6INT",
                table: "tbl_C2s",
                newName: "OTRAILB");

            migrationBuilder.RenameColumn(
                name: "CERADDTI",
                table: "tbl_C2s",
                newName: "OTRAILA");

            migrationBuilder.RenameColumn(
                name: "CERAD3REC",
                table: "tbl_C2s",
                newName: "MODCOMM");
        }
    }
}
