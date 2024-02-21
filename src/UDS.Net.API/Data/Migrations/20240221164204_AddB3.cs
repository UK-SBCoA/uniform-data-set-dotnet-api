using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddB3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_B3s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PDNORMAL = table.Column<bool>(type: "bit", nullable: true),
                    SPEECH = table.Column<int>(type: "int", nullable: true),
                    SPEECHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    FACEXP = table.Column<int>(type: "int", nullable: true),
                    FACEXPX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRESTFAC = table.Column<int>(type: "int", nullable: true),
                    TRESTFAX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRESTRHD = table.Column<int>(type: "int", nullable: true),
                    TRESTRHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRESTLHD = table.Column<int>(type: "int", nullable: true),
                    TRESTLHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRESTRFT = table.Column<int>(type: "int", nullable: true),
                    TRESTRFX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRESTLFT = table.Column<int>(type: "int", nullable: true),
                    TRESTLFX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRACTRHD = table.Column<int>(type: "int", nullable: true),
                    TRACTRHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRACTLHD = table.Column<int>(type: "int", nullable: true),
                    TRACTLHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    RIGDNECK = table.Column<int>(type: "int", nullable: true),
                    RIGDNEX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    RIGDUPRT = table.Column<int>(type: "int", nullable: true),
                    RIGDUPRX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    RIGDUPLF = table.Column<int>(type: "int", nullable: true),
                    RIGDUPLX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    RIGDLORT = table.Column<int>(type: "int", nullable: true),
                    RIGDLORX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    RIGDLOLF = table.Column<int>(type: "int", nullable: true),
                    RIGDLOLX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TAPSRT = table.Column<int>(type: "int", nullable: true),
                    TAPSRTX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TAPSLF = table.Column<int>(type: "int", nullable: true),
                    TAPSLFX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    HANDMOVR = table.Column<int>(type: "int", nullable: true),
                    HANDMVRX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    HANDMOVL = table.Column<int>(type: "int", nullable: true),
                    HANDMVLX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    HANDALTR = table.Column<int>(type: "int", nullable: true),
                    HANDATRX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    HANDALTL = table.Column<int>(type: "int", nullable: true),
                    HANDATLX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    LEGRT = table.Column<int>(type: "int", nullable: true),
                    LEGRTX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    LEGLF = table.Column<int>(type: "int", nullable: true),
                    LEGLFX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    ARISING = table.Column<int>(type: "int", nullable: true),
                    ARISINGX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    POSTURE = table.Column<int>(type: "int", nullable: true),
                    POSTUREX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    GAIT = table.Column<int>(type: "int", nullable: true),
                    GAITX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    POSSTAB = table.Column<int>(type: "int", nullable: true),
                    POSSTABX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    BRADYKIN = table.Column<int>(type: "int", nullable: true),
                    BRADYKIX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TOTALUPDRS = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_B3s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_B3s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_B3s_VisitId",
                table: "tbl_B3s",
                column: "VisitId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_B3s");
        }
    }
}
