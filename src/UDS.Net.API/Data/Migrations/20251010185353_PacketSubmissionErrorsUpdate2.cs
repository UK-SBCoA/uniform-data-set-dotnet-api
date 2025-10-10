using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class PacketSubmissionErrorsUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IgnoreStatus",
                table: "PacketSubmissionErrors");

            migrationBuilder.RenameColumn(
                name: "ResolvedBy",
                table: "PacketSubmissionErrors",
                newName: "StatusChangedBy");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "PacketSubmissionErrors",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "PacketSubmissionErrors");

            migrationBuilder.RenameColumn(
                name: "StatusChangedBy",
                table: "PacketSubmissionErrors",
                newName: "ResolvedBy");

            migrationBuilder.AddColumn<bool>(
                name: "IgnoreStatus",
                table: "PacketSubmissionErrors",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
