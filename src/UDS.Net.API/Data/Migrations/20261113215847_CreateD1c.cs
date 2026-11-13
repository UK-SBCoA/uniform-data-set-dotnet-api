using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateD1c : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_D1cs",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacketId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FRMDATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    INITIALS = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    MODE = table.Column<int>(type: "int", nullable: true),
                    RMREASON = table.Column<int>(type: "int", nullable: true),
                    RMMODE = table.Column<int>(type: "int", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true),
                    ADMIN = table.Column<int>(type: "int", nullable: true),
                    FRMDATED1C = table.Column<DateTime>(type: "datetime2", nullable: true),
                    INITIALSD1C = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    LANGD1C = table.Column<int>(type: "int", nullable: true),
                    MODED1C = table.Column<int>(type: "int", nullable: true),
                    D1CNOT = table.Column<int>(type: "int", nullable: true),
                    DXPLSMABIO = table.Column<int>(type: "int", nullable: true),
                    DXPTAU217 = table.Column<int>(type: "int", nullable: true),
                    PTAU217RS = table.Column<int>(type: "int", nullable: true),
                    PT217ANLYS = table.Column<int>(type: "int", nullable: true),
                    PT217INT = table.Column<int>(type: "int", nullable: true),
                    DXPCPT217 = table.Column<int>(type: "int", nullable: true),
                    PCPT217RS = table.Column<int>(type: "int", nullable: true),
                    PCPT217INT = table.Column<int>(type: "int", nullable: true),
                    DXOTHPLSMA = table.Column<int>(type: "int", nullable: true),
                    DXOTHPLSMX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    OTHPLSMARS = table.Column<int>(type: "int", nullable: true),
                    OPLSMANLYS = table.Column<int>(type: "int", nullable: true),
                    OPLSMAINT = table.Column<int>(type: "int", nullable: true),
                    DXCSFBIO = table.Column<int>(type: "int", nullable: true),
                    DXPT181AB = table.Column<int>(type: "int", nullable: true),
                    PT181ABRS = table.Column<int>(type: "int", nullable: true),
                    PT181ABAYS = table.Column<int>(type: "int", nullable: true),
                    PT181ABINT = table.Column<int>(type: "int", nullable: true),
                    DXTTABETA = table.Column<int>(type: "int", nullable: true),
                    TTABETARS = table.Column<int>(type: "int", nullable: true),
                    TTABETAINT = table.Column<int>(type: "int", nullable: true),
                    DXAB42AB40 = table.Column<int>(type: "int", nullable: true),
                    AB42AB40RS = table.Column<int>(type: "int", nullable: true),
                    AB42AB40AY = table.Column<int>(type: "int", nullable: true),
                    AB42AB40IT = table.Column<int>(type: "int", nullable: true),
                    DXOTHCSF = table.Column<int>(type: "int", nullable: true),
                    DXOTHCSFX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    OTHCSFRS = table.Column<int>(type: "int", nullable: true),
                    OCSFANLYS = table.Column<int>(type: "int", nullable: true),
                    OCSFINT = table.Column<int>(type: "int", nullable: true),
                    DXAPET = table.Column<int>(type: "int", nullable: true),
                    APETRS = table.Column<int>(type: "int", nullable: true),
                    APETVIS = table.Column<int>(type: "int", nullable: true),
                    APETQUANT = table.Column<int>(type: "int", nullable: true),
                    APETANLYS = table.Column<int>(type: "int", nullable: true),
                    APETINT = table.Column<int>(type: "int", nullable: true),
                    DXTAUPET = table.Column<int>(type: "int", nullable: true),
                    TPETMTLRS = table.Column<int>(type: "int", nullable: true),
                    TPETMTLVIS = table.Column<int>(type: "int", nullable: true),
                    TPETMTLQNT = table.Column<int>(type: "int", nullable: true),
                    TPETMTLAYS = table.Column<int>(type: "int", nullable: true),
                    TPETNEORS = table.Column<int>(type: "int", nullable: true),
                    TPETNEOVIS = table.Column<int>(type: "int", nullable: true),
                    TPETNEOQNT = table.Column<int>(type: "int", nullable: true),
                    TPETNEOAYS = table.Column<int>(type: "int", nullable: true),
                    DXTAUPTINT = table.Column<int>(type: "int", nullable: true),
                    INFORISCH = table.Column<int>(type: "int", nullable: true),
                    IMGRSINF = table.Column<int>(type: "int", nullable: true),
                    IMGRSINFLC = table.Column<int>(type: "int", nullable: true),
                    IMGRSINFCT = table.Column<int>(type: "int", nullable: true),
                    IMGRSMICR = table.Column<int>(type: "int", nullable: true),
                    IMGRSWMH = table.Column<int>(type: "int", nullable: true),
                    IMGRSSPSID = table.Column<int>(type: "int", nullable: true),
                    IMGRSOTH = table.Column<int>(type: "int", nullable: true),
                    IMGRSOTHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    IMGRSINT = table.Column<int>(type: "int", nullable: true),
                    DXASYN = table.Column<int>(type: "int", nullable: true),
                    ASYNRS = table.Column<int>(type: "int", nullable: true),
                    ASYNASSAY = table.Column<int>(type: "int", nullable: true),
                    ASYNASSAYX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    ASYNANLYSX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    ASYNINT = table.Column<int>(type: "int", nullable: true),
                    AACRITMET = table.Column<int>(type: "int", nullable: true),
                    CR1APET = table.Column<int>(type: "int", nullable: true),
                    CR1PTAU217 = table.Column<int>(type: "int", nullable: true),
                    CR1PCPT217 = table.Column<int>(type: "int", nullable: true),
                    CR1PT181AB = table.Column<int>(type: "int", nullable: true),
                    CR1TTABETA = table.Column<int>(type: "int", nullable: true),
                    C1AB42AB40 = table.Column<int>(type: "int", nullable: true),
                    CR1OTH = table.Column<int>(type: "int", nullable: true),
                    CR1OTHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    BIOSTAGE = table.Column<int>(type: "int", nullable: true),
                    CLINSTAGE = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_D1cs", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_D1cs_tbl_Packets_PacketId",
                        column: x => x.PacketId,
                        principalTable: "tbl_Packets",
                        principalColumn: "PacketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_D1cs_PacketId",
                table: "tbl_D1cs",
                column: "PacketId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_D1cs");
        }
    }
}
