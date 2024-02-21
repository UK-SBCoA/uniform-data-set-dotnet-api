using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class FlattenA4forUDS4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_A4Ds");

            migrationBuilder.DropTable(
                name: "tbl_A4Gs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DrugCodesLookup",
                table: "DrugCodesLookup");

            migrationBuilder.DropColumn(
                name: "DrugId",
                table: "DrugCodesLookup");

            migrationBuilder.RenameColumn(
                name: "BrandName",
                table: "DrugCodesLookup",
                newName: "BrandNames");

            migrationBuilder.AddColumn<int>(
                name: "RxNormId",
                table: "DrugCodesLookup",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DrugCodesLookup",
                table: "DrugCodesLookup",
                column: "RxNormId");

            migrationBuilder.CreateTable(
                name: "tbl_A4s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ANYMEDS = table.Column<int>(type: "int", nullable: true),
                    RXNORMID1_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID2_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID3_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID4_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID5_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID6_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID7_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID8_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID9_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID10_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID11_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID12_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID13_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID14_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID15_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID16_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID17_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID18_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID19_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID20_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID21_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID22_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID23_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID24_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID25_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID26_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID27_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID28_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID29_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID30_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID31_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID32_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID33_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID34_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID35_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID36_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID37_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID38_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID39_RxNormId = table.Column<int>(type: "int", nullable: true),
                    RXNORMID40_RxNormId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_tbl_A4s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID10_RxNormId",
                        column: x => x.RXNORMID10_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID11_RxNormId",
                        column: x => x.RXNORMID11_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID12_RxNormId",
                        column: x => x.RXNORMID12_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID13_RxNormId",
                        column: x => x.RXNORMID13_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID14_RxNormId",
                        column: x => x.RXNORMID14_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID15_RxNormId",
                        column: x => x.RXNORMID15_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID16_RxNormId",
                        column: x => x.RXNORMID16_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID17_RxNormId",
                        column: x => x.RXNORMID17_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID18_RxNormId",
                        column: x => x.RXNORMID18_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID19_RxNormId",
                        column: x => x.RXNORMID19_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID1_RxNormId",
                        column: x => x.RXNORMID1_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID20_RxNormId",
                        column: x => x.RXNORMID20_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID21_RxNormId",
                        column: x => x.RXNORMID21_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID22_RxNormId",
                        column: x => x.RXNORMID22_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID23_RxNormId",
                        column: x => x.RXNORMID23_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID24_RxNormId",
                        column: x => x.RXNORMID24_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID25_RxNormId",
                        column: x => x.RXNORMID25_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID26_RxNormId",
                        column: x => x.RXNORMID26_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID27_RxNormId",
                        column: x => x.RXNORMID27_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID28_RxNormId",
                        column: x => x.RXNORMID28_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID29_RxNormId",
                        column: x => x.RXNORMID29_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID2_RxNormId",
                        column: x => x.RXNORMID2_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID30_RxNormId",
                        column: x => x.RXNORMID30_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID31_RxNormId",
                        column: x => x.RXNORMID31_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID32_RxNormId",
                        column: x => x.RXNORMID32_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID33_RxNormId",
                        column: x => x.RXNORMID33_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID34_RxNormId",
                        column: x => x.RXNORMID34_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID35_RxNormId",
                        column: x => x.RXNORMID35_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID36_RxNormId",
                        column: x => x.RXNORMID36_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID37_RxNormId",
                        column: x => x.RXNORMID37_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID38_RxNormId",
                        column: x => x.RXNORMID38_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID39_RxNormId",
                        column: x => x.RXNORMID39_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID3_RxNormId",
                        column: x => x.RXNORMID3_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID40_RxNormId",
                        column: x => x.RXNORMID40_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID4_RxNormId",
                        column: x => x.RXNORMID4_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID5_RxNormId",
                        column: x => x.RXNORMID5_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID6_RxNormId",
                        column: x => x.RXNORMID6_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID7_RxNormId",
                        column: x => x.RXNORMID7_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID8_RxNormId",
                        column: x => x.RXNORMID8_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_DrugCodesLookup_RXNORMID9_RxNormId",
                        column: x => x.RXNORMID9_RxNormId,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "RxNormId");
                    table.ForeignKey(
                        name: "FK_tbl_A4s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID1_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID1_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID10_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID10_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID11_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID11_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID12_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID12_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID13_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID13_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID14_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID14_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID15_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID15_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID16_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID16_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID17_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID17_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID18_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID18_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID19_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID19_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID2_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID2_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID20_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID20_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID21_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID21_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID22_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID22_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID23_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID23_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID24_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID24_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID25_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID25_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID26_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID26_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID27_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID27_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID28_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID28_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID29_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID29_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID3_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID3_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID30_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID30_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID31_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID31_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID32_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID32_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID33_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID33_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID34_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID34_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID35_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID35_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID36_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID36_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID37_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID37_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID38_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID38_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID39_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID39_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID4_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID4_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID40_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID40_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID5_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID5_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID6_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID6_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID7_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID7_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID8_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID8_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_RXNORMID9_RxNormId",
                table: "tbl_A4s",
                column: "RXNORMID9_RxNormId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4s_VisitId",
                table: "tbl_A4s",
                column: "VisitId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
                name: "tbl_A4s");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DrugCodesLookup",
                table: "DrugCodesLookup");

            migrationBuilder.DropColumn(
                name: "RxNormId",
                table: "DrugCodesLookup");

            migrationBuilder.RenameColumn(
                name: "BrandNames",
                table: "DrugCodesLookup",
                newName: "BrandName");

            migrationBuilder.AddColumn<string>(
                name: "DrugId",
                table: "DrugCodesLookup",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DrugCodesLookup",
                table: "DrugCodesLookup",
                column: "DrugId");

            migrationBuilder.CreateTable(
                name: "tbl_A4Ds",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DRUGID = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_A4Ds", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_A4Ds_DrugCodesLookup_DRUGID",
                        column: x => x.DRUGID,
                        principalTable: "DrugCodesLookup",
                        principalColumn: "DrugId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_A4Ds_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_A4Gs",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    ANYMEDS = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_A4Gs", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_A4Gs_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4Ds_DRUGID",
                table: "tbl_A4Ds",
                column: "DRUGID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4Ds_VisitId",
                table: "tbl_A4Ds",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4Gs_VisitId",
                table: "tbl_A4Gs",
                column: "VisitId",
                unique: true);
        }
    }
}
