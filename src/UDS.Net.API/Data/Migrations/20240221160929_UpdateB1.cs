using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateB1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BPDIAS",
                table: "tbl_B1s");

            migrationBuilder.DropColumn(
                name: "BPSYS",
                table: "tbl_B1s");

            migrationBuilder.DropColumn(
                name: "HEARAID",
                table: "tbl_B1s");

            migrationBuilder.DropColumn(
                name: "HEARING",
                table: "tbl_B1s");

            migrationBuilder.DropColumn(
                name: "HEARWAID",
                table: "tbl_B1s");

            migrationBuilder.DropColumn(
                name: "VISCORR",
                table: "tbl_B1s");

            migrationBuilder.DropColumn(
                name: "VISION",
                table: "tbl_B1s");

            migrationBuilder.DropColumn(
                name: "VISWCORR",
                table: "tbl_B1s");

            migrationBuilder.AlterColumn<int>(
                name: "WEIGHT",
                table: "tbl_B1s",
                type: "int",
                nullable: true,
                comment: "Participant weight (lbs.)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HRATE",
                table: "tbl_B1s",
                type: "int",
                nullable: true,
                comment: "Participant resting heart rate (pulse)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "HEIGHT",
                table: "tbl_B1s",
                type: "decimal(3,1)",
                nullable: true,
                comment: "Participant height (inches)",
                oldClrType: typeof(decimal),
                oldType: "decimal(3,1)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BPDIASL1",
                table: "tbl_B1s",
                type: "int",
                nullable: true,
                comment: " Participant blood pressure - Left arm: Diastolic Reading 1");

            migrationBuilder.AddColumn<int>(
                name: "BPDIASL2",
                table: "tbl_B1s",
                type: "int",
                nullable: true,
                comment: " Participant blood pressure - Left arm: Diastolic Reading 2");

            migrationBuilder.AddColumn<int>(
                name: "BPDIASR1",
                table: "tbl_B1s",
                type: "int",
                nullable: true,
                comment: "Participant blood pressure - Right arm: Diastolic Reading 1");

            migrationBuilder.AddColumn<int>(
                name: "BPDIASR2",
                table: "tbl_B1s",
                type: "int",
                nullable: true,
                comment: "Participant blood pressure - Right arm: Diastolic Reading 2");

            migrationBuilder.AddColumn<int>(
                name: "BPSYSL1",
                table: "tbl_B1s",
                type: "int",
                nullable: true,
                comment: "Participant blood pressure - Left arm: Systolic Reading 1");

            migrationBuilder.AddColumn<int>(
                name: "BPSYSL2",
                table: "tbl_B1s",
                type: "int",
                nullable: true,
                comment: "Participant blood pressure - Left arm: Systolic Reading 2");

            migrationBuilder.AddColumn<int>(
                name: "BPSYSR1",
                table: "tbl_B1s",
                type: "int",
                nullable: true,
                comment: "Participant blood pressure - Right arm: Systolic Reading 1");

            migrationBuilder.AddColumn<int>(
                name: "BPSYSR2",
                table: "tbl_B1s",
                type: "int",
                nullable: true,
                comment: "Participant blood pressure - Right arm: Systolic Reading 2");

            migrationBuilder.AddColumn<int>(
                name: "HIP1",
                table: "tbl_B1s",
                type: "int",
                nullable: true,
                comment: "Hip circumference measurements (inches): Measurement 1");

            migrationBuilder.AddColumn<int>(
                name: "HIP2",
                table: "tbl_B1s",
                type: "int",
                nullable: true,
                comment: "Hip circumference measurements (inches): Measurement 2");

            migrationBuilder.AddColumn<int>(
                name: "WAIST1",
                table: "tbl_B1s",
                type: "int",
                nullable: true,
                comment: "Waist circumference measurements (inches): Measurement 1");

            migrationBuilder.AddColumn<int>(
                name: "WAIST2",
                table: "tbl_B1s",
                type: "int",
                nullable: true,
                comment: "Waist circumference measurements (inches): Measurement 2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BPDIASL1",
                table: "tbl_B1s");

            migrationBuilder.DropColumn(
                name: "BPDIASL2",
                table: "tbl_B1s");

            migrationBuilder.DropColumn(
                name: "BPDIASR1",
                table: "tbl_B1s");

            migrationBuilder.DropColumn(
                name: "BPDIASR2",
                table: "tbl_B1s");

            migrationBuilder.DropColumn(
                name: "BPSYSL1",
                table: "tbl_B1s");

            migrationBuilder.DropColumn(
                name: "BPSYSL2",
                table: "tbl_B1s");

            migrationBuilder.DropColumn(
                name: "BPSYSR1",
                table: "tbl_B1s");

            migrationBuilder.DropColumn(
                name: "BPSYSR2",
                table: "tbl_B1s");

            migrationBuilder.DropColumn(
                name: "HIP1",
                table: "tbl_B1s");

            migrationBuilder.DropColumn(
                name: "HIP2",
                table: "tbl_B1s");

            migrationBuilder.DropColumn(
                name: "WAIST1",
                table: "tbl_B1s");

            migrationBuilder.DropColumn(
                name: "WAIST2",
                table: "tbl_B1s");

            migrationBuilder.AlterColumn<int>(
                name: "WEIGHT",
                table: "tbl_B1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Participant weight (lbs.)");

            migrationBuilder.AlterColumn<int>(
                name: "HRATE",
                table: "tbl_B1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Participant resting heart rate (pulse)");

            migrationBuilder.AlterColumn<decimal>(
                name: "HEIGHT",
                table: "tbl_B1s",
                type: "decimal(3,1)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,1)",
                oldNullable: true,
                oldComment: "Participant height (inches)");

            migrationBuilder.AddColumn<int>(
                name: "BPDIAS",
                table: "tbl_B1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BPSYS",
                table: "tbl_B1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HEARAID",
                table: "tbl_B1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HEARING",
                table: "tbl_B1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HEARWAID",
                table: "tbl_B1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VISCORR",
                table: "tbl_B1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VISION",
                table: "tbl_B1s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VISWCORR",
                table: "tbl_B1s",
                type: "int",
                nullable: true);
        }
    }
}
