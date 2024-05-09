using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class d1aPREDOMSYN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PREDOMSYN",
                table: "tbl_D1as",
                type: "int",
                nullable: true,
                comment: "8. Is there a predominant clinical syndrome?");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PREDOMSYN",
                table: "tbl_D1as");
        }
    }
}
