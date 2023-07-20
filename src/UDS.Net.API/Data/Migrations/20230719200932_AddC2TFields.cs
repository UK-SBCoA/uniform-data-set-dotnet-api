using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddC2TFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MODCOMM",
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
                name: "RESPASST",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RESPDISN",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RESPDIST",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RESPEMOT",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RESPFATG",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RESPHEAR",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RESPINTR",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RESPOTH",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RESPOTHX",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RESPVAL",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "REY1INT",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "REY1REC",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "REY2INT",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "REY2REC",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "REY3INT",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "REY3REC",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "REY4INT",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "REY4REC",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "REY5INT",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "REY5REC",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "REY6INT",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "REY6REC",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "REYDINT",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "REYDREC",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "REYFPOS",
                table: "tbl_C2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "REYTCOR",
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
                name: "MODCOMM",
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
                name: "RESPASST",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "RESPDISN",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "RESPDIST",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "RESPEMOT",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "RESPFATG",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "RESPHEAR",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "RESPINTR",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "RESPOTH",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "RESPOTHX",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "RESPVAL",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "REY1INT",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "REY1REC",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "REY2INT",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "REY2REC",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "REY3INT",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "REY3REC",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "REY4INT",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "REY4REC",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "REY5INT",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "REY5REC",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "REY6INT",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "REY6REC",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "REYDINT",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "REYDREC",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "REYFPOS",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "REYTCOR",
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
