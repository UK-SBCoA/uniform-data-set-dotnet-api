using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddA4aFlattenedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_A4as",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TRTBIOMARK = table.Column<int>(type: "int", nullable: true),
                    TARGETAB1 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETTAU1 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETINF1 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETSYN1 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTH1 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTX1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRTTRIAL1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NCTNUM1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    STARTMO1 = table.Column<int>(type: "int", nullable: true),
                    STARTYEAR1 = table.Column<int>(type: "int", nullable: true),
                    ENDMO1 = table.Column<int>(type: "int", nullable: true),
                    ENDYEAR1 = table.Column<int>(type: "int", nullable: true),
                    CARETRIAL1 = table.Column<int>(type: "int", nullable: true),
                    TRIALGRP1 = table.Column<int>(type: "int", nullable: true),
                    TARGETAB2 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETTAU2 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETINF2 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETSYN2 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTH2 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTX2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRTTRIAL2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NCTNUM2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    STARTMO2 = table.Column<int>(type: "int", nullable: true),
                    STARTYEAR2 = table.Column<int>(type: "int", nullable: true),
                    ENDMO2 = table.Column<int>(type: "int", nullable: true),
                    ENDYEAR2 = table.Column<int>(type: "int", nullable: true),
                    CARETRIAL2 = table.Column<int>(type: "int", nullable: true),
                    TRIALGRP2 = table.Column<int>(type: "int", nullable: true),
                    TARGETAB3 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETTAU3 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETINF3 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETSYN3 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTH3 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTX3 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRTTRIAL3 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NCTNUM3 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    STARTMO3 = table.Column<int>(type: "int", nullable: true),
                    STARTYEAR3 = table.Column<int>(type: "int", nullable: true),
                    ENDMO3 = table.Column<int>(type: "int", nullable: true),
                    ENDYEAR3 = table.Column<int>(type: "int", nullable: true),
                    CARETRIAL3 = table.Column<int>(type: "int", nullable: true),
                    TRIALGRP3 = table.Column<int>(type: "int", nullable: true),
                    TARGETAB4 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETTAU4 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETINF4 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETSYN4 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTH4 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTX4 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRTTRIAL4 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NCTNUM4 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    STARTMO4 = table.Column<int>(type: "int", nullable: true),
                    STARTYEAR4 = table.Column<int>(type: "int", nullable: true),
                    ENDMO4 = table.Column<int>(type: "int", nullable: true),
                    ENDYEAR4 = table.Column<int>(type: "int", nullable: true),
                    CARETRIAL4 = table.Column<int>(type: "int", nullable: true),
                    TRIALGRP4 = table.Column<int>(type: "int", nullable: true),
                    TARGETAB5 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETTAU5 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETINF5 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETSYN5 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTH5 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTX5 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRTTRIAL5 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NCTNUM5 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    STARTMO5 = table.Column<int>(type: "int", nullable: true),
                    STARTYEAR5 = table.Column<int>(type: "int", nullable: true),
                    ENDMO5 = table.Column<int>(type: "int", nullable: true),
                    ENDYEAR5 = table.Column<int>(type: "int", nullable: true),
                    CARETRIAL5 = table.Column<int>(type: "int", nullable: true),
                    TRIALGRP5 = table.Column<int>(type: "int", nullable: true),
                    TARGETAB6 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETTAU6 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETINF6 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETSYN6 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTH6 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTX6 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRTTRIAL6 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NCTNUM6 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    STARTMO6 = table.Column<int>(type: "int", nullable: true),
                    STARTYEAR6 = table.Column<int>(type: "int", nullable: true),
                    ENDMO6 = table.Column<int>(type: "int", nullable: true),
                    ENDYEAR6 = table.Column<int>(type: "int", nullable: true),
                    CARETRIAL6 = table.Column<int>(type: "int", nullable: true),
                    TRIALGRP6 = table.Column<int>(type: "int", nullable: true),
                    TARGETAB7 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETTAU7 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETINF7 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETSYN7 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTH7 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTX7 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRTTRIAL7 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NCTNUM7 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    STARTMO7 = table.Column<int>(type: "int", nullable: true),
                    STARTYEAR7 = table.Column<int>(type: "int", nullable: true),
                    ENDMO7 = table.Column<int>(type: "int", nullable: true),
                    ENDYEAR7 = table.Column<int>(type: "int", nullable: true),
                    CARETRIAL7 = table.Column<int>(type: "int", nullable: true),
                    TRIALGRP7 = table.Column<int>(type: "int", nullable: true),
                    TARGETAB8 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETTAU8 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETINF8 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETSYN8 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTH8 = table.Column<bool>(type: "bit", nullable: true),
                    TARGETOTX8 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TRTTRIAL8 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NCTNUM8 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    STARTMO8 = table.Column<int>(type: "int", nullable: true),
                    STARTYEAR8 = table.Column<int>(type: "int", nullable: true),
                    ENDMO8 = table.Column<int>(type: "int", nullable: true),
                    ENDYEAR8 = table.Column<int>(type: "int", nullable: true),
                    CARETRIAL8 = table.Column<int>(type: "int", nullable: true),
                    TRIALGRP8 = table.Column<int>(type: "int", nullable: true),
                    ADVEVENT = table.Column<int>(type: "int", nullable: true),
                    ARIAE = table.Column<bool>(type: "bit", nullable: true),
                    ARIAH = table.Column<bool>(type: "bit", nullable: true),
                    ADVERSEOTH = table.Column<bool>(type: "bit", nullable: true),
                    ADVERSEOTX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
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
                    table.PrimaryKey("PK_tbl_A4as", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_A4as_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4as_VisitId",
                table: "tbl_A4as",
                column: "VisitId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_A4as");
        }
    }
}
