using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAdministrationFormat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ADMIN",
                table: "tbl_D1bs",
                type: "int",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<int>(
                name: "ADMIN",
                table: "tbl_D1as",
                type: "int",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<int>(
                name: "ADMIN",
                table: "tbl_C2s",
                type: "int",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<int>(
                name: "ADMIN",
                table: "tbl_B9s",
                type: "int",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<int>(
                name: "ADMIN",
                table: "tbl_B8s",
                type: "int",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<int>(
                name: "ADMIN",
                table: "tbl_B7s",
                type: "int",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<int>(
                name: "ADMIN",
                table: "tbl_B6s",
                type: "int",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<int>(
                name: "ADMIN",
                table: "tbl_B5s",
                type: "int",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<int>(
                name: "ADMIN",
                table: "tbl_B4s",
                type: "int",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<int>(
                name: "ADMIN",
                table: "tbl_B3s",
                type: "int",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<int>(
                name: "ADMIN",
                table: "tbl_B1s",
                type: "int",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<int>(
                name: "ADMIN",
                table: "tbl_A5D2s",
                type: "int",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<int>(
                name: "ADMIN",
                table: "tbl_A4s",
                type: "int",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<int>(
                name: "ADMIN",
                table: "tbl_A4as",
                type: "int",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<int>(
                name: "ADMIN",
                table: "tbl_A3s",
                type: "int",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<int>(
                name: "ADMIN",
                table: "tbl_A2s",
                type: "int",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<int>(
                name: "ADMIN",
                table: "tbl_A1s",
                type: "int",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<int>(
                name: "ADMIN",
                table: "tbl_A1as",
                type: "int",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ADMIN",
                table: "tbl_D1bs");

            migrationBuilder.DropColumn(
                name: "ADMIN",
                table: "tbl_D1as");

            migrationBuilder.DropColumn(
                name: "ADMIN",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "ADMIN",
                table: "tbl_B9s");

            migrationBuilder.DropColumn(
                name: "ADMIN",
                table: "tbl_B8s");

            migrationBuilder.DropColumn(
                name: "ADMIN",
                table: "tbl_B7s");

            migrationBuilder.DropColumn(
                name: "ADMIN",
                table: "tbl_B6s");

            migrationBuilder.DropColumn(
                name: "ADMIN",
                table: "tbl_B5s");

            migrationBuilder.DropColumn(
                name: "ADMIN",
                table: "tbl_B4s");

            migrationBuilder.DropColumn(
                name: "ADMIN",
                table: "tbl_B3s");

            migrationBuilder.DropColumn(
                name: "ADMIN",
                table: "tbl_B1s");

            migrationBuilder.DropColumn(
                name: "ADMIN",
                table: "tbl_A5D2s");

            migrationBuilder.DropColumn(
                name: "ADMIN",
                table: "tbl_A4s");

            migrationBuilder.DropColumn(
                name: "ADMIN",
                table: "tbl_A4as");

            migrationBuilder.DropColumn(
                name: "ADMIN",
                table: "tbl_A3s");

            migrationBuilder.DropColumn(
                name: "ADMIN",
                table: "tbl_A2s");

            migrationBuilder.DropColumn(
                name: "ADMIN",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "ADMIN",
                table: "tbl_A1as");
        }
    }
}
