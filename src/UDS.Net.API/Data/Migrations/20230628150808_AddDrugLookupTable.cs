using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDrugLookupTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DrugCodesLookup",
                columns: table => new
                {
                    DrugId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DrugName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsOverTheCounter = table.Column<bool>(type: "bit", nullable: false),
                    IsPopular = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugCodesLookup", x => x.DrugId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DrugCodesLookup");
        }
    }
}
