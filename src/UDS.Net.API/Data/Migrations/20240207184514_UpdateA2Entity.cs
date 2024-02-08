using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateA2Entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "INBIRMO",
                table: "tbl_A2s");

            migrationBuilder.DropColumn(
                name: "INBIRYR",
                table: "tbl_A2s");

            migrationBuilder.DropColumn(
                name: "INCALLS",
                table: "tbl_A2s");

            migrationBuilder.DropColumn(
                name: "INEDUC",
                table: "tbl_A2s");

            migrationBuilder.DropColumn(
                name: "INHISP",
                table: "tbl_A2s");

            migrationBuilder.DropColumn(
                name: "INHISPOX",
                table: "tbl_A2s");

            migrationBuilder.DropColumn(
                name: "INRACEX",
                table: "tbl_A2s");

            migrationBuilder.DropColumn(
                name: "INRASECX",
                table: "tbl_A2s");

            migrationBuilder.RenameColumn(
                name: "INVISITS",
                table: "tbl_A2s",
                newName: "INMEMWORS");

            migrationBuilder.RenameColumn(
                name: "INSEX",
                table: "tbl_A2s",
                newName: "INMEMTROUB");

            migrationBuilder.RenameColumn(
                name: "INRATERX",
                table: "tbl_A2s",
                newName: "INCNTMDX");

            migrationBuilder.RenameColumn(
                name: "INRATER",
                table: "tbl_A2s",
                newName: "INMEMTEN");

            migrationBuilder.RenameColumn(
                name: "INRASEC",
                table: "tbl_A2s",
                newName: "INCNTTIM");

            migrationBuilder.RenameColumn(
                name: "INRACE",
                table: "tbl_A2s",
                newName: "INCNTMOD");

            migrationBuilder.RenameColumn(
                name: "INHISPOR",
                table: "tbl_A2s",
                newName: "INCNTFRQ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "INMEMWORS",
                table: "tbl_A2s",
                newName: "INVISITS");

            migrationBuilder.RenameColumn(
                name: "INMEMTROUB",
                table: "tbl_A2s",
                newName: "INSEX");

            migrationBuilder.RenameColumn(
                name: "INMEMTEN",
                table: "tbl_A2s",
                newName: "INRATER");

            migrationBuilder.RenameColumn(
                name: "INCNTTIM",
                table: "tbl_A2s",
                newName: "INRASEC");

            migrationBuilder.RenameColumn(
                name: "INCNTMOD",
                table: "tbl_A2s",
                newName: "INRACE");

            migrationBuilder.RenameColumn(
                name: "INCNTMDX",
                table: "tbl_A2s",
                newName: "INRATERX");

            migrationBuilder.RenameColumn(
                name: "INCNTFRQ",
                table: "tbl_A2s",
                newName: "INHISPOR");

            migrationBuilder.AddColumn<int>(
                name: "INBIRMO",
                table: "tbl_A2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "INBIRYR",
                table: "tbl_A2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "INCALLS",
                table: "tbl_A2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "INEDUC",
                table: "tbl_A2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "INHISP",
                table: "tbl_A2s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "INHISPOX",
                table: "tbl_A2s",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "INRACEX",
                table: "tbl_A2s",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "INRASECX",
                table: "tbl_A2s",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);
        }
    }
}
