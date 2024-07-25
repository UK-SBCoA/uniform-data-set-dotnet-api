using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatea1ethnicities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ETHMOROCCO",
                table: "tbl_A1s",
                newName: "ETHSCOTT");

            migrationBuilder.RenameColumn(
                name: "ETHFRENCH",
                table: "tbl_A1s",
                newName: "ETHIRAQI");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ETHSCOTT",
                table: "tbl_A1s",
                newName: "ETHMOROCCO");

            migrationBuilder.RenameColumn(
                name: "ETHIRAQI",
                table: "tbl_A1s",
                newName: "ETHFRENCH");
        }
    }
}
