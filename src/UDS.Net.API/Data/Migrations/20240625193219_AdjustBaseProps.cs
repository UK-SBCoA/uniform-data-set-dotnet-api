using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdjustBaseProps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Version",
                table: "tbl_Visits");

            migrationBuilder.DropColumn(
                name: "SUB",
                table: "tbl_T1s");

            migrationBuilder.DropColumn(
                name: "SUB",
                table: "tbl_D1bs");

            migrationBuilder.DropColumn(
                name: "SUB",
                table: "tbl_D1as");

            migrationBuilder.DropColumn(
                name: "SUB",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "SUB",
                table: "tbl_C1s");

            migrationBuilder.DropColumn(
                name: "SUB",
                table: "tbl_B9s");

            migrationBuilder.DropColumn(
                name: "SUB",
                table: "tbl_B8s");

            migrationBuilder.DropColumn(
                name: "SUB",
                table: "tbl_B7s");

            migrationBuilder.DropColumn(
                name: "SUB",
                table: "tbl_B6s");

            migrationBuilder.DropColumn(
                name: "SUB",
                table: "tbl_B5s");

            migrationBuilder.DropColumn(
                name: "SUB",
                table: "tbl_B4s");

            migrationBuilder.DropColumn(
                name: "SUB",
                table: "tbl_B3s");

            migrationBuilder.DropColumn(
                name: "SUB",
                table: "tbl_B1s");

            migrationBuilder.DropColumn(
                name: "SUB",
                table: "tbl_A5D2s");

            migrationBuilder.DropColumn(
                name: "SUB",
                table: "tbl_A4s");

            migrationBuilder.DropColumn(
                name: "SUB",
                table: "tbl_A4as");

            migrationBuilder.DropColumn(
                name: "SUB",
                table: "tbl_A3s");

            migrationBuilder.DropColumn(
                name: "SUB",
                table: "tbl_A2s");

            migrationBuilder.DropColumn(
                name: "SUB",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "SUB",
                table: "tbl_A1as");

            migrationBuilder.RenameColumn(
                name: "StartDateTime",
                table: "tbl_Visits",
                newName: "VISIT_DATE");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "tbl_Visits",
                newName: "VISITNUM");

            migrationBuilder.RenameColumn(
                name: "Kind",
                table: "tbl_Visits",
                newName: "INITIALS");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Visits_ParticipationId_Number",
                table: "tbl_Visits",
                newName: "IX_tbl_Visits_ParticipationId_VISITNUM");

            migrationBuilder.RenameColumn(
                name: "REMOTEREASON",
                table: "tbl_T1s",
                newName: "RMREASON");

            migrationBuilder.RenameColumn(
                name: "REMOTEMODE",
                table: "tbl_T1s",
                newName: "RMMODE");

            migrationBuilder.RenameColumn(
                name: "REMOTEREASON",
                table: "tbl_D1bs",
                newName: "RMREASON");

            migrationBuilder.RenameColumn(
                name: "REMOTEMODE",
                table: "tbl_D1bs",
                newName: "RMMODE");

            migrationBuilder.RenameColumn(
                name: "REMOTEREASON",
                table: "tbl_D1as",
                newName: "RMREASON");

            migrationBuilder.RenameColumn(
                name: "REMOTEMODE",
                table: "tbl_D1as",
                newName: "RMMODE");

            migrationBuilder.RenameColumn(
                name: "REMOTEREASON",
                table: "tbl_C2s",
                newName: "RMREASON");

            migrationBuilder.RenameColumn(
                name: "REMOTEMODE",
                table: "tbl_C2s",
                newName: "RMMODE");

            migrationBuilder.RenameColumn(
                name: "REMOTEREASON",
                table: "tbl_C1s",
                newName: "RMREASON");

            migrationBuilder.RenameColumn(
                name: "REMOTEMODE",
                table: "tbl_C1s",
                newName: "RMMODE");

            migrationBuilder.RenameColumn(
                name: "REMOTEREASON",
                table: "tbl_B9s",
                newName: "RMREASON");

            migrationBuilder.RenameColumn(
                name: "REMOTEMODE",
                table: "tbl_B9s",
                newName: "RMMODE");

            migrationBuilder.RenameColumn(
                name: "REMOTEREASON",
                table: "tbl_B8s",
                newName: "RMREASON");

            migrationBuilder.RenameColumn(
                name: "REMOTEMODE",
                table: "tbl_B8s",
                newName: "RMMODE");

            migrationBuilder.RenameColumn(
                name: "REMOTEREASON",
                table: "tbl_B7s",
                newName: "RMREASON");

            migrationBuilder.RenameColumn(
                name: "REMOTEMODE",
                table: "tbl_B7s",
                newName: "RMMODE");

            migrationBuilder.RenameColumn(
                name: "REMOTEREASON",
                table: "tbl_B6s",
                newName: "RMREASON");

            migrationBuilder.RenameColumn(
                name: "REMOTEMODE",
                table: "tbl_B6s",
                newName: "RMMODE");

            migrationBuilder.RenameColumn(
                name: "REMOTEREASON",
                table: "tbl_B5s",
                newName: "RMREASON");

            migrationBuilder.RenameColumn(
                name: "REMOTEMODE",
                table: "tbl_B5s",
                newName: "RMMODE");

            migrationBuilder.RenameColumn(
                name: "REMOTEREASON",
                table: "tbl_B4s",
                newName: "RMREASON");

            migrationBuilder.RenameColumn(
                name: "REMOTEMODE",
                table: "tbl_B4s",
                newName: "RMMODE");

            migrationBuilder.RenameColumn(
                name: "REMOTEREASON",
                table: "tbl_B3s",
                newName: "RMREASON");

            migrationBuilder.RenameColumn(
                name: "REMOTEMODE",
                table: "tbl_B3s",
                newName: "RMMODE");

            migrationBuilder.RenameColumn(
                name: "REMOTEREASON",
                table: "tbl_B1s",
                newName: "RMREASON");

            migrationBuilder.RenameColumn(
                name: "REMOTEMODE",
                table: "tbl_B1s",
                newName: "RMMODE");

            migrationBuilder.RenameColumn(
                name: "REMOTEREASON",
                table: "tbl_A5D2s",
                newName: "RMREASON");

            migrationBuilder.RenameColumn(
                name: "REMOTEMODE",
                table: "tbl_A5D2s",
                newName: "RMMODE");

            migrationBuilder.RenameColumn(
                name: "REMOTEREASON",
                table: "tbl_A4s",
                newName: "RMREASON");

            migrationBuilder.RenameColumn(
                name: "REMOTEMODE",
                table: "tbl_A4s",
                newName: "RMMODE");

            migrationBuilder.RenameColumn(
                name: "REMOTEREASON",
                table: "tbl_A4as",
                newName: "RMREASON");

            migrationBuilder.RenameColumn(
                name: "REMOTEMODE",
                table: "tbl_A4as",
                newName: "RMMODE");

            migrationBuilder.RenameColumn(
                name: "REMOTEREASON",
                table: "tbl_A3s",
                newName: "RMREASON");

            migrationBuilder.RenameColumn(
                name: "REMOTEMODE",
                table: "tbl_A3s",
                newName: "RMMODE");

            migrationBuilder.RenameColumn(
                name: "REMOTEREASON",
                table: "tbl_A2s",
                newName: "RMREASON");

            migrationBuilder.RenameColumn(
                name: "REMOTEMODE",
                table: "tbl_A2s",
                newName: "RMMODE");

            migrationBuilder.RenameColumn(
                name: "REMOTEREASON",
                table: "tbl_A1s",
                newName: "RMREASON");

            migrationBuilder.RenameColumn(
                name: "REMOTEMODE",
                table: "tbl_A1s",
                newName: "RMMODE");

            migrationBuilder.RenameColumn(
                name: "REMOTEREASON",
                table: "tbl_A1as",
                newName: "RMREASON");

            migrationBuilder.RenameColumn(
                name: "REMOTEMODE",
                table: "tbl_A1as",
                newName: "RMMODE");

            migrationBuilder.AddColumn<int>(
                name: "DSSDUB",
                table: "tbl_Visits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FORMVER",
                table: "tbl_Visits",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PACKET",
                table: "tbl_Visits",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_T1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_T1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_T1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<int>(
                name: "RMREASON",
                table: "tbl_T1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "RMMODE",
                table: "tbl_T1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AddColumn<DateTime>(
                name: "FRMDATE",
                table: "tbl_T1s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AddColumn<string>(
                name: "INITIALS",
                table: "tbl_T1s",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<int>(
                name: "RMREASON",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "RMMODE",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AddColumn<DateTime>(
                name: "FRMDATE",
                table: "tbl_D1bs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AddColumn<string>(
                name: "INITIALS",
                table: "tbl_D1bs",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_D1as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_D1as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_D1as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<int>(
                name: "RMREASON",
                table: "tbl_D1as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "RMMODE",
                table: "tbl_D1as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AddColumn<DateTime>(
                name: "FRMDATE",
                table: "tbl_D1as",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AddColumn<string>(
                name: "INITIALS",
                table: "tbl_D1as",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_C2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_C2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_C2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<int>(
                name: "RMREASON",
                table: "tbl_C2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "RMMODE",
                table: "tbl_C2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AddColumn<DateTime>(
                name: "FRMDATE",
                table: "tbl_C2s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AddColumn<string>(
                name: "INITIALS",
                table: "tbl_C2s",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_C1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_C1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_C1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<int>(
                name: "RMREASON",
                table: "tbl_C1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "RMMODE",
                table: "tbl_C1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AddColumn<DateTime>(
                name: "FRMDATE",
                table: "tbl_C1s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AddColumn<string>(
                name: "INITIALS",
                table: "tbl_C1s",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_B9s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_B9s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_B9s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<int>(
                name: "RMREASON",
                table: "tbl_B9s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "RMMODE",
                table: "tbl_B9s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AddColumn<DateTime>(
                name: "FRMDATE",
                table: "tbl_B9s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AddColumn<string>(
                name: "INITIALS",
                table: "tbl_B9s",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_B8s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_B8s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_B8s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<int>(
                name: "RMREASON",
                table: "tbl_B8s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "RMMODE",
                table: "tbl_B8s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AddColumn<DateTime>(
                name: "FRMDATE",
                table: "tbl_B8s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AddColumn<string>(
                name: "INITIALS",
                table: "tbl_B8s",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_B7s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_B7s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_B7s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<int>(
                name: "RMREASON",
                table: "tbl_B7s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "RMMODE",
                table: "tbl_B7s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AddColumn<DateTime>(
                name: "FRMDATE",
                table: "tbl_B7s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AddColumn<string>(
                name: "INITIALS",
                table: "tbl_B7s",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_B6s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_B6s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_B6s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<int>(
                name: "RMREASON",
                table: "tbl_B6s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "RMMODE",
                table: "tbl_B6s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AddColumn<DateTime>(
                name: "FRMDATE",
                table: "tbl_B6s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AddColumn<string>(
                name: "INITIALS",
                table: "tbl_B6s",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_B5s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_B5s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_B5s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<int>(
                name: "RMREASON",
                table: "tbl_B5s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "RMMODE",
                table: "tbl_B5s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AddColumn<DateTime>(
                name: "FRMDATE",
                table: "tbl_B5s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AddColumn<string>(
                name: "INITIALS",
                table: "tbl_B5s",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_B4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_B4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_B4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<int>(
                name: "RMREASON",
                table: "tbl_B4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "RMMODE",
                table: "tbl_B4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AddColumn<DateTime>(
                name: "FRMDATE",
                table: "tbl_B4s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AddColumn<string>(
                name: "INITIALS",
                table: "tbl_B4s",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_B3s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_B3s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_B3s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<int>(
                name: "RMREASON",
                table: "tbl_B3s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "RMMODE",
                table: "tbl_B3s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AddColumn<DateTime>(
                name: "FRMDATE",
                table: "tbl_B3s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AddColumn<string>(
                name: "INITIALS",
                table: "tbl_B3s",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_B1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_B1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_B1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<int>(
                name: "RMREASON",
                table: "tbl_B1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "RMMODE",
                table: "tbl_B1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AddColumn<DateTime>(
                name: "FRMDATE",
                table: "tbl_B1s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AddColumn<string>(
                name: "INITIALS",
                table: "tbl_B1s",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_A5D2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_A5D2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_A5D2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<int>(
                name: "RMREASON",
                table: "tbl_A5D2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "RMMODE",
                table: "tbl_A5D2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AddColumn<DateTime>(
                name: "FRMDATE",
                table: "tbl_A5D2s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AddColumn<string>(
                name: "INITIALS",
                table: "tbl_A5D2s",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_A4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_A4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_A4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<int>(
                name: "RMREASON",
                table: "tbl_A4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "RMMODE",
                table: "tbl_A4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AddColumn<DateTime>(
                name: "FRMDATE",
                table: "tbl_A4s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AddColumn<string>(
                name: "INITIALS",
                table: "tbl_A4s",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_A4as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_A4as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_A4as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<int>(
                name: "RMREASON",
                table: "tbl_A4as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "RMMODE",
                table: "tbl_A4as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AddColumn<DateTime>(
                name: "FRMDATE",
                table: "tbl_A4as",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AddColumn<string>(
                name: "INITIALS",
                table: "tbl_A4as",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_A3s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_A3s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_A3s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<int>(
                name: "RMREASON",
                table: "tbl_A3s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "RMMODE",
                table: "tbl_A3s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AddColumn<DateTime>(
                name: "FRMDATE",
                table: "tbl_A3s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AddColumn<string>(
                name: "INITIALS",
                table: "tbl_A3s",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_A2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_A2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_A2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<int>(
                name: "RMREASON",
                table: "tbl_A2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "RMMODE",
                table: "tbl_A2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AddColumn<DateTime>(
                name: "FRMDATE",
                table: "tbl_A2s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AddColumn<string>(
                name: "INITIALS",
                table: "tbl_A2s",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_A1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_A1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_A1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<int>(
                name: "RMREASON",
                table: "tbl_A1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "RMMODE",
                table: "tbl_A1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AddColumn<DateTime>(
                name: "FRMDATE",
                table: "tbl_A1s",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AddColumn<string>(
                name: "INITIALS",
                table: "tbl_A1s",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<int>(
                name: "RMREASON",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "RMMODE",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AddColumn<DateTime>(
                name: "FRMDATE",
                table: "tbl_A1as",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AddColumn<string>(
                name: "INITIALS",
                table: "tbl_A1as",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 4);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DSSDUB",
                table: "tbl_Visits");

            migrationBuilder.DropColumn(
                name: "FORMVER",
                table: "tbl_Visits");

            migrationBuilder.DropColumn(
                name: "PACKET",
                table: "tbl_Visits");

            migrationBuilder.DropColumn(
                name: "FRMDATE",
                table: "tbl_T1s");

            migrationBuilder.DropColumn(
                name: "INITIALS",
                table: "tbl_T1s");

            migrationBuilder.DropColumn(
                name: "FRMDATE",
                table: "tbl_D1bs");

            migrationBuilder.DropColumn(
                name: "INITIALS",
                table: "tbl_D1bs");

            migrationBuilder.DropColumn(
                name: "FRMDATE",
                table: "tbl_D1as");

            migrationBuilder.DropColumn(
                name: "INITIALS",
                table: "tbl_D1as");

            migrationBuilder.DropColumn(
                name: "FRMDATE",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "INITIALS",
                table: "tbl_C2s");

            migrationBuilder.DropColumn(
                name: "FRMDATE",
                table: "tbl_C1s");

            migrationBuilder.DropColumn(
                name: "INITIALS",
                table: "tbl_C1s");

            migrationBuilder.DropColumn(
                name: "FRMDATE",
                table: "tbl_B9s");

            migrationBuilder.DropColumn(
                name: "INITIALS",
                table: "tbl_B9s");

            migrationBuilder.DropColumn(
                name: "FRMDATE",
                table: "tbl_B8s");

            migrationBuilder.DropColumn(
                name: "INITIALS",
                table: "tbl_B8s");

            migrationBuilder.DropColumn(
                name: "FRMDATE",
                table: "tbl_B7s");

            migrationBuilder.DropColumn(
                name: "INITIALS",
                table: "tbl_B7s");

            migrationBuilder.DropColumn(
                name: "FRMDATE",
                table: "tbl_B6s");

            migrationBuilder.DropColumn(
                name: "INITIALS",
                table: "tbl_B6s");

            migrationBuilder.DropColumn(
                name: "FRMDATE",
                table: "tbl_B5s");

            migrationBuilder.DropColumn(
                name: "INITIALS",
                table: "tbl_B5s");

            migrationBuilder.DropColumn(
                name: "FRMDATE",
                table: "tbl_B4s");

            migrationBuilder.DropColumn(
                name: "INITIALS",
                table: "tbl_B4s");

            migrationBuilder.DropColumn(
                name: "FRMDATE",
                table: "tbl_B3s");

            migrationBuilder.DropColumn(
                name: "INITIALS",
                table: "tbl_B3s");

            migrationBuilder.DropColumn(
                name: "FRMDATE",
                table: "tbl_B1s");

            migrationBuilder.DropColumn(
                name: "INITIALS",
                table: "tbl_B1s");

            migrationBuilder.DropColumn(
                name: "FRMDATE",
                table: "tbl_A5D2s");

            migrationBuilder.DropColumn(
                name: "INITIALS",
                table: "tbl_A5D2s");

            migrationBuilder.DropColumn(
                name: "FRMDATE",
                table: "tbl_A4s");

            migrationBuilder.DropColumn(
                name: "INITIALS",
                table: "tbl_A4s");

            migrationBuilder.DropColumn(
                name: "FRMDATE",
                table: "tbl_A4as");

            migrationBuilder.DropColumn(
                name: "INITIALS",
                table: "tbl_A4as");

            migrationBuilder.DropColumn(
                name: "FRMDATE",
                table: "tbl_A3s");

            migrationBuilder.DropColumn(
                name: "INITIALS",
                table: "tbl_A3s");

            migrationBuilder.DropColumn(
                name: "FRMDATE",
                table: "tbl_A2s");

            migrationBuilder.DropColumn(
                name: "INITIALS",
                table: "tbl_A2s");

            migrationBuilder.DropColumn(
                name: "FRMDATE",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "INITIALS",
                table: "tbl_A1s");

            migrationBuilder.DropColumn(
                name: "FRMDATE",
                table: "tbl_A1as");

            migrationBuilder.DropColumn(
                name: "INITIALS",
                table: "tbl_A1as");

            migrationBuilder.RenameColumn(
                name: "VISIT_DATE",
                table: "tbl_Visits",
                newName: "StartDateTime");

            migrationBuilder.RenameColumn(
                name: "VISITNUM",
                table: "tbl_Visits",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "INITIALS",
                table: "tbl_Visits",
                newName: "Kind");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Visits_ParticipationId_VISITNUM",
                table: "tbl_Visits",
                newName: "IX_tbl_Visits_ParticipationId_Number");

            migrationBuilder.RenameColumn(
                name: "RMREASON",
                table: "tbl_T1s",
                newName: "REMOTEREASON");

            migrationBuilder.RenameColumn(
                name: "RMMODE",
                table: "tbl_T1s",
                newName: "REMOTEMODE");

            migrationBuilder.RenameColumn(
                name: "RMREASON",
                table: "tbl_D1bs",
                newName: "REMOTEREASON");

            migrationBuilder.RenameColumn(
                name: "RMMODE",
                table: "tbl_D1bs",
                newName: "REMOTEMODE");

            migrationBuilder.RenameColumn(
                name: "RMREASON",
                table: "tbl_D1as",
                newName: "REMOTEREASON");

            migrationBuilder.RenameColumn(
                name: "RMMODE",
                table: "tbl_D1as",
                newName: "REMOTEMODE");

            migrationBuilder.RenameColumn(
                name: "RMREASON",
                table: "tbl_C2s",
                newName: "REMOTEREASON");

            migrationBuilder.RenameColumn(
                name: "RMMODE",
                table: "tbl_C2s",
                newName: "REMOTEMODE");

            migrationBuilder.RenameColumn(
                name: "RMREASON",
                table: "tbl_C1s",
                newName: "REMOTEREASON");

            migrationBuilder.RenameColumn(
                name: "RMMODE",
                table: "tbl_C1s",
                newName: "REMOTEMODE");

            migrationBuilder.RenameColumn(
                name: "RMREASON",
                table: "tbl_B9s",
                newName: "REMOTEREASON");

            migrationBuilder.RenameColumn(
                name: "RMMODE",
                table: "tbl_B9s",
                newName: "REMOTEMODE");

            migrationBuilder.RenameColumn(
                name: "RMREASON",
                table: "tbl_B8s",
                newName: "REMOTEREASON");

            migrationBuilder.RenameColumn(
                name: "RMMODE",
                table: "tbl_B8s",
                newName: "REMOTEMODE");

            migrationBuilder.RenameColumn(
                name: "RMREASON",
                table: "tbl_B7s",
                newName: "REMOTEREASON");

            migrationBuilder.RenameColumn(
                name: "RMMODE",
                table: "tbl_B7s",
                newName: "REMOTEMODE");

            migrationBuilder.RenameColumn(
                name: "RMREASON",
                table: "tbl_B6s",
                newName: "REMOTEREASON");

            migrationBuilder.RenameColumn(
                name: "RMMODE",
                table: "tbl_B6s",
                newName: "REMOTEMODE");

            migrationBuilder.RenameColumn(
                name: "RMREASON",
                table: "tbl_B5s",
                newName: "REMOTEREASON");

            migrationBuilder.RenameColumn(
                name: "RMMODE",
                table: "tbl_B5s",
                newName: "REMOTEMODE");

            migrationBuilder.RenameColumn(
                name: "RMREASON",
                table: "tbl_B4s",
                newName: "REMOTEREASON");

            migrationBuilder.RenameColumn(
                name: "RMMODE",
                table: "tbl_B4s",
                newName: "REMOTEMODE");

            migrationBuilder.RenameColumn(
                name: "RMREASON",
                table: "tbl_B3s",
                newName: "REMOTEREASON");

            migrationBuilder.RenameColumn(
                name: "RMMODE",
                table: "tbl_B3s",
                newName: "REMOTEMODE");

            migrationBuilder.RenameColumn(
                name: "RMREASON",
                table: "tbl_B1s",
                newName: "REMOTEREASON");

            migrationBuilder.RenameColumn(
                name: "RMMODE",
                table: "tbl_B1s",
                newName: "REMOTEMODE");

            migrationBuilder.RenameColumn(
                name: "RMREASON",
                table: "tbl_A5D2s",
                newName: "REMOTEREASON");

            migrationBuilder.RenameColumn(
                name: "RMMODE",
                table: "tbl_A5D2s",
                newName: "REMOTEMODE");

            migrationBuilder.RenameColumn(
                name: "RMREASON",
                table: "tbl_A4s",
                newName: "REMOTEREASON");

            migrationBuilder.RenameColumn(
                name: "RMMODE",
                table: "tbl_A4s",
                newName: "REMOTEMODE");

            migrationBuilder.RenameColumn(
                name: "RMREASON",
                table: "tbl_A4as",
                newName: "REMOTEREASON");

            migrationBuilder.RenameColumn(
                name: "RMMODE",
                table: "tbl_A4as",
                newName: "REMOTEMODE");

            migrationBuilder.RenameColumn(
                name: "RMREASON",
                table: "tbl_A3s",
                newName: "REMOTEREASON");

            migrationBuilder.RenameColumn(
                name: "RMMODE",
                table: "tbl_A3s",
                newName: "REMOTEMODE");

            migrationBuilder.RenameColumn(
                name: "RMREASON",
                table: "tbl_A2s",
                newName: "REMOTEREASON");

            migrationBuilder.RenameColumn(
                name: "RMMODE",
                table: "tbl_A2s",
                newName: "REMOTEMODE");

            migrationBuilder.RenameColumn(
                name: "RMREASON",
                table: "tbl_A1s",
                newName: "REMOTEREASON");

            migrationBuilder.RenameColumn(
                name: "RMMODE",
                table: "tbl_A1s",
                newName: "REMOTEMODE");

            migrationBuilder.RenameColumn(
                name: "RMREASON",
                table: "tbl_A1as",
                newName: "REMOTEREASON");

            migrationBuilder.RenameColumn(
                name: "RMMODE",
                table: "tbl_A1as",
                newName: "REMOTEMODE");

            migrationBuilder.AddColumn<string>(
                name: "Version",
                table: "tbl_Visits",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_T1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_T1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_T1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEREASON",
                table: "tbl_T1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEMODE",
                table: "tbl_T1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<bool>(
                name: "SUB",
                table: "tbl_T1s",
                type: "bit",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEREASON",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEMODE",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<bool>(
                name: "SUB",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_D1as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_D1as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_D1as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEREASON",
                table: "tbl_D1as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEMODE",
                table: "tbl_D1as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<bool>(
                name: "SUB",
                table: "tbl_D1as",
                type: "bit",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_C2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_C2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_C2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEREASON",
                table: "tbl_C2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEMODE",
                table: "tbl_C2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<bool>(
                name: "SUB",
                table: "tbl_C2s",
                type: "bit",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_C1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_C1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_C1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEREASON",
                table: "tbl_C1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEMODE",
                table: "tbl_C1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<bool>(
                name: "SUB",
                table: "tbl_C1s",
                type: "bit",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_B9s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_B9s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_B9s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEREASON",
                table: "tbl_B9s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEMODE",
                table: "tbl_B9s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<bool>(
                name: "SUB",
                table: "tbl_B9s",
                type: "bit",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_B8s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_B8s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_B8s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEREASON",
                table: "tbl_B8s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEMODE",
                table: "tbl_B8s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<bool>(
                name: "SUB",
                table: "tbl_B8s",
                type: "bit",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_B7s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_B7s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_B7s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEREASON",
                table: "tbl_B7s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEMODE",
                table: "tbl_B7s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<bool>(
                name: "SUB",
                table: "tbl_B7s",
                type: "bit",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_B6s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_B6s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_B6s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEREASON",
                table: "tbl_B6s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEMODE",
                table: "tbl_B6s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<bool>(
                name: "SUB",
                table: "tbl_B6s",
                type: "bit",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_B5s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_B5s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_B5s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEREASON",
                table: "tbl_B5s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEMODE",
                table: "tbl_B5s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<bool>(
                name: "SUB",
                table: "tbl_B5s",
                type: "bit",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_B4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_B4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_B4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEREASON",
                table: "tbl_B4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEMODE",
                table: "tbl_B4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<bool>(
                name: "SUB",
                table: "tbl_B4s",
                type: "bit",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_B3s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_B3s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_B3s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEREASON",
                table: "tbl_B3s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEMODE",
                table: "tbl_B3s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<bool>(
                name: "SUB",
                table: "tbl_B3s",
                type: "bit",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_B1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_B1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_B1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEREASON",
                table: "tbl_B1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEMODE",
                table: "tbl_B1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<bool>(
                name: "SUB",
                table: "tbl_B1s",
                type: "bit",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_A5D2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_A5D2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_A5D2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEREASON",
                table: "tbl_A5D2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEMODE",
                table: "tbl_A5D2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<bool>(
                name: "SUB",
                table: "tbl_A5D2s",
                type: "bit",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_A4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_A4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_A4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEREASON",
                table: "tbl_A4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEMODE",
                table: "tbl_A4s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<bool>(
                name: "SUB",
                table: "tbl_A4s",
                type: "bit",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_A4as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_A4as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_A4as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEREASON",
                table: "tbl_A4as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEMODE",
                table: "tbl_A4as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<bool>(
                name: "SUB",
                table: "tbl_A4as",
                type: "bit",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_A3s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_A3s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_A3s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEREASON",
                table: "tbl_A3s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEMODE",
                table: "tbl_A3s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<bool>(
                name: "SUB",
                table: "tbl_A3s",
                type: "bit",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_A2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_A2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_A2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEREASON",
                table: "tbl_A2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEMODE",
                table: "tbl_A2s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<bool>(
                name: "SUB",
                table: "tbl_A2s",
                type: "bit",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_A1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_A1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_A1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEREASON",
                table: "tbl_A1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEMODE",
                table: "tbl_A1s",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<bool>(
                name: "SUB",
                table: "tbl_A1s",
                type: "bit",
                nullable: false,
                defaultValue: true)
                .Annotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "NOT",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<int>(
                name: "MODE",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<int>(
                name: "LANG",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEREASON",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<int>(
                name: "REMOTEMODE",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AddColumn<bool>(
                name: "SUB",
                table: "tbl_A1as",
                type: "bit",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 7);

        }
    }
}
