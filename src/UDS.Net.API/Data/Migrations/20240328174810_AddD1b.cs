using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddD1b : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_D1bs",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LANG = table.Column<int>(type: "int", nullable: true),
                    MODE = table.Column<int>(type: "int", nullable: true),
                    REMOTEMODE = table.Column<int>(type: "int", nullable: true),
                    REMOTEREASON = table.Column<int>(type: "int", nullable: true),
                    SUB = table.Column<bool>(type: "bit", nullable: true),
                    NOT = table.Column<int>(type: "int", nullable: true),
                    BIOMARKDX = table.Column<int>(type: "int", nullable: true, comment: "1. Were any biomarker results used to support the current etiological diagnosis?"),
                    FLUIDBIOM = table.Column<int>(type: "int", nullable: true, comment: "2. Fluid Biomarkers - Were fluid biomarkers used for assessing the etiological diagnosis?"),
                    BLOODAD = table.Column<int>(type: "int", nullable: true, comment: "3a. Blood-based biomarkers - Consistent with AD"),
                    BLOODFTLD = table.Column<int>(type: "int", nullable: true, comment: "3b. Blood-based biomarkers - Consistent with FTLD"),
                    BLOODLBD = table.Column<int>(type: "int", nullable: true, comment: "3c. Blood-based biomarkers - Consistent with LBD"),
                    BLOODOTH = table.Column<int>(type: "int", nullable: true, comment: "3d. Blood-based biomarkers - Consistent with other etiology"),
                    BLOODOTHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "3d1. Blood-based biomarkers - Consistent with other etiology (specify)"),
                    CSFAD = table.Column<int>(type: "int", nullable: true, comment: "4a. CSF-based biomarkers - Consistent with AD"),
                    CSFFTLD = table.Column<int>(type: "int", nullable: true, comment: "4b. CSF-based biomarkers - Consistent with FTLD"),
                    CSFLBD = table.Column<int>(type: "int", nullable: true, comment: "4c. CSF-based biomarkers - Consistent with LBD"),
                    CSFOTH = table.Column<int>(type: "int", nullable: true, comment: "4d. CSF-based biomarkers - Consistent with other etiology"),
                    CSFOTHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "4d1. CSF-based biomarkers - Consistent with other etiology (specify)"),
                    IMAGINGDX = table.Column<int>(type: "int", nullable: true, comment: "5. Imaging - Was imaging used for assessing etiological diagnosis?"),
                    PETDX = table.Column<int>(type: "int", nullable: true, comment: "6a. Tracer-based PET - Were tracer-based PET measures used in assessing an etiological diagnosis?"),
                    AMYLPET = table.Column<int>(type: "int", nullable: true, comment: "6a1. Elevated amyloid"),
                    TAUPET = table.Column<int>(type: "int", nullable: true, comment: "6a2. Elevated tau pathology"),
                    FDGPETDX = table.Column<int>(type: "int", nullable: true, comment: "6b. FDG PET - Was FDG PET data or information used to support an etiological diagnosis?"),
                    FDGAD = table.Column<int>(type: "int", nullable: true, comment: "6b1. FDG PET - Consistent with AD"),
                    FDGFTLD = table.Column<int>(type: "int", nullable: true, comment: "6b2. FDG PET - Consistent with FTLD"),
                    FDGLBD = table.Column<int>(type: "int", nullable: true, comment: "6b3. FDG PET - Consistent with LBD"),
                    FDGOTH = table.Column<int>(type: "int", nullable: true, comment: "6b4. FDG PET - Consistent with other etiology"),
                    FDGOTHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "6b4a. FDG PET - Consistent with other etiology (specify)"),
                    DATSCANDX = table.Column<int>(type: "int", nullable: true, comment: "6c. Dopamine Transporter (DAT) Scan - Was DAT Scan data or information used to support an etiological diagnosis?"),
                    TRACOTHDX = table.Column<int>(type: "int", nullable: true, comment: "6d. Other tracer-based imaging - Were other tracer-based imaging used to support an etiological diagnosis?"),
                    TRACOTHDXX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "6d1a. Other tracer-based imaging - Were other tracer-based imaging used to support an etiological diagnosis? (specify)"),
                    TRACERAD = table.Column<int>(type: "int", nullable: true, comment: "6d1. Other tracer-based imaging - Consistent with AD"),
                    TRACERFTLD = table.Column<int>(type: "int", nullable: true, comment: "6d2. Other tracer-based imaging - Consistent with FTLD"),
                    TRACERLBD = table.Column<int>(type: "int", nullable: true, comment: "6d3. Other tracer-based imaging - Consistent with LBD"),
                    TRACEROTH = table.Column<int>(type: "int", nullable: true, comment: "6d4. Other tracer-based imaging - Consistent with other etiology"),
                    TRACEROTHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "6d4a. Other tracer-based imaging - Consistent with other etiology (specify)"),
                    STRUCTDX = table.Column<int>(type: "int", nullable: true, comment: "7a. Structural Imaging (i.e., MRI or CT) - Was structural imaging data or information used to support an etiological diagnosis?"),
                    STRUCTAD = table.Column<int>(type: "int", nullable: true, comment: "7a1. Atrophy pattern conistent with AD"),
                    STRUCTFTLD = table.Column<int>(type: "int", nullable: true, comment: "7a2. Atrophy pattern consistent with FTLD"),
                    STRUCTCVD = table.Column<int>(type: "int", nullable: true, comment: "7a3. Consistent with cerebrovascular disease (CVD)"),
                    IMAGLINF = table.Column<int>(type: "int", nullable: true, comment: "7a3a. Large vessel infarct(s)"),
                    IMAGLAC = table.Column<int>(type: "int", nullable: true, comment: "7a3b. Lacunar infarct(s)"),
                    IMAGMACH = table.Column<int>(type: "int", nullable: true, comment: "7a3c. Macrohemorrhage(s)"),
                    IMAGMICH = table.Column<int>(type: "int", nullable: true, comment: "7a3d. Microhemorrhage(s)"),
                    IMAGMWMH = table.Column<int>(type: "int", nullable: true, comment: "7a3e. Moderate white-matter hyperintensity (CHS score 5-6)"),
                    IMAGEWMH = table.Column<int>(type: "int", nullable: true, comment: "7a3f. Extensive white-matter hyperinensity (CHS score 7-8+)"),
                    OTHBIOM1 = table.Column<int>(type: "int", nullable: true, comment: "8. Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis?"),
                    OTHBIOMX1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "8a1. Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis? (specify)	OTHBI"),
                    BIOMAD1 = table.Column<int>(type: "int", nullable: true, comment: "8a. Other biomarker modality - Consistent with AD"),
                    BIOMFTLD1 = table.Column<int>(type: "int", nullable: true, comment: "8b. Other biomarker modality - Consistent with FTLD"),
                    BIOMLBD1 = table.Column<int>(type: "int", nullable: true, comment: "8c. Other biomarker modality - Consistent with LBD"),
                    BIOMOTH1 = table.Column<int>(type: "int", nullable: true, comment: "8d. Other biomarker modality - Consistent with other etiology"),
                    BIOMOTHX1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "8d1. Other biomarker modality - Consistent with other etiology (specify)"),
                    OTHBIOM2 = table.Column<int>(type: "int", nullable: true, comment: "9. Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis?"),
                    OTHBIOMX2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "9a1. Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis? (specify)"),
                    BIOMAD2 = table.Column<int>(type: "int", nullable: true, comment: "9a. Other biomarker modality - Consistent with AD"),
                    BIOMFTLD2 = table.Column<int>(type: "int", nullable: true, comment: "9b. Other biomarker modality - Consistent with FTLD"),
                    BIOMLBD2 = table.Column<int>(type: "int", nullable: true, comment: "9c. Other biomarker modality - Consistent with LBD"),
                    BIOMOTH2 = table.Column<int>(type: "int", nullable: true, comment: "9d. Other biomarker modality - Consistent with other etiology"),
                    BIOMOTHX2 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "9d1. Other biomarker modality - Consistent with other etiology (specify)"),
                    OTHBIOM3 = table.Column<int>(type: "int", nullable: true, comment: "10. Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis?"),
                    OTHBIOMX3 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "10a1. Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis? (specify)"),
                    BIOMAD3 = table.Column<int>(type: "int", nullable: true, comment: "10a. Other biomarker modality - Consistent with AD"),
                    BIOMFTLD3 = table.Column<int>(type: "int", nullable: true, comment: "10b. Other biomarker modality - Consistent with FTLD"),
                    BIOMLBD3 = table.Column<int>(type: "int", nullable: true, comment: "10c. Other biomarker modality - Consistent with LBD"),
                    BIOMOTH3 = table.Column<int>(type: "int", nullable: true, comment: "10d. Other biomarker modality - Consistent with other etiology"),
                    BIOMOTHX3 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "10d1. Other biomarker modality - Consistent with other etiology (specify)"),
                    AUTDOMMUT = table.Column<int>(type: "int", nullable: true, comment: "11. Is there an autosomal dominant pathogenic variant to support an etiological diagnosis?"),
                    ALZDIS = table.Column<bool>(type: "bit", nullable: true, comment: "12. Alzheimer's disease"),
                    ALZDISIF = table.Column<int>(type: "int", nullable: true, comment: "12a. Primary, contributing, or non-contributing - Alzheimer's disease"),
                    LBDIS = table.Column<bool>(type: "bit", nullable: true, comment: "13. Lewy body disease"),
                    LBDIF = table.Column<int>(type: "int", nullable: true, comment: "13a. Primary, contributing, or non-contributing - Lewy body disease"),
                    FTLD = table.Column<bool>(type: "bit", nullable: true, comment: "14. Frontotemporal lobar degeneration"),
                    FTLDIF = table.Column<int>(type: "int", nullable: true, comment: "14a. Primary, contributing, or non-contributing - Frontotemporal lobar degeneration"),
                    PSP = table.Column<bool>(type: "bit", nullable: true, comment: "14ba. Primary supranuclear palsy (PSP)"),
                    PSPIF = table.Column<int>(type: "int", nullable: true, comment: "14b1a. Primary, contributing, or non-contributing - Primary supranuclear palsy (PSP)"),
                    CORT = table.Column<bool>(type: "bit", nullable: true, comment: "14b2. Corticobasal degeneration (CBD)"),
                    CORTIF = table.Column<int>(type: "int", nullable: true, comment: "14b2a. Primary, contributing, or non-contributing - Corticobasal degeneration (CBD)"),
                    FTLDMO = table.Column<bool>(type: "bit", nullable: true, comment: "14b3. FTLD with motor neuron disease"),
                    FTLDMOIF = table.Column<int>(type: "int", nullable: true, comment: "14b3a. Primary, contributing, or non-contributing - FTLD with motor neuron disease"),
                    FTLDNOS = table.Column<bool>(type: "bit", nullable: true, comment: "14b4. FTLD not otherwise specified (NOS)"),
                    FTLDNOIF = table.Column<int>(type: "int", nullable: true, comment: "14b4a. Primary, contributing, or non-contributing - FTLD not otherwise specified (NOS)"),
                    FTLDSUBT = table.Column<int>(type: "int", nullable: true, comment: "14c. FTLD subtype"),
                    FTLDSUBX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "14c1. Other FTLD subtype (specify)"),
                    CVD = table.Column<bool>(type: "bit", nullable: true, comment: "15. Vascular brain injury (based on clinical and imaging evidence according to your Center's standards)"),
                    CVDIF = table.Column<int>(type: "int", nullable: true, comment: "15a. Primary, contributing, or non-contributing - Vascular brain injury"),
                    MSA = table.Column<bool>(type: "bit", nullable: true, comment: "16. Multiple system atrophy"),
                    MSAIF = table.Column<int>(type: "int", nullable: true, comment: "16a. Primary, contributing, or non-contributing - Multiple system atrophy"),
                    CTE = table.Column<bool>(type: "bit", nullable: true, comment: "17. Chronic traumatic encephalopathy"),
                    CTEIF = table.Column<int>(type: "int", nullable: true, comment: "17a. Primary, contributing, or non-contributing - Chronic traumatic encephalopathy"),
                    DOWNS = table.Column<bool>(type: "bit", nullable: true, comment: "18. Down syndrome"),
                    DOWNSIF = table.Column<int>(type: "int", nullable: true, comment: "18a. Primary, contributing, or non-contributing - Down syndrome"),
                    HUNT = table.Column<bool>(type: "bit", nullable: true, comment: "19. Huntington's disease"),
                    HUNTIF = table.Column<int>(type: "int", nullable: true, comment: "19a. Primary, contributing, or non-contributing - Huntington's disease"),
                    PRION = table.Column<bool>(type: "bit", nullable: true, comment: "20. Prion disease (CJD, other)"),
                    PRIONIF = table.Column<int>(type: "int", nullable: true, comment: "20a. Primary, contributing, or non-contributing - Prion disease (CJD, other)"),
                    CAA = table.Column<bool>(type: "bit", nullable: true, comment: "21. Cerebral amyloid angiopathy"),
                    CAAIF = table.Column<int>(type: "int", nullable: true, comment: "21a. Primary, contributing, or non-contributing - Cerebral amyloid angiopathy"),
                    LATE = table.Column<bool>(type: "bit", nullable: true, comment: "22. LATE: Limbic-predominant age-related TDP-43 encephalopathy"),
                    LATEIF = table.Column<int>(type: "int", nullable: true, comment: "22a. Primary, contributing, or non-contributing - LATE"),
                    OTHCOG = table.Column<bool>(type: "bit", nullable: true, comment: "23. Other"),
                    OTHCOGIF = table.Column<int>(type: "int", nullable: true, comment: "23a. Primary, contributing, or non-contributing - Other"),
                    OTHCOGX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "23b. Other (specify)"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_D1bs", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_D1bs_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_D1bs_VisitId",
                table: "tbl_D1bs",
                column: "VisitId",
                unique: true);

            migrationBuilder.Sql(@"ALTER VIEW[dbo].[vw_FormStatuses]
            AS
                SELECT a1.[FormId], a1.[VisitId], a1.[Status], a1.[LANG], a1.[MODE], a1.[REMOTEMODE], a1.[REMOTEREASON], a1.[SUB], a1.[NOT], 'A1' as Kind, a1.[CreatedAt], a1.[CreatedBy], a1.[ModifiedBy], a1.[DeletedBy], a1.[IsDeleted]
                FROM dbo.tbl_A1s as a1
                UNION
                SELECT a1a.[FormId], a1a.[VisitId], a1a.[Status], a1a.[LANG], a1a.[MODE], a1a.[REMOTEMODE], a1a.[REMOTEREASON], a1a.[SUB], a1a.[NOT], 'A1a' as Kind, a1a.[CreatedAt], a1a.[CreatedBy], a1a.[ModifiedBy], a1a.[DeletedBy], a1a.[IsDeleted]
                FROM dbo.tbl_A1as as a1a
                UNION
                SELECT a2.[FormId], a2.[VisitId], a2.[Status], a2.[LANG], a2.[MODE], a2.[REMOTEMODE], a2.[REMOTEREASON], a2.[SUB], a2.[NOT], 'A2' as Kind, a2.[CreatedAt], a2.[CreatedBy], a2.[ModifiedBy], a2.[DeletedBy], a2.[IsDeleted]
                FROM dbo.tbl_A2s as a2
                UNION
                SELECT a3.[FormId], a3.[VisitId], a3.[Status], a3.[LANG], a3.[MODE], a3.[REMOTEMODE], a3.[REMOTEREASON], a3.[SUB], a3.[NOT], 'A3' as Kind, a3.[CreatedAt], a3.[CreatedBy], a3.[ModifiedBy], a3.[DeletedBy], a3.[IsDeleted]
                FROM dbo.tbl_A3s as a3
                UNION
                SELECT a4.[FormId], a4.[VisitId], a4.[Status], a4.[LANG], a4.[MODE], a4.[REMOTEMODE], a4.[REMOTEREASON], a4.[SUB], a4.[NOT], 'A4' as Kind, a4.[CreatedAt], a4.[CreatedBy], a4.[ModifiedBy], a4.[DeletedBy], a4.[IsDeleted]
                FROM dbo.tbl_A4s as a4
                UNION
                SELECT a4a.[FormId], a4a.[VisitId], a4a.[Status], a4a.[LANG], a4a.[MODE], a4a.[REMOTEMODE], a4a.[REMOTEREASON], a4a.[SUB], a4a.[NOT], 'A4a' as Kind, a4a.[CreatedAt], a4a.[CreatedBy], a4a.[ModifiedBy], a4a.[DeletedBy], a4a.[IsDeleted]
                FROM dbo.tbl_A4as as a4a
                UNION
                SELECT a5d2.[FormId], a5d2.[VisitId], a5d2.[Status], a5d2.[LANG], a5d2.[MODE], a5d2.[REMOTEMODE], a5d2.[REMOTEREASON], a5d2.[SUB], a5d2.[NOT], 'A5D2' as Kind, a5d2.[CreatedAt], a5d2.[CreatedBy], a5d2.[ModifiedBy], a5d2.[DeletedBy], a5d2.[IsDeleted]
                FROM dbo.tbl_A5D2s as a5d2
                UNION
                SELECT b1.[FormId], b1.[VisitId], b1.[Status], b1.[LANG], b1.[MODE], b1.[REMOTEMODE], b1.[REMOTEREASON], b1.[SUB], b1.[NOT], 'B1' as Kind, b1.[CreatedAt], b1.[CreatedBy], b1.[ModifiedBy], b1.[DeletedBy], b1.[IsDeleted]
                FROM dbo.tbl_B1s as b1
                UNION
                SELECT b3.[FormId], b3.[VisitId], b3.[Status], b3.[LANG], b3.[MODE], b3.[REMOTEMODE], b3.[REMOTEREASON], b3.[SUB], b3.[NOT], 'B3' as Kind, b3.[CreatedAt], b3.[CreatedBy], b3.[ModifiedBy], b3.[DeletedBy], b3.[IsDeleted]
                FROM dbo.tbl_B3s as b3
                UNION
                SELECT b4.[FormId], b4.[VisitId], b4.[Status], b4.[LANG], b4.[MODE], b4.[REMOTEMODE], b4.[REMOTEREASON], b4.[SUB], b4.[NOT], 'B4' as Kind, b4.[CreatedAt], b4.[CreatedBy], b4.[ModifiedBy], b4.[DeletedBy], b4.[IsDeleted]
                FROM dbo.tbl_B4s as b4
                UNION
                SELECT b5.[FormId], b5.[VisitId], b5.[Status], b5.[LANG], b5.[MODE], b5.[REMOTEMODE], b5.[REMOTEREASON], b5.[SUB], b5.[NOT], 'B5' as Kind, b5.[CreatedAt], b5.[CreatedBy], b5.[ModifiedBy], b5.[DeletedBy], b5.[IsDeleted]
                FROM dbo.tbl_B5s as b5
                UNION
                SELECT b6.[FormId], b6.[VisitId], b6.[Status], b6.[LANG], b6.[MODE], b6.[REMOTEMODE], b6.[REMOTEREASON], b6.[SUB], b6.[NOT], 'B6' as Kind, b6.[CreatedAt], b6.[CreatedBy], b6.[ModifiedBy], b6.[DeletedBy], b6.[IsDeleted]
                FROM dbo.tbl_B6s as b6
                UNION
                SELECT b7.[FormId], b7.[VisitId], b7.[Status], b7.[LANG], b7.[MODE], b7.[REMOTEMODE], b7.[REMOTEREASON], b7.[SUB], b7.[NOT], 'B7' as Kind, b7.[CreatedAt], b7.[CreatedBy], b7.[ModifiedBy], b7.[DeletedBy], b7.[IsDeleted]
                FROM dbo.tbl_B7s as b7
                UNION
                SELECT b8.[FormId], b8.[VisitId], b8.[Status], b8.[LANG], b8.[MODE], b8.[REMOTEMODE], b8.[REMOTEREASON], b8.[SUB], b8.[NOT], 'B8' as Kind, b8.[CreatedAt], b8.[CreatedBy], b8.[ModifiedBy], b8.[DeletedBy], b8.[IsDeleted]
                FROM dbo.tbl_B8s as b8
                UNION
                SELECT b9.[FormId], b9.[VisitId], b9.[Status], b9.[LANG], b9.[MODE], b9.[REMOTEMODE], b9.[REMOTEREASON], b9.[SUB], b9.[NOT], 'B9' as Kind, b9.[CreatedAt], b9.[CreatedBy], b9.[ModifiedBy], b9.[DeletedBy], b9.[IsDeleted]
                FROM dbo.tbl_B9s as b9
                UNION
                SELECT c1.[FormId], c1.[VisitId], c1.[Status], c1.[LANG], c1.[MODE], c1.[REMOTEMODE], c1.[REMOTEREASON], c1.[SUB], c1.[NOT], 'C1' as Kind, c1.[CreatedAt], c1.[CreatedBy], c1.[ModifiedBy], c1.[DeletedBy], c1.[IsDeleted]
                FROM dbo.tbl_C1s as c1
                UNION
                SELECT c2.[FormId], c2.[VisitId], c2.[Status], c2.[LANG], c2.[MODE], c2.[REMOTEMODE], c2.[REMOTEREASON], c2.[SUB], c2.[NOT], 'C2' as Kind, c2.[CreatedAt], c2.[CreatedBy], c2.[ModifiedBy], c2.[DeletedBy], c2.[IsDeleted]
                FROM dbo.tbl_C2s as c2
                UNION
                SELECT d1a.[FormId], d1a.[VisitId], d1a.[Status], d1a.[LANG], d1a.[MODE], d1a.[REMOTEMODE], d1a.[REMOTEREASON], d1a.[SUB], d1a.[NOT], 'D1a' as Kind, d1a.[CreatedAt], d1a.[CreatedBy], d1a.[ModifiedBy], d1a.[DeletedBy], d1a.[IsDeleted]
                FROM dbo.tbl_D1as as d1a
                UNION
                SELECT d1b.[FormId], d1b.[VisitId], d1b.[Status], d1b.[LANG], d1b.[MODE], d1b.[REMOTEMODE], d1b.[REMOTEREASON], d1b.[SUB], d1b.[NOT], 'D1b' as Kind, d1b.[CreatedAt], d1b.[CreatedBy], d1b.[ModifiedBy], d1b.[DeletedBy], d1b.[IsDeleted]
                FROM dbo.tbl_D1bs as d1b
                UNION
                SELECT t1.[FormId], t1.[VisitId], t1.[Status], t1.[LANG], t1.[MODE], t1.[REMOTEMODE], t1.[REMOTEREASON], t1.[SUB], t1.[NOT], 'T1' as Kind, t1.[CreatedAt], t1.[CreatedBy], t1.[ModifiedBy], t1.[DeletedBy], t1.[IsDeleted]
                FROM dbo.tbl_T1s as t1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_D1bs");
        }
    }
}
