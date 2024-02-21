using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class CombineA5D2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_A5s");

            migrationBuilder.DropTable(
                name: "tbl_D2s");

            migrationBuilder.DropIndex(
                name: "IX_tbl_A4as_VisitId",
                table: "tbl_A4as");

            migrationBuilder.CreateTable(
                name: "tbl_A5D2s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TOBAC100 = table.Column<int>(type: "int", nullable: true),
                    SMOKYRS = table.Column<int>(type: "int", nullable: true),
                    PACKSPER = table.Column<int>(type: "int", nullable: true),
                    TOBAC30 = table.Column<int>(type: "int", nullable: true),
                    QUITSMOK = table.Column<int>(type: "int", nullable: true),
                    ALCFREQYR = table.Column<int>(type: "int", nullable: true),
                    ALCDRINKS = table.Column<int>(type: "int", nullable: true),
                    ALCBINGE = table.Column<int>(type: "int", nullable: true),
                    SUBSTYEAR = table.Column<int>(type: "int", nullable: true),
                    SUBSTPAST = table.Column<int>(type: "int", nullable: true),
                    CANNABIS = table.Column<int>(type: "int", nullable: true),
                    HRTATTACK = table.Column<int>(type: "int", nullable: true),
                    HRTATTMULT = table.Column<int>(type: "int", nullable: true),
                    HRTATTAGE = table.Column<int>(type: "int", nullable: true),
                    CARDARREST = table.Column<int>(type: "int", nullable: true),
                    CARDARRAGE = table.Column<int>(type: "int", nullable: true),
                    CVAFIB = table.Column<int>(type: "int", nullable: true),
                    CVANGIO = table.Column<int>(type: "int", nullable: true),
                    CVBYPASS = table.Column<int>(type: "int", nullable: true),
                    BYPASSAGE = table.Column<int>(type: "int", nullable: true),
                    CVPACDEF = table.Column<int>(type: "int", nullable: true),
                    PACDEFAGE = table.Column<int>(type: "int", nullable: true),
                    CVCHF = table.Column<int>(type: "int", nullable: true),
                    CVHVALVE = table.Column<int>(type: "int", nullable: true),
                    VALVEAGE = table.Column<int>(type: "int", nullable: true),
                    CVOTHR = table.Column<int>(type: "int", nullable: true),
                    CVOTHRX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CBSTROKE = table.Column<int>(type: "int", nullable: true),
                    STROKMUL = table.Column<int>(type: "int", nullable: true),
                    STROKAGE = table.Column<int>(type: "int", nullable: true),
                    STROKSTAT = table.Column<int>(type: "int", nullable: true),
                    ANGIOCP = table.Column<int>(type: "int", nullable: true),
                    CAROTIDAGE = table.Column<int>(type: "int", nullable: true),
                    CBTIA = table.Column<int>(type: "int", nullable: true),
                    TIAAGE = table.Column<int>(type: "int", nullable: true),
                    PD = table.Column<int>(type: "int", nullable: true),
                    PDAGE = table.Column<int>(type: "int", nullable: true),
                    PDOTHR = table.Column<int>(type: "int", nullable: true),
                    PDOTHRAGE = table.Column<int>(type: "int", nullable: true),
                    SEIZURES = table.Column<int>(type: "int", nullable: true),
                    SEIZNUM = table.Column<int>(type: "int", nullable: true),
                    SEIZAGE = table.Column<int>(type: "int", nullable: true),
                    HEADACHE = table.Column<int>(type: "int", nullable: true),
                    MS = table.Column<int>(type: "int", nullable: true),
                    HYDROCEPH = table.Column<int>(type: "int", nullable: true),
                    HEADIMP = table.Column<int>(type: "int", nullable: true),
                    IMPAMFOOT = table.Column<bool>(type: "bit", nullable: true),
                    IMPSOCCER = table.Column<bool>(type: "bit", nullable: true),
                    IMPHOCKEY = table.Column<bool>(type: "bit", nullable: true),
                    IMPBOXING = table.Column<bool>(type: "bit", nullable: true),
                    IMPSPORT = table.Column<bool>(type: "bit", nullable: true),
                    IMPIPV = table.Column<bool>(type: "bit", nullable: true),
                    IMPMILIT = table.Column<bool>(type: "bit", nullable: true),
                    IMPASSAULT = table.Column<bool>(type: "bit", nullable: true),
                    IMPOTHER = table.Column<bool>(type: "bit", nullable: true),
                    IMPOTHERX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    IMPYEARS = table.Column<int>(type: "int", nullable: true),
                    HEADINJURY = table.Column<int>(type: "int", nullable: true),
                    HEADINJUNC = table.Column<int>(type: "int", nullable: true),
                    HEADINJCON = table.Column<int>(type: "int", nullable: true),
                    HEADINJNUM = table.Column<int>(type: "int", nullable: true),
                    FIRSTTBI = table.Column<int>(type: "int", nullable: true),
                    LASTTBI = table.Column<int>(type: "int", nullable: true),
                    DIABETES = table.Column<int>(type: "int", nullable: true),
                    DIABTYPE = table.Column<int>(type: "int", nullable: true),
                    DIABINS = table.Column<bool>(type: "bit", nullable: true),
                    DIABMEDS = table.Column<bool>(type: "bit", nullable: true),
                    DIABDIET = table.Column<bool>(type: "bit", nullable: true),
                    DIABUNK = table.Column<bool>(type: "bit", nullable: true),
                    DIABAGE = table.Column<int>(type: "int", nullable: true),
                    HYPERTEN = table.Column<int>(type: "int", nullable: true),
                    HYPERTAGE = table.Column<int>(type: "int", nullable: true),
                    HYPERCHO = table.Column<int>(type: "int", nullable: true),
                    HYPERCHAGE = table.Column<int>(type: "int", nullable: true),
                    B12DEF = table.Column<int>(type: "int", nullable: true),
                    THYROID = table.Column<int>(type: "int", nullable: true),
                    ARTHRIT = table.Column<int>(type: "int", nullable: true),
                    ARTHRRHEUM = table.Column<bool>(type: "bit", nullable: true),
                    ARTHROSTEO = table.Column<bool>(type: "bit", nullable: true),
                    ARTHROTHR = table.Column<bool>(type: "bit", nullable: true),
                    ARTHTYPX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    ARTHTYPUNK = table.Column<bool>(type: "bit", nullable: true),
                    ARTHUPEX = table.Column<bool>(type: "bit", nullable: true),
                    ARTHLOEX = table.Column<bool>(type: "bit", nullable: true),
                    ARTHSPIN = table.Column<bool>(type: "bit", nullable: true),
                    ARTHUNK = table.Column<bool>(type: "bit", nullable: true),
                    INCONTU = table.Column<int>(type: "int", nullable: true),
                    INCONTF = table.Column<int>(type: "int", nullable: true),
                    APNEA = table.Column<int>(type: "int", nullable: true),
                    CPAP = table.Column<int>(type: "int", nullable: true),
                    APNEAORAL = table.Column<int>(type: "int", nullable: true),
                    RBD = table.Column<int>(type: "int", nullable: true),
                    INSOMN = table.Column<int>(type: "int", nullable: true),
                    OTHSLEEP = table.Column<int>(type: "int", nullable: true),
                    OTHSLEEX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CANCER = table.Column<int>(type: "int", nullable: true),
                    CANCERPRIM = table.Column<bool>(type: "bit", nullable: true),
                    CANCERMETA = table.Column<bool>(type: "bit", nullable: true),
                    CANCMETBR = table.Column<bool>(type: "bit", nullable: true),
                    CANCMETOTH = table.Column<bool>(type: "bit", nullable: true),
                    CANCERUNK = table.Column<bool>(type: "bit", nullable: true),
                    CANCBLOOD = table.Column<bool>(type: "bit", nullable: true),
                    CANCBREAST = table.Column<bool>(type: "bit", nullable: true),
                    CANCCOLON = table.Column<bool>(type: "bit", nullable: true),
                    CANCLUNG = table.Column<bool>(type: "bit", nullable: true),
                    CANCPROST = table.Column<bool>(type: "bit", nullable: true),
                    CANCOTHER = table.Column<bool>(type: "bit", nullable: true),
                    CANCOTHERX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CANCRAD = table.Column<bool>(type: "bit", nullable: true),
                    CANCRESECT = table.Column<bool>(type: "bit", nullable: true),
                    CANCIMMUNO = table.Column<bool>(type: "bit", nullable: true),
                    CANCBONE = table.Column<bool>(type: "bit", nullable: true),
                    CANCCHEMO = table.Column<bool>(type: "bit", nullable: true),
                    CANCHORM = table.Column<bool>(type: "bit", nullable: true),
                    CANCTROTH = table.Column<bool>(type: "bit", nullable: true),
                    CANCTROTHX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CANCERAGE = table.Column<int>(type: "int", nullable: true),
                    COVID19 = table.Column<int>(type: "int", nullable: true),
                    COVIDHOSP = table.Column<int>(type: "int", nullable: true),
                    PULMONARY = table.Column<int>(type: "int", nullable: true),
                    KIDNEY = table.Column<int>(type: "int", nullable: true),
                    KIDNEYAGE = table.Column<int>(type: "int", nullable: true),
                    LIVER = table.Column<int>(type: "int", nullable: true),
                    LIVERAGE = table.Column<int>(type: "int", nullable: true),
                    PVD = table.Column<int>(type: "int", nullable: true),
                    PVDAGE = table.Column<int>(type: "int", nullable: true),
                    HIVDIAG = table.Column<int>(type: "int", nullable: true),
                    HIVAGE = table.Column<int>(type: "int", nullable: true),
                    OTHCOND = table.Column<int>(type: "int", nullable: true),
                    OTHCONDX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MAJORDEP = table.Column<int>(type: "int", nullable: true),
                    OTHERDEP = table.Column<int>(type: "int", nullable: true),
                    DEPRTREAT = table.Column<bool>(type: "bit", nullable: true),
                    BIPOLAR = table.Column<int>(type: "int", nullable: true),
                    SCHIZ = table.Column<int>(type: "int", nullable: true),
                    ANXIETY = table.Column<int>(type: "int", nullable: true),
                    GENERALANX = table.Column<int>(type: "int", nullable: true),
                    PANICDIS = table.Column<int>(type: "int", nullable: true),
                    OCD = table.Column<int>(type: "int", nullable: true),
                    OTHANXDIS = table.Column<int>(type: "int", nullable: true),
                    OTHANXDISX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    PTSD = table.Column<int>(type: "int", nullable: true),
                    NPSYDEV = table.Column<int>(type: "int", nullable: true),
                    PSYCDIS = table.Column<int>(type: "int", nullable: true),
                    PSYCDISX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    MENARCHE = table.Column<int>(type: "int", nullable: true),
                    NOMENSAGE = table.Column<int>(type: "int", nullable: true),
                    NOMENSNAT = table.Column<bool>(type: "bit", nullable: true),
                    NOMENSHYST = table.Column<bool>(type: "bit", nullable: true),
                    NOMENSSURG = table.Column<bool>(type: "bit", nullable: true),
                    NOMENSCHEM = table.Column<bool>(type: "bit", nullable: true),
                    NOMENSRAD = table.Column<bool>(type: "bit", nullable: true),
                    NOMENSHORM = table.Column<bool>(type: "bit", nullable: true),
                    NOMENSESTR = table.Column<bool>(type: "bit", nullable: true),
                    NOMENSUNK = table.Column<bool>(type: "bit", nullable: true),
                    NOMENSOTH = table.Column<bool>(type: "bit", nullable: true),
                    NOMENSOTHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    HRT = table.Column<int>(type: "int", nullable: true),
                    HRTYEARS = table.Column<int>(type: "int", nullable: true),
                    HRTSTRTAGE = table.Column<int>(type: "int", nullable: true),
                    HRTENDAGE = table.Column<int>(type: "int", nullable: true),
                    BCPILLS = table.Column<int>(type: "int", nullable: true),
                    BCPILLSYR = table.Column<int>(type: "int", nullable: true),
                    BCSTARTAGE = table.Column<int>(type: "int", nullable: true),
                    BCENDAGE = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_tbl_A5D2s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_A5D2s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4as_VisitId",
                table: "tbl_A4as",
                column: "VisitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A5D2s_VisitId",
                table: "tbl_A5D2s",
                column: "VisitId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_A5D2s");

            migrationBuilder.DropIndex(
                name: "IX_tbl_A4as_VisitId",
                table: "tbl_A4as");

            migrationBuilder.CreateTable(
                name: "tbl_A5s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    ABUSOTHR = table.Column<int>(type: "int", nullable: true),
                    ABUSX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    ALCFREQ = table.Column<int>(type: "int", nullable: true),
                    ALCOCCAS = table.Column<int>(type: "int", nullable: true),
                    ALCOHOL = table.Column<int>(type: "int", nullable: true),
                    ANXIETY = table.Column<int>(type: "int", nullable: true),
                    APNEA = table.Column<int>(type: "int", nullable: true),
                    ARTHLOEX = table.Column<int>(type: "int", nullable: true),
                    ARTHRIT = table.Column<int>(type: "int", nullable: true),
                    ARTHSPIN = table.Column<int>(type: "int", nullable: true),
                    ARTHTYPE = table.Column<int>(type: "int", nullable: true),
                    ARTHTYPX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    ARTHUNK = table.Column<int>(type: "int", nullable: true),
                    ARTHUPEX = table.Column<int>(type: "int", nullable: true),
                    B12DEF = table.Column<int>(type: "int", nullable: true),
                    BIPOLAR = table.Column<int>(type: "int", nullable: true),
                    CBSTROKE = table.Column<int>(type: "int", nullable: true),
                    CBTIA = table.Column<int>(type: "int", nullable: true),
                    CVAFIB = table.Column<int>(type: "int", nullable: true),
                    CVANGINA = table.Column<int>(type: "int", nullable: true),
                    CVANGIO = table.Column<int>(type: "int", nullable: true),
                    CVBYPASS = table.Column<int>(type: "int", nullable: true),
                    CVCHF = table.Column<int>(type: "int", nullable: true),
                    CVHATT = table.Column<int>(type: "int", nullable: true),
                    CVHVALVE = table.Column<int>(type: "int", nullable: true),
                    CVOTHR = table.Column<int>(type: "int", nullable: true),
                    CVOTHRX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CVPACDEF = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DEP2YRS = table.Column<int>(type: "int", nullable: true),
                    DEPOTHR = table.Column<int>(type: "int", nullable: true),
                    DIABETES = table.Column<int>(type: "int", nullable: true),
                    DIABTYPE = table.Column<int>(type: "int", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HATTMULT = table.Column<int>(type: "int", nullable: true),
                    HATTYEAR = table.Column<int>(type: "int", nullable: true),
                    HYPERCHO = table.Column<int>(type: "int", nullable: true),
                    HYPERTEN = table.Column<int>(type: "int", nullable: true),
                    INCONTF = table.Column<int>(type: "int", nullable: true),
                    INCONTU = table.Column<int>(type: "int", nullable: true),
                    INSOMN = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NPSYDEV = table.Column<int>(type: "int", nullable: true),
                    OCD = table.Column<int>(type: "int", nullable: true),
                    OTHSLEEP = table.Column<int>(type: "int", nullable: true),
                    OTHSLEEX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    PACKSPER = table.Column<int>(type: "int", nullable: true),
                    PD = table.Column<int>(type: "int", nullable: true),
                    PDOTHR = table.Column<int>(type: "int", nullable: true),
                    PDOTHRYR = table.Column<int>(type: "int", nullable: true),
                    PDYR = table.Column<int>(type: "int", nullable: true),
                    PSYCDIS = table.Column<int>(type: "int", nullable: true),
                    PSYCDISX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    PTSD = table.Column<int>(type: "int", nullable: true),
                    QUITSMOK = table.Column<int>(type: "int", nullable: true),
                    RBD = table.Column<int>(type: "int", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true),
                    SCHIZ = table.Column<int>(type: "int", nullable: true),
                    SEIZURES = table.Column<int>(type: "int", nullable: true),
                    SMOKYRS = table.Column<int>(type: "int", nullable: true),
                    STROKMUL = table.Column<int>(type: "int", nullable: true),
                    STROKYR = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TBI = table.Column<int>(type: "int", nullable: true),
                    TBIBRIEF = table.Column<int>(type: "int", nullable: true),
                    TBIEXTEN = table.Column<int>(type: "int", nullable: true),
                    TBIWOLOS = table.Column<int>(type: "int", nullable: true),
                    TBIYEAR = table.Column<int>(type: "int", nullable: true),
                    THYROID = table.Column<int>(type: "int", nullable: true),
                    TIAMULT = table.Column<int>(type: "int", nullable: true),
                    TIAYEAR = table.Column<int>(type: "int", nullable: true),
                    TOBAC100 = table.Column<int>(type: "int", nullable: true),
                    TOBAC30 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_A5s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_A5s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_D2s",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    AFIBRILL = table.Column<int>(type: "int", nullable: true),
                    ANGINA = table.Column<int>(type: "int", nullable: true),
                    ANGIOCP = table.Column<int>(type: "int", nullable: true),
                    ANGIOPCI = table.Column<int>(type: "int", nullable: true),
                    ANTIENC = table.Column<int>(type: "int", nullable: true),
                    ANTIENCX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    ARTH = table.Column<int>(type: "int", nullable: true),
                    ARTLOEX = table.Column<int>(type: "int", nullable: true),
                    ARTSPIN = table.Column<int>(type: "int", nullable: true),
                    ARTUNKN = table.Column<int>(type: "int", nullable: true),
                    ARTUPEX = table.Column<int>(type: "int", nullable: true),
                    ARTYPE = table.Column<int>(type: "int", nullable: true),
                    ARTYPEX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    BOWLINC = table.Column<int>(type: "int", nullable: true),
                    CANCER = table.Column<int>(type: "int", nullable: true),
                    CANCSITE = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CONGHRT = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DIABET = table.Column<int>(type: "int", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HVALVE = table.Column<int>(type: "int", nullable: true),
                    HYPCHOL = table.Column<int>(type: "int", nullable: true),
                    HYPERT = table.Column<int>(type: "int", nullable: true),
                    HYPOSOM = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    MYOINF = table.Column<int>(type: "int", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OTHCOND = table.Column<int>(type: "int", nullable: true),
                    OTHCONDX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    PACEMAKE = table.Column<int>(type: "int", nullable: true),
                    REMDIS = table.Column<int>(type: "int", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true),
                    SLEEPAP = table.Column<int>(type: "int", nullable: true),
                    SLEEPOTH = table.Column<int>(type: "int", nullable: true),
                    SLEEPOTX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    THYDIS = table.Column<int>(type: "int", nullable: true),
                    URINEINC = table.Column<int>(type: "int", nullable: true),
                    VB12DEF = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_D2s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_D2s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A4as_VisitId",
                table: "tbl_A4as",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_A5s_VisitId",
                table: "tbl_A5s",
                column: "VisitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_D2s_VisitId",
                table: "tbl_D2s",
                column: "VisitId",
                unique: true);
        }
    }
}
