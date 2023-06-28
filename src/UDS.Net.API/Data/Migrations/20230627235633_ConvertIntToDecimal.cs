using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class ConvertIntToDecimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PERSCARE",
                table: "tbl_B4s",
                type: "decimal(2,1)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ORIENT",
                table: "tbl_B4s",
                type: "decimal(2,1)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "MEMORY",
                table: "tbl_B4s",
                type: "decimal(2,1)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "JUDGMENT",
                table: "tbl_B4s",
                type: "decimal(2,1)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "HOMEHOBB",
                table: "tbl_B4s",
                type: "decimal(2,1)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "COMPORT",
                table: "tbl_B4s",
                type: "decimal(2,1)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "COMMUN",
                table: "tbl_B4s",
                type: "decimal(2,1)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CDRSUM",
                table: "tbl_B4s",
                type: "decimal(3,1)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CDRLANG",
                table: "tbl_B4s",
                type: "decimal(2,1)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CDRGLOB",
                table: "tbl_B4s",
                type: "decimal(2,1)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "HEIGHT",
                table: "tbl_B1s",
                type: "decimal(3,1)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PERSCARE",
                table: "tbl_B4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ORIENT",
                table: "tbl_B4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MEMORY",
                table: "tbl_B4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "JUDGMENT",
                table: "tbl_B4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HOMEHOBB",
                table: "tbl_B4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COMPORT",
                table: "tbl_B4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COMMUN",
                table: "tbl_B4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CDRSUM",
                table: "tbl_B4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CDRLANG",
                table: "tbl_B4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CDRGLOB",
                table: "tbl_B4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HEIGHT",
                table: "tbl_B1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,1)",
                oldNullable: true);
        }
    }
}
