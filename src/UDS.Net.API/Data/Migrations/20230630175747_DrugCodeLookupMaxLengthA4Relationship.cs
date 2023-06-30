using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class DrugCodeLookupMaxLengthA4Relationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DrugCodesLookup",
                table: "DrugCodesLookup");

            migrationBuilder.AlterColumn<string>(
                name: "DrugId",
                table: "DrugCodesLookup",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DrugCodesLookup",
                table: "DrugCodesLookup",
                column: "DrugId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4Ds_DRUGID",
                table: "tbl_A4Ds",
                column: "DRUGID");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_A4Ds_DrugCodesLookup_DRUGID",
                table: "tbl_A4Ds",
                column: "DRUGID",
                principalTable: "DrugCodesLookup",
                principalColumn: "DrugId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_A4Ds_DrugCodesLookup_DRUGID",
                table: "tbl_A4Ds");

            migrationBuilder.DropIndex(
                name: "IX_tbl_A4Ds_DRUGID",
                table: "tbl_A4Ds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DrugCodesLookup",
                table: "DrugCodesLookup");

            migrationBuilder.AlterColumn<string>(
                name: "DrugId",
                table: "DrugCodesLookup",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DrugCodesLookup",
                table: "DrugCodesLookup",
                column: "DrugId");
        }
    }
}
