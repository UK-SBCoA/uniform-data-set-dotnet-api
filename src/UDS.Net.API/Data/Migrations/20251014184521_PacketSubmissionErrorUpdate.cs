using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class PacketSubmissionErrorUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ResolvedBy",
                table: "PacketSubmissionErrors",
                newName: "StatusChangedBy");

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "PacketSubmissionErrors",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "PacketSubmissionErrors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "PacketSubmissionErrors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "PacketSubmissionErrors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "PacketSubmissionErrors");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "PacketSubmissionErrors");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "PacketSubmissionErrors");

            migrationBuilder.RenameColumn(
                name: "StatusChangedBy",
                table: "PacketSubmissionErrors",
                newName: "ResolvedBy");

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "PacketSubmissionErrors",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);
        }
    }
}
