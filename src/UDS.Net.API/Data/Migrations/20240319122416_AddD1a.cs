using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddD1a : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_D1s");

            migrationBuilder.CreateTable(
                name: "tbl_D1as",
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
                    DXMETHOD = table.Column<int>(type: "int", nullable: true, comment: "1. Diagnosis method—responses in this form are based on diagnosis by a:"),
                    NORMCOG = table.Column<int>(type: "int", nullable: true, comment: "2. Does the participant have unimpaired cognition & behavior"),
                    SCD = table.Column<int>(type: "int", nullable: true, comment: "2a. Does the participant report 1) significant concerns about changes in cognition AND 2) no neuropsychological evidence of decline AND 3) no functional decline?"),
                    SCDDXCONF = table.Column<int>(type: "int", nullable: true, comment: "2b. As a clinician, are you confident that the subjective cognitive decline is clinically meaningful?"),
                    DEMENTED = table.Column<int>(type: "int", nullable: true, comment: "3. Does the participant meet criteria for dementia?"),
                    MCICRITCLN = table.Column<bool>(type: "bit", nullable: true, comment: "4a1. MCI criteria - Clinical concern about decline in cognition compared to participant’s prior level of lifelong or usual cognitive function"),
                    MCICRITIMP = table.Column<bool>(type: "bit", nullable: true, comment: "4a2. MCI criteria - Impairment in one or more cognitive domains, compared to participant’s estimated prior level of lifelong or usual cognitive function, or supported by objective longitudinal neuropsychological evidence of decline"),
                    MCICRITFUN = table.Column<bool>(type: "bit", nullable: true, comment: "4a3. MCI criteria - Largely preserved functional independence OR functional dependence that is not related to cognitive decline"),
                    MCI = table.Column<int>(type: "int", nullable: true, comment: "4b. Does the participant meet criteria for MCI (amnestic or non-amnestic)?"),
                    IMPNOMCIFU = table.Column<bool>(type: "bit", nullable: true, comment: "5a1. Cognitively impaired, not MCI reason - Evidence of functional impairment (e.g., CDR SB>0 and/or FAS>0), but available cognitive testing is judged to be normal"),
                    IMPNOMCICG = table.Column<bool>(type: "bit", nullable: true, comment: "5a2. Cognitively impaired, not MCI reason - Cognitive testing is abnormal but no clinical concern or functional decline (e.g., CDR SB=0 and FAS=0)"),
                    IMPNOMCLCD = table.Column<bool>(type: "bit", nullable: true, comment: "5a3. Cognitively impaired, not MCI reason - Longstanding cognitive difficulties, not representing a change from their usual function"),
                    IMPNOMCIO = table.Column<bool>(type: "bit", nullable: true, comment: "5a4. Cognitively impaired, not MCI reason - Other"),
                    IMPNOMCIOX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "5a4a. Cognitively impaired, not MCI reason - Other (specify)"),
                    IMPNOMCI = table.Column<bool>(type: "bit", nullable: true, comment: "5b. Cognitively impaired, not MCI"),
                    CDOMMEM = table.Column<bool>(type: "bit", nullable: true, comment: "6a. Dementia and MCI affected domains - Memory"),
                    CDOMLANG = table.Column<bool>(type: "bit", nullable: true, comment: "6b. Dementia and MCI affected domains - Language"),
                    CDOMATTN = table.Column<bool>(type: "bit", nullable: true, comment: "6c. Dementia and MCI affected domains - Attention"),
                    CDOMEXEC = table.Column<bool>(type: "bit", nullable: true, comment: "6d. Dementia and MCI affected domains - Executive"),
                    CDOMVISU = table.Column<bool>(type: "bit", nullable: true, comment: "6e. Dementia and MCI affected domains - Visuospatial"),
                    CDOMBEH = table.Column<bool>(type: "bit", nullable: true, comment: "6f. Dementia and MCI affected domains - Behavioral"),
                    CDOMAPRAX = table.Column<bool>(type: "bit", nullable: true, comment: "6g. Dementia and MCI affected domains - Apraxia"),
                    MBI = table.Column<int>(type: "int", nullable: true, comment: "7. Does the participant meet criteria for MBI"),
                    BDOMMOT = table.Column<int>(type: "int", nullable: true, comment: "7a. MBI affected domains - Motivation"),
                    BDOMAFREG = table.Column<int>(type: "int", nullable: true, comment: "7b. MBI affected domains - Affective regulation"),
                    BDOMIMP = table.Column<int>(type: "int", nullable: true, comment: "7c. MBI affected domains - Impulse control"),
                    BDOMSOCIAL = table.Column<int>(type: "int", nullable: true, comment: "7d. MBI affected domains - Social appropriateness"),
                    BDOMTHTS = table.Column<int>(type: "int", nullable: true, comment: "7e. MBI affected domains - Thought content/perception"),
                    AMNDEM = table.Column<bool>(type: "bit", nullable: true, comment: "8a. Amnestic predominant syndrome"),
                    DYEXECSYN = table.Column<bool>(type: "bit", nullable: true, comment: "8b. Dysexecutive predominant syndrome"),
                    PCA = table.Column<bool>(type: "bit", nullable: true, comment: "8c. Primary visual presentation (such as posterior cortical atrophy (PCA) syndrome)"),
                    PPASYN = table.Column<bool>(type: "bit", nullable: true, comment: "8d. Primary progressive aphasia (PPA) syndrome"),
                    PPASYNT = table.Column<int>(type: "int", nullable: true, comment: "8d1. Primary progressive aphasia (PPA) syndrome - type"),
                    FTDSYN = table.Column<bool>(type: "bit", nullable: true, comment: "8e. Behavioral variant frontotemporal (bvFTD) syndrome"),
                    LBDSYN = table.Column<bool>(type: "bit", nullable: true, comment: "8f. Lewy body syndrome"),
                    LBDSYNT = table.Column<int>(type: "int", nullable: true, comment: "8f1. Lewy body syndrome - type"),
                    NAMNDEM = table.Column<bool>(type: "bit", nullable: true, comment: "8g. Non-amnestic multidomain syndrome, not PCA, PPA, bvFT, or DLB syndrome"),
                    PSPSYN = table.Column<bool>(type: "bit", nullable: true, comment: "8h. Primary supranuclear palsy (PSP) syndrome"),
                    PSPSYNT = table.Column<int>(type: "int", nullable: true, comment: "8h1. Primary supranuclear palsy (PSP) syndrome - type"),
                    CTESYN = table.Column<bool>(type: "bit", nullable: true, comment: "8i. Traumatic encephalopathy syndrome"),
                    CBSSYN = table.Column<bool>(type: "bit", nullable: true, comment: "8j. Corticobasal syndrome (CBS)"),
                    MSASYN = table.Column<bool>(type: "bit", nullable: true, comment: "8k. Multiple system atrophy (MSA) syndrome"),
                    MSASYNT = table.Column<int>(type: "int", nullable: true, comment: "8k1. Multiple system atrophy (MSA) syndrome - type"),
                    OTHSYN = table.Column<bool>(type: "bit", nullable: true, comment: "8l. Other syndrome"),
                    OTHSYNX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "8l1. Other syndrome (specify)"),
                    SYNINFCLIN = table.Column<bool>(type: "bit", nullable: true, comment: "9a. Indicate the source(s) of information used to assign the clinical syndrome - Clinical information (history, CDR)"),
                    SYNINFCTST = table.Column<bool>(type: "bit", nullable: true, comment: "9b. Indicate the source(s) of information used to assign the clinical syndrome - Cognitive testing"),
                    SYNINFBIOM = table.Column<bool>(type: "bit", nullable: true, comment: "9c. Indicate the source(s) of information used to assign the clinical syndrome - Biomarkers (MRI, PET, CSF, plasma)"),
                    MAJDEPDX = table.Column<bool>(type: "bit", nullable: true, comment: "10. Major depressive disorder (present)"),
                    MAJDEPDIF = table.Column<int>(type: "int", nullable: true, comment: "10a. Major depressive disorder (primary/contributing/non-contributing)"),
                    OTHDEPDX = table.Column<bool>(type: "bit", nullable: true, comment: "11. Other specified depressive disorder (present)"),
                    OTHDEPDIF = table.Column<int>(type: "int", nullable: true, comment: "11a. Other specified depressive disorder (primary/contributing/non-contributing)"),
                    BIPOLDX = table.Column<bool>(type: "bit", nullable: true, comment: "12. Bipolar disorder (present)"),
                    BIPOLDIF = table.Column<int>(type: "int", nullable: true, comment: "12a. Bipolar disorder (primary/contributing/non-contributing)"),
                    SCHIZOP = table.Column<bool>(type: "bit", nullable: true, comment: "13. Schizophrenia or other psychotic disorder (present)"),
                    SCHIZOIF = table.Column<int>(type: "int", nullable: true, comment: "13a. Schizophrenia or other psychotic disorder (primary/contributing/non-contributing)"),
                    ANXIET = table.Column<bool>(type: "bit", nullable: true, comment: "14. Anxiety disorder (present)"),
                    ANXIETIF = table.Column<bool>(type: "bit", nullable: true, comment: "14a. Anxiety disorder (primary/contributing/non-contributing)"),
                    GENANX = table.Column<bool>(type: "bit", nullable: true, comment: "14b. Generalized Anxiety Disorder"),
                    PANICDISDX = table.Column<bool>(type: "bit", nullable: true, comment: "14c. Panic Disorder"),
                    OCDDX = table.Column<bool>(type: "bit", nullable: true, comment: "14d. Obsessive-compulsive disorder (OCD)"),
                    OTHANXD = table.Column<bool>(type: "bit", nullable: true, comment: "14e. Other anxiety disorder"),
                    OTHANXDX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "14e1. Other anxiety disorder (specify)"),
                    PTSDDX = table.Column<bool>(type: "bit", nullable: true, comment: "15. Post-traumatic stress disorder (PTSD) (present)"),
                    PTSDDXIF = table.Column<int>(type: "int", nullable: true, comment: "15a. Post-traumatic stress disorder (PTSD) (primary/contributing/non-contributing)"),
                    NDEVDIS = table.Column<bool>(type: "bit", nullable: true, comment: "16. Developmental neuropsychiatric disorders (e.g., autism spectrum disorder (ASD), attention-deficit hyperactivity disorder (ADHD), dyslexia) (present)"),
                    NDEVDISIF = table.Column<int>(type: "int", nullable: true, comment: "16a. Developmental neuropsychiatric disorders (e.g., autism spectrum disorder (ASD), attention-deficit hyperactivity disorder (primary/contributing/non-contributing)"),
                    DELIR = table.Column<bool>(type: "bit", nullable: true, comment: "17. Delirium (present)"),
                    DELIRIF = table.Column<int>(type: "int", nullable: true, comment: "17a. Delirium (primary/contributing/non-contributing)"),
                    OTHPSY = table.Column<bool>(type: "bit", nullable: true, comment: "18. Other psychiatric disorder (present)"),
                    OTHPSYIF = table.Column<int>(type: "int", nullable: true, comment: "18a. Other psychiatric disorder (primary/contributing/non-contributing)"),
                    OTHPSYX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "18b. Other psychiatric disorder (specify)"),
                    TBIDX = table.Column<bool>(type: "bit", nullable: true, comment: "19. Traumatic brain injury (present)"),
                    TBIDXIF = table.Column<int>(type: "int", nullable: true, comment: "19a. Traumatic brain injury (primary/contributing/non-contributing)"),
                    EPILEP = table.Column<bool>(type: "bit", nullable: true, comment: "20. Epilepsy (present)"),
                    EPILEPIF = table.Column<int>(type: "int", nullable: true, comment: "20a. Epilepsy (primary/contributing/non-contributing)"),
                    HYCEPH = table.Column<bool>(type: "bit", nullable: true, comment: "21. Normal-pressure hydrocephalus (present)"),
                    HYCEPHIF = table.Column<int>(type: "int", nullable: true, comment: "21a. Normal-pressure hydrocephalus (primary/contributing/non-contributing)"),
                    NEOP = table.Column<bool>(type: "bit", nullable: true, comment: "22. CNS Neoplasm (present)"),
                    NEOPIF = table.Column<int>(type: "int", nullable: true, comment: "22a. CNS Neoplasm (primary/contributing/non-contributing)"),
                    NEOPSTAT = table.Column<int>(type: "int", nullable: true, comment: "22b. CNS Neoplasm - benign or malignant"),
                    HIV = table.Column<bool>(type: "bit", nullable: true, comment: "23. Human Immunodeficiency Virus (HIV) infection (present)"),
                    HIVIF = table.Column<int>(type: "int", nullable: true, comment: "23a. Human Immunodeficiency Virus (HIV) infection (primary/contributing/non-contributing)"),
                    POSTC19 = table.Column<bool>(type: "bit", nullable: true, comment: "24. Post COVID-19 cognitive impairment (present)"),
                    POSTC19IF = table.Column<int>(type: "int", nullable: true, comment: "24a. Post COVID-19 cognitive impairment (primary/contributing/non-contributing)"),
                    APNEADX = table.Column<bool>(type: "bit", nullable: true, comment: "25. Sleep apnea (i.e., obstructive, central, mixed or complex sleep apnea) (present)"),
                    APNEADXIF = table.Column<int>(type: "int", nullable: true, comment: "25a. Sleep apnea (i.e., obstructive, central, mixed or complex sleep apnea) (primary/contributing/non-contributing)"),
                    OTHCOGILL = table.Column<bool>(type: "bit", nullable: true, comment: "26. Cognitive impairment due to other neurologic, genetic, infectious conditions (not listed above), or systemic disease/medical illness (as indicated on Form A5/D2) (present)"),
                    OTHCILLIF = table.Column<int>(type: "int", nullable: true, comment: "26a. Cognitive impairment due to other neurologic, genetic, infectious conditions (not listed above), or systemic disease/medical illness (as indicated on Form A5/D2) (primary/contributing/non-contributing)"),
                    OTHCOGILLX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "26b. Specify cognitive impairment due to other neurologic, genetic, infection conditions or systemic disease"),
                    ALCDEM = table.Column<bool>(type: "bit", nullable: true, comment: "27. Cognitive impairment due to alcohol abuse (present)"),
                    ALCDEMIF = table.Column<int>(type: "int", nullable: true, comment: "27a. Cognitive impairment due to alcohol abuse (primary/contributing/non-contributing)"),
                    IMPSUB = table.Column<bool>(type: "bit", nullable: true, comment: "28. Cognitive impairment due to substance use or abuse (present)"),
                    IMPSUBIF = table.Column<int>(type: "int", nullable: true, comment: "28a. Cognitive impairment due to substance use or abuse (primary/contributing/non-contributing)"),
                    MEDS = table.Column<bool>(type: "bit", nullable: true, comment: "29. Cognitive impairment due to medications (present)"),
                    MEDSIF = table.Column<int>(type: "int", nullable: true, comment: "29a. Cognitive impairment due to medications (primary/contributing/non-contributing)"),
                    COGOTH = table.Column<bool>(type: "bit", nullable: true, comment: "30. Cognitive impairment not otherwise specified (NOS) (present)"),
                    COGOTHIF = table.Column<int>(type: "int", nullable: true, comment: "30a. Cognitive impairment NOS (primary/contributing/non-contributing)"),
                    COGOTHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "30b. Cognitive impairment NOS (specify)"),
                    COGOTH2 = table.Column<bool>(type: "bit", nullable: true, comment: "31. Cognitive impairment not otherwise specified (NOS) (present)"),
                    COGOTH2F = table.Column<int>(type: "int", nullable: true, comment: "31a. Cognitive impairment NOS (primary/contributing/non-contributing)"),
                    COGOTH2X = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "31b. Cognitive impairment NOS (specify)"),
                    COGOTH3 = table.Column<bool>(type: "bit", nullable: true, comment: "32. Cognitive impairment not otherwise specified (NOS) (present)"),
                    COGOTH3F = table.Column<int>(type: "int", nullable: true, comment: "32a. Cognitive impairment NOS (primary/contributing/non-contributing)"),
                    COGOTH3X = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true, comment: "32b. Cognitive impairment NOS (specify)"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_D1as", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_D1as_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_D1as_VisitId",
                table: "tbl_D1as",
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
                SELECT t1.[FormId], t1.[VisitId], t1.[Status], t1.[LANG], t1.[MODE], t1.[REMOTEMODE], t1.[REMOTEREASON], t1.[SUB], t1.[NOT], 'T1' as Kind, t1.[CreatedAt], t1.[CreatedBy], t1.[ModifiedBy], t1.[DeletedBy], t1.[IsDeleted]
                FROM dbo.tbl_T1s as t1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_D1as");

            migrationBuilder.CreateTable(
                name: "tbl_D1s",
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
                    ADMUT = table.Column<int>(type: "int", nullable: true),
                    ALCABUSE = table.Column<int>(type: "int", nullable: true),
                    ALCDEM = table.Column<int>(type: "int", nullable: true),
                    ALCDEMIF = table.Column<int>(type: "int", nullable: true),
                    ALZDIS = table.Column<int>(type: "int", nullable: true),
                    ALZDISIF = table.Column<int>(type: "int", nullable: true),
                    AMNDEM = table.Column<int>(type: "int", nullable: true),
                    AMYLCSF = table.Column<int>(type: "int", nullable: true),
                    AMYLPET = table.Column<int>(type: "int", nullable: true),
                    ANXIET = table.Column<int>(type: "int", nullable: true),
                    ANXIETIF = table.Column<int>(type: "int", nullable: true),
                    BIPOLDIF = table.Column<int>(type: "int", nullable: true),
                    BIPOLDX = table.Column<int>(type: "int", nullable: true),
                    BRNINCTE = table.Column<int>(type: "int", nullable: true),
                    BRNINJ = table.Column<int>(type: "int", nullable: true),
                    BRNINJIF = table.Column<int>(type: "int", nullable: true),
                    COGOTH = table.Column<int>(type: "int", nullable: true),
                    COGOTH2 = table.Column<int>(type: "int", nullable: true),
                    COGOTH2F = table.Column<int>(type: "int", nullable: true),
                    COGOTH2X = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    COGOTH3 = table.Column<int>(type: "int", nullable: true),
                    COGOTH3F = table.Column<int>(type: "int", nullable: true),
                    COGOTH3X = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    COGOTHIF = table.Column<int>(type: "int", nullable: true),
                    COGOTHX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CORT = table.Column<int>(type: "int", nullable: true),
                    CORTIF = table.Column<int>(type: "int", nullable: true),
                    CSFTAU = table.Column<int>(type: "int", nullable: true),
                    CVD = table.Column<int>(type: "int", nullable: true),
                    CVDIF = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DATSCAN = table.Column<int>(type: "int", nullable: true),
                    DELIR = table.Column<int>(type: "int", nullable: true),
                    DELIRIF = table.Column<int>(type: "int", nullable: true),
                    DEMENTED = table.Column<int>(type: "int", nullable: true),
                    DEP = table.Column<int>(type: "int", nullable: true),
                    DEPIF = table.Column<int>(type: "int", nullable: true),
                    DEPTREAT = table.Column<int>(type: "int", nullable: true),
                    DOWNS = table.Column<int>(type: "int", nullable: true),
                    DOWNSIF = table.Column<int>(type: "int", nullable: true),
                    DXMETHOD = table.Column<int>(type: "int", nullable: true),
                    DYSILL = table.Column<int>(type: "int", nullable: true),
                    DYSILLIF = table.Column<int>(type: "int", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EPILEP = table.Column<int>(type: "int", nullable: true),
                    EPILEPIF = table.Column<int>(type: "int", nullable: true),
                    ESSTREIF = table.Column<int>(type: "int", nullable: true),
                    ESSTREM = table.Column<int>(type: "int", nullable: true),
                    FDGAD = table.Column<int>(type: "int", nullable: true),
                    FDGFTLD = table.Column<int>(type: "int", nullable: true),
                    FTDSYN = table.Column<int>(type: "int", nullable: true),
                    FTLDMO = table.Column<int>(type: "int", nullable: true),
                    FTLDMOIF = table.Column<int>(type: "int", nullable: true),
                    FTLDMUT = table.Column<int>(type: "int", nullable: true),
                    FTLDNOIF = table.Column<int>(type: "int", nullable: true),
                    FTLDNOS = table.Column<int>(type: "int", nullable: true),
                    FTLDSUBT = table.Column<int>(type: "int", nullable: true),
                    FTLDSUBX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    HIPPATR = table.Column<int>(type: "int", nullable: true),
                    HIV = table.Column<int>(type: "int", nullable: true),
                    HIVIF = table.Column<int>(type: "int", nullable: true),
                    HUNT = table.Column<int>(type: "int", nullable: true),
                    HUNTIF = table.Column<int>(type: "int", nullable: true),
                    HYCEPH = table.Column<int>(type: "int", nullable: true),
                    HYCEPHIF = table.Column<int>(type: "int", nullable: true),
                    IMAGEWMH = table.Column<int>(type: "int", nullable: true),
                    IMAGLAC = table.Column<int>(type: "int", nullable: true),
                    IMAGLINF = table.Column<int>(type: "int", nullable: true),
                    IMAGMACH = table.Column<int>(type: "int", nullable: true),
                    IMAGMICH = table.Column<int>(type: "int", nullable: true),
                    IMAGMWMH = table.Column<int>(type: "int", nullable: true),
                    IMPNOMCI = table.Column<int>(type: "int", nullable: true),
                    IMPSUB = table.Column<int>(type: "int", nullable: true),
                    IMPSUBIF = table.Column<int>(type: "int", nullable: true),
                    INFNETW = table.Column<int>(type: "int", nullable: true),
                    INFWMH = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LBDIF = table.Column<int>(type: "int", nullable: true),
                    LBDIS = table.Column<int>(type: "int", nullable: true),
                    LBDSYN = table.Column<int>(type: "int", nullable: true),
                    MCIAMEM = table.Column<int>(type: "int", nullable: true),
                    MCIAPATT = table.Column<int>(type: "int", nullable: true),
                    MCIAPEX = table.Column<int>(type: "int", nullable: true),
                    MCIAPLAN = table.Column<int>(type: "int", nullable: true),
                    MCIAPLUS = table.Column<int>(type: "int", nullable: true),
                    MCIAPVIS = table.Column<int>(type: "int", nullable: true),
                    MCIN1ATT = table.Column<int>(type: "int", nullable: true),
                    MCIN1EX = table.Column<int>(type: "int", nullable: true),
                    MCIN1LAN = table.Column<int>(type: "int", nullable: true),
                    MCIN1VIS = table.Column<int>(type: "int", nullable: true),
                    MCIN2ATT = table.Column<int>(type: "int", nullable: true),
                    MCIN2EX = table.Column<int>(type: "int", nullable: true),
                    MCIN2LAN = table.Column<int>(type: "int", nullable: true),
                    MCIN2VIS = table.Column<int>(type: "int", nullable: true),
                    MCINON1 = table.Column<int>(type: "int", nullable: true),
                    MCINON2 = table.Column<int>(type: "int", nullable: true),
                    MEDS = table.Column<int>(type: "int", nullable: true),
                    MEDSIF = table.Column<int>(type: "int", nullable: true),
                    MRFTLD = table.Column<int>(type: "int", nullable: true),
                    MSA = table.Column<int>(type: "int", nullable: true),
                    MSAIF = table.Column<int>(type: "int", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NAMNDEM = table.Column<int>(type: "int", nullable: true),
                    NEOP = table.Column<int>(type: "int", nullable: true),
                    NEOPIF = table.Column<int>(type: "int", nullable: true),
                    NEOPSTAT = table.Column<int>(type: "int", nullable: true),
                    NORMCOG = table.Column<int>(type: "int", nullable: true),
                    OTHBIOM = table.Column<int>(type: "int", nullable: true),
                    OTHBIOMX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    OTHCOG = table.Column<int>(type: "int", nullable: true),
                    OTHCOGIF = table.Column<int>(type: "int", nullable: true),
                    OTHCOGX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    OTHMUT = table.Column<int>(type: "int", nullable: true),
                    OTHMUTX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    OTHPSY = table.Column<int>(type: "int", nullable: true),
                    OTHPSYIF = table.Column<int>(type: "int", nullable: true),
                    OTHPSYX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    PARK = table.Column<int>(type: "int", nullable: true),
                    PCA = table.Column<int>(type: "int", nullable: true),
                    PPASYN = table.Column<int>(type: "int", nullable: true),
                    PPASYNT = table.Column<int>(type: "int", nullable: true),
                    PREVSTK = table.Column<int>(type: "int", nullable: true),
                    PRION = table.Column<int>(type: "int", nullable: true),
                    PRIONIF = table.Column<int>(type: "int", nullable: true),
                    PSP = table.Column<int>(type: "int", nullable: true),
                    PSPIF = table.Column<int>(type: "int", nullable: true),
                    PTSDDX = table.Column<int>(type: "int", nullable: true),
                    PTSDDXIF = table.Column<int>(type: "int", nullable: true),
                    SCHIZOIF = table.Column<int>(type: "int", nullable: true),
                    SCHIZOP = table.Column<int>(type: "int", nullable: true),
                    STKIMAG = table.Column<int>(type: "int", nullable: true),
                    STROKDEC = table.Column<int>(type: "int", nullable: true),
                    TAUPETAD = table.Column<int>(type: "int", nullable: true),
                    TPETFTLD = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_D1s", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_tbl_D1s_tbl_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "tbl_Visits",
                        principalColumn: "VisitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_D1s_VisitId",
                table: "tbl_D1s",
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
                SELECT d1.[FormId], d1.[VisitId], d1.[Status], d1.[LANG], d1.[MODE], d1.[REMOTEMODE], d1.[REMOTEREASON], d1.[SUB], d1.[NOT], 'D1' as Kind, d1.[CreatedAt], d1.[CreatedBy], d1.[ModifiedBy], d1.[DeletedBy], d1.[IsDeleted]
                FROM dbo.tbl_D1s as d1
                UNION
                SELECT t1.[FormId], t1.[VisitId], t1.[Status], t1.[LANG], t1.[MODE], t1.[REMOTEMODE], t1.[REMOTEREASON], t1.[SUB], t1.[NOT], 'T1' as Kind, t1.[CreatedAt], t1.[CreatedBy], t1.[ModifiedBy], t1.[DeletedBy], t1.[IsDeleted]
                FROM dbo.tbl_T1s as t1");
        }
    }
}
