using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateVersion4Variables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "RESPOTH",
                table: "tbl_C2s",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "RESPINTR",
                table: "tbl_C2s",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "RESPHEAR",
                table: "tbl_C2s",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "RESPFATG",
                table: "tbl_C2s",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "RESPEMOT",
                table: "tbl_C2s",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "RESPDIST",
                table: "tbl_C2s",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "RESPDISN",
                table: "tbl_C2s",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "RESPASST",
                table: "tbl_C2s",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NEWADEVENT",
                table: "tbl_A4as",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NEWTREAT",
                table: "tbl_A4as",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NWINFKID",
                table: "tbl_A3s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NWINFPAR",
                table: "tbl_A3s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NWINFSIB",
                table: "tbl_A3s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "NEWINF",
                table: "tbl_A2s",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NEWADEVENT",
                table: "tbl_A4as");

            migrationBuilder.DropColumn(
                name: "NEWTREAT",
                table: "tbl_A4as");

            migrationBuilder.DropColumn(
                name: "NWINFKID",
                table: "tbl_A3s");

            migrationBuilder.DropColumn(
                name: "NWINFPAR",
                table: "tbl_A3s");

            migrationBuilder.DropColumn(
                name: "NWINFSIB",
                table: "tbl_A3s");

            migrationBuilder.DropColumn(
                name: "NEWINF",
                table: "tbl_A2s");

            migrationBuilder.AlterColumn<int>(
                name: "RESPOTH",
                table: "tbl_C2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RESPINTR",
                table: "tbl_C2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RESPHEAR",
                table: "tbl_C2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RESPFATG",
                table: "tbl_C2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RESPEMOT",
                table: "tbl_C2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RESPDIST",
                table: "tbl_C2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RESPDISN",
                table: "tbl_C2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RESPASST",
                table: "tbl_C2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);
        }
    }
}
