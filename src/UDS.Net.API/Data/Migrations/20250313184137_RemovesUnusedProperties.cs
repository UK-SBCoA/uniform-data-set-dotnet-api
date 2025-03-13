using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UDS.Net.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemovesUnusedProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FTLDIF",
                table: "tbl_D1bs");

            migrationBuilder.DropColumn(
                name: "IMAGEWMH",
                table: "tbl_D1bs");

            migrationBuilder.DropColumn(
                name: "IMAGMWMH",
                table: "tbl_D1bs");

            migrationBuilder.DropColumn(
                name: "AFFFAMM",
                table: "tbl_A3s");

            migrationBuilder.DropColumn(
                name: "NWINFKID",
                table: "tbl_A3s");

            migrationBuilder.DropColumn(
                name: "NWINFMUT",
                table: "tbl_A3s");

            migrationBuilder.DropColumn(
                name: "NWINFSIB",
                table: "tbl_A3s");

            migrationBuilder.DropColumn(
                name: "NEWINF",
                table: "tbl_A2s");

            migrationBuilder.DropColumn(
                name: "COMPUSA",
                table: "tbl_A1as");

            migrationBuilder.DropColumn(
                name: "FAMCOMP",
                table: "tbl_A1as");

            migrationBuilder.DropColumn(
                name: "GUARD2EDU",
                table: "tbl_A1as");

            migrationBuilder.DropColumn(
                name: "GUARD2REL",
                table: "tbl_A1as");

            migrationBuilder.DropColumn(
                name: "GUARD2RELX",
                table: "tbl_A1as");

            migrationBuilder.DropColumn(
                name: "GUARDREL",
                table: "tbl_A1as");

            migrationBuilder.DropColumn(
                name: "GUARDRELX",
                table: "tbl_A1as");

            migrationBuilder.DropColumn(
                name: "TRSPLONGER",
                table: "tbl_A1as");

            migrationBuilder.AlterColumn<string>(
                name: "TRACOTHDXX",
                table: "tbl_D1bs",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                comment: "Other tracer-based imaging - Were other tracer-based imaging used to support an etiological diagnosis? (specify)",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true,
                oldComment: "6d1a. Other tracer-based imaging - Were other tracer-based imaging used to support an etiological diagnosis? (specify)");

            migrationBuilder.AlterColumn<int>(
                name: "TRACOTHDX",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Other tracer-based imaging - Were other tracer-based imaging used to support an etiological diagnosis?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "6d. Other tracer-based imaging - Were other tracer-based imaging used to support an etiological diagnosis?");

            migrationBuilder.AlterColumn<string>(
                name: "TRACEROTHX",
                table: "tbl_D1bs",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                comment: "Other tracer-based imaging - Consistent with other etiology (specify)",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true,
                oldComment: "6d4a. Other tracer-based imaging - Consistent with other etiology (specify)");

            migrationBuilder.AlterColumn<int>(
                name: "TRACEROTH",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Other tracer-based imaging - Consistent with other etiology",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "6d4. Other tracer-based imaging - Consistent with other etiology");

            migrationBuilder.AlterColumn<int>(
                name: "TRACERLBD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Other tracer-based imaging - Consistent with LBD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "6d3. Other tracer-based imaging - Consistent with LBD");

            migrationBuilder.AlterColumn<int>(
                name: "TRACERFTLD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Other tracer-based imaging - Consistent with FTLD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "6d2. Other tracer-based imaging - Consistent with FTLD");

            migrationBuilder.AlterColumn<int>(
                name: "TRACERAD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Other tracer-based imaging - Consistent with AD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "6d1. Other tracer-based imaging - Consistent with AD");

            migrationBuilder.AlterColumn<int>(
                name: "TAUPET",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Elevated tau pathology",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "6a2. Elevated tau pathology");

            migrationBuilder.AlterColumn<int>(
                name: "STRUCTFTLD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Atrophy pattern consistent with FTLD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "7a2. Atrophy pattern consistent with FTLD");

            migrationBuilder.AlterColumn<int>(
                name: "STRUCTDX",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Structural Imaging (i.e., MRI or CT) - Was structural imaging data or information used to support an etiological diagnosis?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "7a. Structural Imaging (i.e., MRI or CT) - Was structural imaging data or information used to support an etiological diagnosis?");

            migrationBuilder.AlterColumn<int>(
                name: "STRUCTCVD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Consistent with cerebrovascular disease (CVD)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "7a3. Consistent with cerebrovascular disease (CVD)");

            migrationBuilder.AlterColumn<int>(
                name: "STRUCTAD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Atrophy pattern consistent with AD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "7a1. Atrophy pattern consistent with AD");

            migrationBuilder.AlterColumn<int>(
                name: "PSPIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Primary, contributing, or non-contributing - Primary supranuclear palsy (PSP)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "14b1a. Primary, contributing, or non-contributing - Primary supranuclear palsy (PSP)");

            migrationBuilder.AlterColumn<bool>(
                name: "PSP",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "Primary supranuclear palsy (PSP)",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "14ba. Primary supranuclear palsy (PSP)");

            migrationBuilder.AlterColumn<int>(
                name: "PRIONIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Primary, contributing, or non-contributing - Prion disease (CJD, other)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "20a. Primary, contributing, or non-contributing - Prion disease (CJD, other)");

            migrationBuilder.AlterColumn<bool>(
                name: "PRION",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "Prion disease (CJD, other)",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "20. Prion disease (CJD, other)");

            migrationBuilder.AlterColumn<int>(
                name: "PETDX",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Tracer-based PET - Were tracer-based PET measures used in assessing an etiological diagnosis?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "6a. Tracer-based PET - Were tracer-based PET measures used in assessing an etiological diagnosis?");

            migrationBuilder.AlterColumn<string>(
                name: "OTHCOGX",
                table: "tbl_D1bs",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                comment: "Other (specify)",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true,
                oldComment: "23b. Other (specify)");

            migrationBuilder.AlterColumn<int>(
                name: "OTHCOGIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Primary, contributing, or non-contributing - Other",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "23a. Primary, contributing, or non-contributing - Other");

            migrationBuilder.AlterColumn<bool>(
                name: "OTHCOG",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "Other",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "23. Other");

            migrationBuilder.AlterColumn<string>(
                name: "OTHBIOMX3",
                table: "tbl_D1bs",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                comment: "Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis? (specify)",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true,
                oldComment: "10a1. Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis? (specify)");

            migrationBuilder.AlterColumn<string>(
                name: "OTHBIOMX2",
                table: "tbl_D1bs",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                comment: "Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis? (specify)",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true,
                oldComment: "9a1. Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis? (specify)");

            migrationBuilder.AlterColumn<string>(
                name: "OTHBIOMX1",
                table: "tbl_D1bs",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                comment: "Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis? (specify)	OTHBI",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true,
                oldComment: "8a1. Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis? (specify)	OTHBI");

            migrationBuilder.AlterColumn<int>(
                name: "OTHBIOM3",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "10. Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis?");

            migrationBuilder.AlterColumn<int>(
                name: "OTHBIOM2",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "9. Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis?");

            migrationBuilder.AlterColumn<int>(
                name: "OTHBIOM1",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "8. Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis?");

            migrationBuilder.AlterColumn<int>(
                name: "MSAIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Primary, contributing, or non-contributing - Multiple system atrophy",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "16a. Primary, contributing, or non-contributing - Multiple system atrophy");

            migrationBuilder.AlterColumn<bool>(
                name: "MSA",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "Multiple system atrophy",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "16. Multiple system atrophy");

            migrationBuilder.AlterColumn<bool>(
                name: "LBDIS",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "Lewy body disease",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "13. Lewy body disease");

            migrationBuilder.AlterColumn<int>(
                name: "LBDIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Primary, contributing, or non-contributing - Lewy body disease",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "13a. Primary, contributing, or non-contributing - Lewy body disease");

            migrationBuilder.AlterColumn<int>(
                name: "LATEIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Primary, contributing, or non-contributing - LATE",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "22a. Primary, contributing, or non-contributing - LATE");

            migrationBuilder.AlterColumn<bool>(
                name: "LATE",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "LATE: Limbic-predominant age-related TDP-43 encephalopathy",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "22. LATE: Limbic-predominant age-related TDP-43 encephalopathy");

            migrationBuilder.AlterColumn<int>(
                name: "IMAGMICH",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "icrohemorrhage(s)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "7a3d. Microhemorrhage(s)");

            migrationBuilder.AlterColumn<int>(
                name: "IMAGMACH",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Macrohemorrhage(s)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "7a3c. Macrohemorrhage(s)");

            migrationBuilder.AlterColumn<int>(
                name: "IMAGLINF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Large vessel infarct(s)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "7a3a. Large vessel infarct(s)");

            migrationBuilder.AlterColumn<int>(
                name: "IMAGLAC",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Lacunar infarct(s)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "7a3b. Lacunar infarct(s)");

            migrationBuilder.AlterColumn<int>(
                name: "IMAGINGDX",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Imaging - Was imaging used for assessing etiological diagnosis?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "5. Imaging - Was imaging used for assessing etiological diagnosis?");

            migrationBuilder.AlterColumn<int>(
                name: "HUNTIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Primary, contributing, or non-contributing - Huntington's disease",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "19a. Primary, contributing, or non-contributing - Huntington's disease");

            migrationBuilder.AlterColumn<bool>(
                name: "HUNT",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "Huntington's disease",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "19. Huntington's disease");

            migrationBuilder.AlterColumn<string>(
                name: "FTLDSUBX",
                table: "tbl_D1bs",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                comment: "Other FTLD subtype (specify)",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true,
                oldComment: "14c1. Other FTLD subtype (specify)");

            migrationBuilder.AlterColumn<int>(
                name: "FTLDSUBT",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "FTLD subtype",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "14c. FTLD subtype");

            migrationBuilder.AlterColumn<bool>(
                name: "FTLDNOS",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "FTLD not otherwise specified (NOS)",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "14b4. FTLD not otherwise specified (NOS)");

            migrationBuilder.AlterColumn<int>(
                name: "FTLDNOIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Primary, contributing, or non-contributing - FTLD not otherwise specified (NOS)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "14b4a. Primary, contributing, or non-contributing - FTLD not otherwise specified (NOS)");

            migrationBuilder.AlterColumn<int>(
                name: "FTLDMOIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Primary, contributing, or non-contributing - FTLD with motor neuron disease",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "14b3a. Primary, contributing, or non-contributing - FTLD with motor neuron disease");

            migrationBuilder.AlterColumn<bool>(
                name: "FTLDMO",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "FTLD with motor neuron disease",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "14b3. FTLD with motor neuron disease");

            migrationBuilder.AlterColumn<bool>(
                name: "FTLD",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "Frontotemporal lobar degeneration",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "14. Frontotemporal lobar degeneration");

            migrationBuilder.AlterColumn<int>(
                name: "FLUIDBIOM",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Fluid Biomarkers - Were fluid biomarkers used for assessing the etiological diagnosis?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "2. Fluid Biomarkers - Were fluid biomarkers used for assessing the etiological diagnosis?");

            migrationBuilder.AlterColumn<int>(
                name: "FDGPETDX",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "FDG PET - Was FDG PET data or information used to support an etiological diagnosis?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "6b. FDG PET - Was FDG PET data or information used to support an etiological diagnosis?");

            migrationBuilder.AlterColumn<string>(
                name: "FDGOTHX",
                table: "tbl_D1bs",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                comment: "FDG PET - Consistent with other etiology (specify)",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true,
                oldComment: "6b4a. FDG PET - Consistent with other etiology (specify)");

            migrationBuilder.AlterColumn<int>(
                name: "FDGOTH",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "FDG PET - Consistent with other etiology",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "6b4. FDG PET - Consistent with other etiology");

            migrationBuilder.AlterColumn<int>(
                name: "FDGLBD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "FDG PET - Consistent with LBD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "6b3. FDG PET - Consistent with LBD");

            migrationBuilder.AlterColumn<int>(
                name: "FDGFTLD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "FDG PET - Consistent with FTLD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "6b2. FDG PET - Consistent with FTLD");

            migrationBuilder.AlterColumn<int>(
                name: "FDGAD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "FDG PET - Consistent with AD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "6b1. FDG PET - Consistent with AD");

            migrationBuilder.AlterColumn<int>(
                name: "DOWNSIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Primary, contributing, or non-contributing - Down syndrome",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "18a. Primary, contributing, or non-contributing - Down syndrome");

            migrationBuilder.AlterColumn<bool>(
                name: "DOWNS",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "Down syndrome",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "18. Down syndrome");

            migrationBuilder.AlterColumn<int>(
                name: "DATSCANDX",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Dopamine Transporter (DAT) Scan - Was DAT Scan data or information used to support an etiological diagnosis?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "6c. Dopamine Transporter (DAT) Scan - Was DAT Scan data or information used to support an etiological diagnosis?");

            migrationBuilder.AlterColumn<int>(
                name: "CVDIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Primary, contributing, or non-contributing - Vascular brain injury",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "15a. Primary, contributing, or non-contributing - Vascular brain injury");

            migrationBuilder.AlterColumn<bool>(
                name: "CVD",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "Vascular brain injury (based on clinical and imaging evidence according to your Center's standards)",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "15. Vascular brain injury (based on clinical and imaging evidence according to your Center's standards)");

            migrationBuilder.AlterColumn<int>(
                name: "CTEIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Primary, contributing, or non-contributing - Chronic traumatic encephalopathy",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "17a. Primary, contributing, or non-contributing - Chronic traumatic encephalopathy");

            migrationBuilder.AlterColumn<bool>(
                name: "CTE",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "Chronic traumatic encephalopathy",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "17. Chronic traumatic encephalopathy");

            migrationBuilder.AlterColumn<string>(
                name: "CSFOTHX",
                table: "tbl_D1bs",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                comment: "CSF-based biomarkers - Consistent with other etiology (specify)",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true,
                oldComment: "4d1. CSF-based biomarkers - Consistent with other etiology (specify)");

            migrationBuilder.AlterColumn<int>(
                name: "CSFOTH",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "CSF-based biomarkers - Consistent with other etiology",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "4d. CSF-based biomarkers - Consistent with other etiology");

            migrationBuilder.AlterColumn<int>(
                name: "CSFLBD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "CSF-based biomarkers - Consistent with LBD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "4c. CSF-based biomarkers - Consistent with LBD");

            migrationBuilder.AlterColumn<int>(
                name: "CSFFTLD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "CSF-based biomarkers - Consistent with FTLD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "4b. CSF-based biomarkers - Consistent with FTLD");

            migrationBuilder.AlterColumn<int>(
                name: "CSFAD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "CSF-based biomarkers - Consistent with AD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "4a. CSF-based biomarkers - Consistent with AD");

            migrationBuilder.AlterColumn<int>(
                name: "CORTIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Primary, contributing, or non-contributing - Corticobasal degeneration (CBD)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "14b2a. Primary, contributing, or non-contributing - Corticobasal degeneration (CBD)");

            migrationBuilder.AlterColumn<bool>(
                name: "CORT",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "Corticobasal degeneration (CBD)",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "14b2. Corticobasal degeneration (CBD)");

            migrationBuilder.AlterColumn<int>(
                name: "CAAIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Primary, contributing, or non-contributing - Cerebral amyloid angiopathy",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "21a. Primary, contributing, or non-contributing - Cerebral amyloid angiopathy");

            migrationBuilder.AlterColumn<bool>(
                name: "CAA",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "Cerebral amyloid angiopathy",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "21. Cerebral amyloid angiopathy");

            migrationBuilder.AlterColumn<string>(
                name: "BLOODOTHX",
                table: "tbl_D1bs",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                comment: "Blood-based biomarkers - Consistent with other etiology (specify)",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true,
                oldComment: "3d1. Blood-based biomarkers - Consistent with other etiology (specify)");

            migrationBuilder.AlterColumn<int>(
                name: "BLOODOTH",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Blood-based biomarkers - Consistent with other etiology",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "3d. Blood-based biomarkers - Consistent with other etiology");

            migrationBuilder.AlterColumn<int>(
                name: "BLOODLBD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Blood-based biomarkers - Consistent with LBD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "3c. Blood-based biomarkers - Consistent with LBD");

            migrationBuilder.AlterColumn<int>(
                name: "BLOODFTLD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Blood-based biomarkers - Consistent with FTLD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "3b. Blood-based biomarkers - Consistent with FTLD");

            migrationBuilder.AlterColumn<int>(
                name: "BLOODAD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Blood-based biomarkers - Consistent with AD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "3a. Blood-based biomarkers - Consistent with AD");

            migrationBuilder.AlterColumn<string>(
                name: "BIOMOTHX3",
                table: "tbl_D1bs",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                comment: "Other biomarker modality - Consistent with other etiology (specify)",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true,
                oldComment: "10d1. Other biomarker modality - Consistent with other etiology (specify)");

            migrationBuilder.AlterColumn<string>(
                name: "BIOMOTHX2",
                table: "tbl_D1bs",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                comment: "Other biomarker modality - Consistent with other etiology (specify)",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true,
                oldComment: "9d1. Other biomarker modality - Consistent with other etiology (specify)");

            migrationBuilder.AlterColumn<string>(
                name: "BIOMOTHX1",
                table: "tbl_D1bs",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                comment: "Other biomarker modality - Consistent with other etiology (specify)",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true,
                oldComment: "8d1. Other biomarker modality - Consistent with other etiology (specify)");

            migrationBuilder.AlterColumn<int>(
                name: "BIOMOTH3",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Other biomarker modality - Consistent with other etiology",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "10d. Other biomarker modality - Consistent with other etiology");

            migrationBuilder.AlterColumn<int>(
                name: "BIOMOTH2",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Other biomarker modality - Consistent with other etiology",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "9d. Other biomarker modality - Consistent with other etiology");

            migrationBuilder.AlterColumn<int>(
                name: "BIOMOTH1",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Other biomarker modality - Consistent with other etiology",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "8d. Other biomarker modality - Consistent with other etiology");

            migrationBuilder.AlterColumn<int>(
                name: "BIOMLBD3",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Other biomarker modality - Consistent with LBD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "10c. Other biomarker modality - Consistent with LBD");

            migrationBuilder.AlterColumn<int>(
                name: "BIOMLBD2",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Other biomarker modality - Consistent with LBD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "9c. Other biomarker modality - Consistent with LBD");

            migrationBuilder.AlterColumn<int>(
                name: "BIOMLBD1",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Other biomarker modality - Consistent with LBD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "8c. Other biomarker modality - Consistent with LBD");

            migrationBuilder.AlterColumn<int>(
                name: "BIOMFTLD3",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Other biomarker modality - Consistent with FTLD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "10b. Other biomarker modality - Consistent with FTLD");

            migrationBuilder.AlterColumn<int>(
                name: "BIOMFTLD2",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Other biomarker modality - Consistent with FTLD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "9b. Other biomarker modality - Consistent with FTLD");

            migrationBuilder.AlterColumn<int>(
                name: "BIOMARKDX",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Were any biomarker results used to support the current etiological diagnosis?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "1. Were any biomarker results used to support the current etiological diagnosis?");

            migrationBuilder.AlterColumn<int>(
                name: "BIOMAD3",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Other biomarker modality - Consistent with AD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "10a. Other biomarker modality - Consistent with AD");

            migrationBuilder.AlterColumn<int>(
                name: "BIOMAD2",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Other biomarker modality - Consistent with AD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "9a. Other biomarker modality - Consistent with AD");

            migrationBuilder.AlterColumn<int>(
                name: "BIOMAD1",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Other biomarker modality - Consistent with AD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "8a. Other biomarker modality - Consistent with AD");

            migrationBuilder.AlterColumn<int>(
                name: "AUTDOMMUT",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Is there an autosomal dominant pathogenic variant to support an etiological diagnosis?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "11. Is there an autosomal dominant pathogenic variant to support an etiological diagnosis?");

            migrationBuilder.AlterColumn<int>(
                name: "AMYLPET",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Elevated amyloid",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "6a1. Elevated amyloid");

            migrationBuilder.AlterColumn<int>(
                name: "ALZDISIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "Primary, contributing, or non-contributing - Alzheimer's disease",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "12a. Primary, contributing, or non-contributing - Alzheimer's disease");

            migrationBuilder.AlterColumn<bool>(
                name: "ALZDIS",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "Alzheimer's disease",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "12. Alzheimer's disease");

            migrationBuilder.AddColumn<int>(
                name: "IMAGWMH",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "White-matter hyperintensity");

            migrationBuilder.AddColumn<int>(
                name: "IMAGWMHSEV",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "White-matter hyperintensity severity");

            migrationBuilder.AlterColumn<int>(
                name: "TRSPMED",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "In the past 30 days, how often has a lack of transportation kept you from medical appointments or from doing things needed for daily living?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "6. In the past 30 days, how often has a lack of transportation kept you from medical appointments or from doing things needed for daily living?");

            migrationBuilder.AlterColumn<int>(
                name: "TRSPACCESS",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "Do you have consistent access to transportation?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "2. Do you have consistent access to transportation?");

            migrationBuilder.AlterColumn<int>(
                name: "TRANSWORRY",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "In the past 30 days, how often did you worry about whether or not you would be able to get somewhere because of a problem with transportation?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "4. In the past 30 days, how often did you worry about whether or not you would be able to get somewhere because of a problem with transportation?");

            migrationBuilder.AlterColumn<int>(
                name: "TRANSPROB",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "In the past 30 days, how often were you not able to leave the house when you wanted to because of a problem with transportation?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "3. In the past 30 days, how often were you not able to leave the house when you wanted to because of a problem with transportation?");

            migrationBuilder.AlterColumn<int>(
                name: "THREATENED",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "In your day-to-day life how often are you threatened or harassed?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "37. In your day-to-day life how often are you threatened or harassed?");

            migrationBuilder.AlterColumn<int>(
                name: "SCRIPTPROB",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "In the past year, how often did you experience challenges in filling a prescription?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "29. In the past year, how often did you experience challenges in filling a prescription?");

            migrationBuilder.AlterColumn<int>(
                name: "SAFEHOME",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "How safe do you feel in your home?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "27a. How safe do you feel in your home?");

            migrationBuilder.AlterColumn<int>(
                name: "SAFECOMM",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "How safe do you feel in your community (or neighborhood)?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "27b. How safe do you feel in your community (or neighborhood)?");

            migrationBuilder.AlterColumn<int>(
                name: "POORSERV",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "In your day-to-day life how often do you receive poorer service than other people at restaurants or stores?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "34. In your day-to-day life how often do you receive poorer service than other people at restaurants or stores?");

            migrationBuilder.AlterColumn<int>(
                name: "POORMEDTRT",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "How frequently did you receive poorer service or treatment from doctors or in hospitals compared to other people?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "38. How frequently did you receive poorer service or treatment from doctors or in hospitals compared to other people?");

            migrationBuilder.AlterColumn<int>(
                name: "PARTICIPATE",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "How often do you participate in activities outside the home (e.g., religious activities, educational activities, volunteer work, paid work, or activities with groups or organizations)?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "26. How often do you participate in activities outside the home (e.g., religious activities, educational activities, volunteer work, paid work, or activities with groups or organizations)?");

            migrationBuilder.AlterColumn<int>(
                name: "PARENTCOMM",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "If your parents are still alive, how often do you have contact with them (including mother, father, mother-in-law, and father-in-law) either in person, by phone, mail, or email (e.g., any online interaction)?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "23. If your parents are still alive, how often do you have contact with them (including mother, father, mother-in-law, and father-in-law) either in person, by phone, mail, or email (e.g., any online interaction)?");

            migrationBuilder.AlterColumn<int>(
                name: "OWNSCAR",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "Do you or someone in your household currently own a car?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "1. Do you or someone in your household currently own a car?");

            migrationBuilder.AlterColumn<int>(
                name: "NOTSMART",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "In your day-to-day life how often do people act as if they think you are not smart?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "35. In your day-to-day life how often do people act as if they think you are not smart?");

            migrationBuilder.AlterColumn<int>(
                name: "MISSPEOPLE",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "I miss having people around",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "19. I miss having people around");

            migrationBuilder.AlterColumn<int>(
                name: "MISSEDFUP",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "In the past year, how often did you miss a follow-up medical appointment that was scheduled?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "30. In the past year, how often did you miss a follow-up medical appointment that was scheduled?");

            migrationBuilder.AlterColumn<int>(
                name: "LESSMEDSYR",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "In the last 12 months, have you ended up taking less medication than was prescribed for you because of the cost?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "14. In the last 12 months, have you ended up taking less medication than was prescribed for you because of the cost?");

            migrationBuilder.AlterColumn<int>(
                name: "LESSMEDS",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "At any time, have you ended up taking less medication than was prescribed for you because of the cost?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "13. At any time, have you ended up taking less medication than was prescribed for you because of the cost?");

            migrationBuilder.AlterColumn<int>(
                name: "LESSCOURT",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "In your day-to-day life how often are you treated with less courtesy or respect than other people?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "33. In your day-to-day life how often are you treated with less courtesy or respect than other people?");

            migrationBuilder.AlterColumn<int>(
                name: "INCOMEYR",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "Which of these income groups represents your household income for the past year? Include income from all sources such as wages, salaries, social security or retirement benefits, help from relatives, rent from property, and so forth.",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "7. Which of these income groups represents your household income for the past year? Include income from all sources such as wages, salaries, social security or retirement benefits, help from relatives, rent from property, and so forth.");

            migrationBuilder.AlterColumn<int>(
                name: "HEALTHACC",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "Overall, which of these describes your health insurance, access to healthcare services, and access to medications?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "32. Overall, which of these describes your health insurance, access to healthcare services, and access to medications?");

            migrationBuilder.AlterColumn<int>(
                name: "GUARDEDU",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "Thinking of the person who raised you, what was their highest level of education completed?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "16. Thinking of the person who raised you, what was their highest level of education completed?");

            migrationBuilder.AlterColumn<int>(
                name: "FRIENDS",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "I feel like I don't have enough friends",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "20. I feel like I don't have enough friends");

            migrationBuilder.AlterColumn<int>(
                name: "FRIENDCOMM",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "How often do you have contact with close friends either in person, by phone, mail, or email (e.g., any online interaction)?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "25. How often do you have contact with close friends either in person, by phone, mail, or email (e.g., any online interaction)?");

            migrationBuilder.AlterColumn<int>(
                name: "FINUPSET",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "If you have had financial problems that lasted twelve months or longer, how upsetting has it been to you?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "10. If you have had financial problems that lasted twelve months or longer, how upsetting has it been to you?");

            migrationBuilder.AlterColumn<int>(
                name: "FINSATIS",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "How satisfied are you with your current personal financial condition?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "8. How satisfied are you with your current personal financial condition?");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPWEIGHT",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "Main reason--Your weight",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "39a7. Main reason--Your weight");

            migrationBuilder.AlterColumn<int>(
                name: "EXPSTRS",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "When you have had day-to-day experiences like those in questions 33 to 38, would you say they have been very stressful, moderately stressful, or not stressful?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "40. When you have had day-to-day experiences like those in questions 33 to 38, would you say they have been very stressful, moderately stressful, or not stressful?");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPSKIN",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "Main reason--Your shade of skin color",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "39a12. Main reason--Your shade of skin color");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPSEXORN",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "Main reason--Your sexual orientation",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "39a9. Main reason--Your sexual orientation");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPRELIG",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "Main reason--Your religion",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "39a5. Main reason--Your religion");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPRACE",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "Main reason--Your race",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "39a3. Main reason--Your race");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPOTHER",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "Main reason -- Other",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "39a13. Main reason -- Other");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPNOTAPP",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "Main reason -- not applicable - I do not have these experiences in my day to day life",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "39a14. Main reason -- not applicable - I do not have these experiences in my day to day life");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPNOANS",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "Main reason--Prefer not to answer",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "39a15. Main reason--Prefer not to answer");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPHEIGHT",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "Main reason--Your height",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "39a6. Main reason--Your height");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPGENDER",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "Main reason--Your gender",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "39a2. Main reason--Your gender");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPEDUCINC",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "Main reason--Your education or income level",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "39a10. Main reason--Your education or income level");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPDISAB",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "Main reason--A physical disability",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "39a11. Main reason--A physical disability");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPAPPEAR",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "Main reason--Some other aspect of your physical appearance",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "39a8. Main reason--Some other aspect of your physical appearance");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPANCEST",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "Main reason--Your Ancestry or National Origins",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "39a1. Main reason--Your Ancestry or National Origins");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPAGE",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "Main reason--Your age",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "39a4. Main reason--Your age");

            migrationBuilder.AlterColumn<int>(
                name: "EMPTINESS",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "I experience a general sense of emptiness",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "18. I experience a general sense of emptiness");

            migrationBuilder.AlterColumn<int>(
                name: "EATLESSYR",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "In the last 12 months, did you ever eat less than you felt you should because there wasn't enough money to buy food?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "12. In the last 12 months, did you ever eat less than you felt you should because there wasn't enough money to buy food?");

            migrationBuilder.AlterColumn<int>(
                name: "EATLESS",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "At any time, did you ever eat less than you felt you should because there wasn't enough money to buy food?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "11. At any time, did you ever eat less than you felt you should because there wasn't enough money to buy food?");

            migrationBuilder.AlterColumn<int>(
                name: "DOCADVICE",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "In the past year, how often did you follow a doctor's advice or treatment plan when it was given?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "31. In the past year, how often did you follow a doctor's advice or treatment plan when it was given?");

            migrationBuilder.AlterColumn<int>(
                name: "DELAYMED",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "In the past year, how often did you delay seeking medical attention for a problem that was bothering you?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "28. In the past year, how often did you delay seeking medical attention for a problem that was bothering you?");

            migrationBuilder.AlterColumn<int>(
                name: "COMPCOMM",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "Where would you place yourself on this ladder compared to others in your community (or neighborhood)? Please mark the number where you would place yourself.",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "15a. Where would you place yourself on this ladder compared to others in your community (or neighborhood)? Please mark the number where you would place yourself.");

            migrationBuilder.AlterColumn<int>(
                name: "CLOSEFRND",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "I miss having a really good friend",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "22. I miss having a really good friend");

            migrationBuilder.AlterColumn<int>(
                name: "CHILDCOMM",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "If you have children, how often do you have contact with your children (including child[ren]-in-law and stepchild[ren]) either in person, by phone, mail, or email (e.g., any online interaction)?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "24. If you have children, how often do you have contact with your children (including child[ren]-in-law and stepchild[ren]) either in person, by phone, mail, or email (e.g., any online interaction)?");

            migrationBuilder.AlterColumn<int>(
                name: "BILLPAY",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "How difficult is it for you to meet monthly payments on your bills?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "9. How difficult is it for you to meet monthly payments on your bills?");

            migrationBuilder.AlterColumn<int>(
                name: "ACTAFRAID",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "In your day-to-day life how often do people act as if they are afraid of you?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "36. In your day-to-day life how often do people act as if they are afraid of you?");

            migrationBuilder.AlterColumn<int>(
                name: "ABANDONED",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "I often feel abandoned",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "21. I often feel abandoned");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IMAGWMH",
                table: "tbl_D1bs");

            migrationBuilder.DropColumn(
                name: "IMAGWMHSEV",
                table: "tbl_D1bs");

            migrationBuilder.AlterColumn<string>(
                name: "TRACOTHDXX",
                table: "tbl_D1bs",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                comment: "6d1a. Other tracer-based imaging - Were other tracer-based imaging used to support an etiological diagnosis? (specify)",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true,
                oldComment: "Other tracer-based imaging - Were other tracer-based imaging used to support an etiological diagnosis? (specify)");

            migrationBuilder.AlterColumn<int>(
                name: "TRACOTHDX",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "6d. Other tracer-based imaging - Were other tracer-based imaging used to support an etiological diagnosis?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Other tracer-based imaging - Were other tracer-based imaging used to support an etiological diagnosis?");

            migrationBuilder.AlterColumn<string>(
                name: "TRACEROTHX",
                table: "tbl_D1bs",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                comment: "6d4a. Other tracer-based imaging - Consistent with other etiology (specify)",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true,
                oldComment: "Other tracer-based imaging - Consistent with other etiology (specify)");

            migrationBuilder.AlterColumn<int>(
                name: "TRACEROTH",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "6d4. Other tracer-based imaging - Consistent with other etiology",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Other tracer-based imaging - Consistent with other etiology");

            migrationBuilder.AlterColumn<int>(
                name: "TRACERLBD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "6d3. Other tracer-based imaging - Consistent with LBD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Other tracer-based imaging - Consistent with LBD");

            migrationBuilder.AlterColumn<int>(
                name: "TRACERFTLD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "6d2. Other tracer-based imaging - Consistent with FTLD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Other tracer-based imaging - Consistent with FTLD");

            migrationBuilder.AlterColumn<int>(
                name: "TRACERAD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "6d1. Other tracer-based imaging - Consistent with AD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Other tracer-based imaging - Consistent with AD");

            migrationBuilder.AlterColumn<int>(
                name: "TAUPET",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "6a2. Elevated tau pathology",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Elevated tau pathology");

            migrationBuilder.AlterColumn<int>(
                name: "STRUCTFTLD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "7a2. Atrophy pattern consistent with FTLD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Atrophy pattern consistent with FTLD");

            migrationBuilder.AlterColumn<int>(
                name: "STRUCTDX",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "7a. Structural Imaging (i.e., MRI or CT) - Was structural imaging data or information used to support an etiological diagnosis?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Structural Imaging (i.e., MRI or CT) - Was structural imaging data or information used to support an etiological diagnosis?");

            migrationBuilder.AlterColumn<int>(
                name: "STRUCTCVD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "7a3. Consistent with cerebrovascular disease (CVD)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Consistent with cerebrovascular disease (CVD)");

            migrationBuilder.AlterColumn<int>(
                name: "STRUCTAD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "7a1. Atrophy pattern consistent with AD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Atrophy pattern consistent with AD");

            migrationBuilder.AlterColumn<int>(
                name: "PSPIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "14b1a. Primary, contributing, or non-contributing - Primary supranuclear palsy (PSP)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Primary, contributing, or non-contributing - Primary supranuclear palsy (PSP)");

            migrationBuilder.AlterColumn<bool>(
                name: "PSP",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "14ba. Primary supranuclear palsy (PSP)",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "Primary supranuclear palsy (PSP)");

            migrationBuilder.AlterColumn<int>(
                name: "PRIONIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "20a. Primary, contributing, or non-contributing - Prion disease (CJD, other)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Primary, contributing, or non-contributing - Prion disease (CJD, other)");

            migrationBuilder.AlterColumn<bool>(
                name: "PRION",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "20. Prion disease (CJD, other)",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "Prion disease (CJD, other)");

            migrationBuilder.AlterColumn<int>(
                name: "PETDX",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "6a. Tracer-based PET - Were tracer-based PET measures used in assessing an etiological diagnosis?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Tracer-based PET - Were tracer-based PET measures used in assessing an etiological diagnosis?");

            migrationBuilder.AlterColumn<string>(
                name: "OTHCOGX",
                table: "tbl_D1bs",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                comment: "23b. Other (specify)",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true,
                oldComment: "Other (specify)");

            migrationBuilder.AlterColumn<int>(
                name: "OTHCOGIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "23a. Primary, contributing, or non-contributing - Other",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Primary, contributing, or non-contributing - Other");

            migrationBuilder.AlterColumn<bool>(
                name: "OTHCOG",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "23. Other",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "Other");

            migrationBuilder.AlterColumn<string>(
                name: "OTHBIOMX3",
                table: "tbl_D1bs",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                comment: "10a1. Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis? (specify)",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true,
                oldComment: "Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis? (specify)");

            migrationBuilder.AlterColumn<string>(
                name: "OTHBIOMX2",
                table: "tbl_D1bs",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                comment: "9a1. Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis? (specify)",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true,
                oldComment: "Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis? (specify)");

            migrationBuilder.AlterColumn<string>(
                name: "OTHBIOMX1",
                table: "tbl_D1bs",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                comment: "8a1. Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis? (specify)	OTHBI",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true,
                oldComment: "Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis? (specify)	OTHBI");

            migrationBuilder.AlterColumn<int>(
                name: "OTHBIOM3",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "10. Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis?");

            migrationBuilder.AlterColumn<int>(
                name: "OTHBIOM2",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "9. Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis?");

            migrationBuilder.AlterColumn<int>(
                name: "OTHBIOM1",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "8. Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis?");

            migrationBuilder.AlterColumn<int>(
                name: "MSAIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "16a. Primary, contributing, or non-contributing - Multiple system atrophy",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Primary, contributing, or non-contributing - Multiple system atrophy");

            migrationBuilder.AlterColumn<bool>(
                name: "MSA",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "16. Multiple system atrophy",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "Multiple system atrophy");

            migrationBuilder.AlterColumn<bool>(
                name: "LBDIS",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "13. Lewy body disease",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "Lewy body disease");

            migrationBuilder.AlterColumn<int>(
                name: "LBDIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "13a. Primary, contributing, or non-contributing - Lewy body disease",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Primary, contributing, or non-contributing - Lewy body disease");

            migrationBuilder.AlterColumn<int>(
                name: "LATEIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "22a. Primary, contributing, or non-contributing - LATE",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Primary, contributing, or non-contributing - LATE");

            migrationBuilder.AlterColumn<bool>(
                name: "LATE",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "22. LATE: Limbic-predominant age-related TDP-43 encephalopathy",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "LATE: Limbic-predominant age-related TDP-43 encephalopathy");

            migrationBuilder.AlterColumn<int>(
                name: "IMAGMICH",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "7a3d. Microhemorrhage(s)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "icrohemorrhage(s)");

            migrationBuilder.AlterColumn<int>(
                name: "IMAGMACH",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "7a3c. Macrohemorrhage(s)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Macrohemorrhage(s)");

            migrationBuilder.AlterColumn<int>(
                name: "IMAGLINF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "7a3a. Large vessel infarct(s)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Large vessel infarct(s)");

            migrationBuilder.AlterColumn<int>(
                name: "IMAGLAC",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "7a3b. Lacunar infarct(s)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Lacunar infarct(s)");

            migrationBuilder.AlterColumn<int>(
                name: "IMAGINGDX",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "5. Imaging - Was imaging used for assessing etiological diagnosis?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Imaging - Was imaging used for assessing etiological diagnosis?");

            migrationBuilder.AlterColumn<int>(
                name: "HUNTIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "19a. Primary, contributing, or non-contributing - Huntington's disease",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Primary, contributing, or non-contributing - Huntington's disease");

            migrationBuilder.AlterColumn<bool>(
                name: "HUNT",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "19. Huntington's disease",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "Huntington's disease");

            migrationBuilder.AlterColumn<string>(
                name: "FTLDSUBX",
                table: "tbl_D1bs",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                comment: "14c1. Other FTLD subtype (specify)",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true,
                oldComment: "Other FTLD subtype (specify)");

            migrationBuilder.AlterColumn<int>(
                name: "FTLDSUBT",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "14c. FTLD subtype",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "FTLD subtype");

            migrationBuilder.AlterColumn<bool>(
                name: "FTLDNOS",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "14b4. FTLD not otherwise specified (NOS)",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "FTLD not otherwise specified (NOS)");

            migrationBuilder.AlterColumn<int>(
                name: "FTLDNOIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "14b4a. Primary, contributing, or non-contributing - FTLD not otherwise specified (NOS)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Primary, contributing, or non-contributing - FTLD not otherwise specified (NOS)");

            migrationBuilder.AlterColumn<int>(
                name: "FTLDMOIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "14b3a. Primary, contributing, or non-contributing - FTLD with motor neuron disease",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Primary, contributing, or non-contributing - FTLD with motor neuron disease");

            migrationBuilder.AlterColumn<bool>(
                name: "FTLDMO",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "14b3. FTLD with motor neuron disease",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "FTLD with motor neuron disease");

            migrationBuilder.AlterColumn<bool>(
                name: "FTLD",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "14. Frontotemporal lobar degeneration",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "Frontotemporal lobar degeneration");

            migrationBuilder.AlterColumn<int>(
                name: "FLUIDBIOM",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "2. Fluid Biomarkers - Were fluid biomarkers used for assessing the etiological diagnosis?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Fluid Biomarkers - Were fluid biomarkers used for assessing the etiological diagnosis?");

            migrationBuilder.AlterColumn<int>(
                name: "FDGPETDX",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "6b. FDG PET - Was FDG PET data or information used to support an etiological diagnosis?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "FDG PET - Was FDG PET data or information used to support an etiological diagnosis?");

            migrationBuilder.AlterColumn<string>(
                name: "FDGOTHX",
                table: "tbl_D1bs",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                comment: "6b4a. FDG PET - Consistent with other etiology (specify)",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true,
                oldComment: "FDG PET - Consistent with other etiology (specify)");

            migrationBuilder.AlterColumn<int>(
                name: "FDGOTH",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "6b4. FDG PET - Consistent with other etiology",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "FDG PET - Consistent with other etiology");

            migrationBuilder.AlterColumn<int>(
                name: "FDGLBD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "6b3. FDG PET - Consistent with LBD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "FDG PET - Consistent with LBD");

            migrationBuilder.AlterColumn<int>(
                name: "FDGFTLD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "6b2. FDG PET - Consistent with FTLD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "FDG PET - Consistent with FTLD");

            migrationBuilder.AlterColumn<int>(
                name: "FDGAD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "6b1. FDG PET - Consistent with AD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "FDG PET - Consistent with AD");

            migrationBuilder.AlterColumn<int>(
                name: "DOWNSIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "18a. Primary, contributing, or non-contributing - Down syndrome",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Primary, contributing, or non-contributing - Down syndrome");

            migrationBuilder.AlterColumn<bool>(
                name: "DOWNS",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "18. Down syndrome",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "Down syndrome");

            migrationBuilder.AlterColumn<int>(
                name: "DATSCANDX",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "6c. Dopamine Transporter (DAT) Scan - Was DAT Scan data or information used to support an etiological diagnosis?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Dopamine Transporter (DAT) Scan - Was DAT Scan data or information used to support an etiological diagnosis?");

            migrationBuilder.AlterColumn<int>(
                name: "CVDIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "15a. Primary, contributing, or non-contributing - Vascular brain injury",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Primary, contributing, or non-contributing - Vascular brain injury");

            migrationBuilder.AlterColumn<bool>(
                name: "CVD",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "15. Vascular brain injury (based on clinical and imaging evidence according to your Center's standards)",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "Vascular brain injury (based on clinical and imaging evidence according to your Center's standards)");

            migrationBuilder.AlterColumn<int>(
                name: "CTEIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "17a. Primary, contributing, or non-contributing - Chronic traumatic encephalopathy",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Primary, contributing, or non-contributing - Chronic traumatic encephalopathy");

            migrationBuilder.AlterColumn<bool>(
                name: "CTE",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "17. Chronic traumatic encephalopathy",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "Chronic traumatic encephalopathy");

            migrationBuilder.AlterColumn<string>(
                name: "CSFOTHX",
                table: "tbl_D1bs",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                comment: "4d1. CSF-based biomarkers - Consistent with other etiology (specify)",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true,
                oldComment: "CSF-based biomarkers - Consistent with other etiology (specify)");

            migrationBuilder.AlterColumn<int>(
                name: "CSFOTH",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "4d. CSF-based biomarkers - Consistent with other etiology",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "CSF-based biomarkers - Consistent with other etiology");

            migrationBuilder.AlterColumn<int>(
                name: "CSFLBD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "4c. CSF-based biomarkers - Consistent with LBD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "CSF-based biomarkers - Consistent with LBD");

            migrationBuilder.AlterColumn<int>(
                name: "CSFFTLD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "4b. CSF-based biomarkers - Consistent with FTLD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "CSF-based biomarkers - Consistent with FTLD");

            migrationBuilder.AlterColumn<int>(
                name: "CSFAD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "4a. CSF-based biomarkers - Consistent with AD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "CSF-based biomarkers - Consistent with AD");

            migrationBuilder.AlterColumn<int>(
                name: "CORTIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "14b2a. Primary, contributing, or non-contributing - Corticobasal degeneration (CBD)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Primary, contributing, or non-contributing - Corticobasal degeneration (CBD)");

            migrationBuilder.AlterColumn<bool>(
                name: "CORT",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "14b2. Corticobasal degeneration (CBD)",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "Corticobasal degeneration (CBD)");

            migrationBuilder.AlterColumn<int>(
                name: "CAAIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "21a. Primary, contributing, or non-contributing - Cerebral amyloid angiopathy",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Primary, contributing, or non-contributing - Cerebral amyloid angiopathy");

            migrationBuilder.AlterColumn<bool>(
                name: "CAA",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "21. Cerebral amyloid angiopathy",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "Cerebral amyloid angiopathy");

            migrationBuilder.AlterColumn<string>(
                name: "BLOODOTHX",
                table: "tbl_D1bs",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                comment: "3d1. Blood-based biomarkers - Consistent with other etiology (specify)",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true,
                oldComment: "Blood-based biomarkers - Consistent with other etiology (specify)");

            migrationBuilder.AlterColumn<int>(
                name: "BLOODOTH",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "3d. Blood-based biomarkers - Consistent with other etiology",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Blood-based biomarkers - Consistent with other etiology");

            migrationBuilder.AlterColumn<int>(
                name: "BLOODLBD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "3c. Blood-based biomarkers - Consistent with LBD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Blood-based biomarkers - Consistent with LBD");

            migrationBuilder.AlterColumn<int>(
                name: "BLOODFTLD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "3b. Blood-based biomarkers - Consistent with FTLD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Blood-based biomarkers - Consistent with FTLD");

            migrationBuilder.AlterColumn<int>(
                name: "BLOODAD",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "3a. Blood-based biomarkers - Consistent with AD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Blood-based biomarkers - Consistent with AD");

            migrationBuilder.AlterColumn<string>(
                name: "BIOMOTHX3",
                table: "tbl_D1bs",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                comment: "10d1. Other biomarker modality - Consistent with other etiology (specify)",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true,
                oldComment: "Other biomarker modality - Consistent with other etiology (specify)");

            migrationBuilder.AlterColumn<string>(
                name: "BIOMOTHX2",
                table: "tbl_D1bs",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                comment: "9d1. Other biomarker modality - Consistent with other etiology (specify)",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true,
                oldComment: "Other biomarker modality - Consistent with other etiology (specify)");

            migrationBuilder.AlterColumn<string>(
                name: "BIOMOTHX1",
                table: "tbl_D1bs",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                comment: "8d1. Other biomarker modality - Consistent with other etiology (specify)",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true,
                oldComment: "Other biomarker modality - Consistent with other etiology (specify)");

            migrationBuilder.AlterColumn<int>(
                name: "BIOMOTH3",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "10d. Other biomarker modality - Consistent with other etiology",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Other biomarker modality - Consistent with other etiology");

            migrationBuilder.AlterColumn<int>(
                name: "BIOMOTH2",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "9d. Other biomarker modality - Consistent with other etiology",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Other biomarker modality - Consistent with other etiology");

            migrationBuilder.AlterColumn<int>(
                name: "BIOMOTH1",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "8d. Other biomarker modality - Consistent with other etiology",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Other biomarker modality - Consistent with other etiology");

            migrationBuilder.AlterColumn<int>(
                name: "BIOMLBD3",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "10c. Other biomarker modality - Consistent with LBD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Other biomarker modality - Consistent with LBD");

            migrationBuilder.AlterColumn<int>(
                name: "BIOMLBD2",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "9c. Other biomarker modality - Consistent with LBD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Other biomarker modality - Consistent with LBD");

            migrationBuilder.AlterColumn<int>(
                name: "BIOMLBD1",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "8c. Other biomarker modality - Consistent with LBD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Other biomarker modality - Consistent with LBD");

            migrationBuilder.AlterColumn<int>(
                name: "BIOMFTLD3",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "10b. Other biomarker modality - Consistent with FTLD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Other biomarker modality - Consistent with FTLD");

            migrationBuilder.AlterColumn<int>(
                name: "BIOMFTLD2",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "9b. Other biomarker modality - Consistent with FTLD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Other biomarker modality - Consistent with FTLD");

            migrationBuilder.AlterColumn<int>(
                name: "BIOMARKDX",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "1. Were any biomarker results used to support the current etiological diagnosis?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Were any biomarker results used to support the current etiological diagnosis?");

            migrationBuilder.AlterColumn<int>(
                name: "BIOMAD3",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "10a. Other biomarker modality - Consistent with AD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Other biomarker modality - Consistent with AD");

            migrationBuilder.AlterColumn<int>(
                name: "BIOMAD2",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "9a. Other biomarker modality - Consistent with AD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Other biomarker modality - Consistent with AD");

            migrationBuilder.AlterColumn<int>(
                name: "BIOMAD1",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "8a. Other biomarker modality - Consistent with AD",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Other biomarker modality - Consistent with AD");

            migrationBuilder.AlterColumn<int>(
                name: "AUTDOMMUT",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "11. Is there an autosomal dominant pathogenic variant to support an etiological diagnosis?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Is there an autosomal dominant pathogenic variant to support an etiological diagnosis?");

            migrationBuilder.AlterColumn<int>(
                name: "AMYLPET",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "6a1. Elevated amyloid",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Elevated amyloid");

            migrationBuilder.AlterColumn<int>(
                name: "ALZDISIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "12a. Primary, contributing, or non-contributing - Alzheimer's disease",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Primary, contributing, or non-contributing - Alzheimer's disease");

            migrationBuilder.AlterColumn<bool>(
                name: "ALZDIS",
                table: "tbl_D1bs",
                type: "bit",
                nullable: true,
                comment: "12. Alzheimer's disease",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "Alzheimer's disease");

            migrationBuilder.AddColumn<int>(
                name: "FTLDIF",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "14a. Primary, contributing, or non-contributing - Frontotemporal lobar degeneration");

            migrationBuilder.AddColumn<int>(
                name: "IMAGEWMH",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "7a3f. Extensive white-matter hyperintensity (CHS score 7-8+)");

            migrationBuilder.AddColumn<int>(
                name: "IMAGMWMH",
                table: "tbl_D1bs",
                type: "int",
                nullable: true,
                comment: "7a3e. Moderate white-matter hyperintensity (CHS score 5-6)");

            migrationBuilder.AddColumn<int>(
                name: "AFFFAMM",
                table: "tbl_A3s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NWINFKID",
                table: "tbl_A3s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NWINFMUT",
                table: "tbl_A3s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NWINFSIB",
                table: "tbl_A3s",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NEWINF",
                table: "tbl_A2s",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TRSPMED",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "6. In the past 30 days, how often has a lack of transportation kept you from medical appointments or from doing things needed for daily living?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "In the past 30 days, how often has a lack of transportation kept you from medical appointments or from doing things needed for daily living?");

            migrationBuilder.AlterColumn<int>(
                name: "TRSPACCESS",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "2. Do you have consistent access to transportation?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Do you have consistent access to transportation?");

            migrationBuilder.AlterColumn<int>(
                name: "TRANSWORRY",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "4. In the past 30 days, how often did you worry about whether or not you would be able to get somewhere because of a problem with transportation?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "In the past 30 days, how often did you worry about whether or not you would be able to get somewhere because of a problem with transportation?");

            migrationBuilder.AlterColumn<int>(
                name: "TRANSPROB",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "3. In the past 30 days, how often were you not able to leave the house when you wanted to because of a problem with transportation?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "In the past 30 days, how often were you not able to leave the house when you wanted to because of a problem with transportation?");

            migrationBuilder.AlterColumn<int>(
                name: "THREATENED",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "37. In your day-to-day life how often are you threatened or harassed?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "In your day-to-day life how often are you threatened or harassed?");

            migrationBuilder.AlterColumn<int>(
                name: "SCRIPTPROB",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "29. In the past year, how often did you experience challenges in filling a prescription?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "In the past year, how often did you experience challenges in filling a prescription?");

            migrationBuilder.AlterColumn<int>(
                name: "SAFEHOME",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "27a. How safe do you feel in your home?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "How safe do you feel in your home?");

            migrationBuilder.AlterColumn<int>(
                name: "SAFECOMM",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "27b. How safe do you feel in your community (or neighborhood)?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "How safe do you feel in your community (or neighborhood)?");

            migrationBuilder.AlterColumn<int>(
                name: "POORSERV",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "34. In your day-to-day life how often do you receive poorer service than other people at restaurants or stores?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "In your day-to-day life how often do you receive poorer service than other people at restaurants or stores?");

            migrationBuilder.AlterColumn<int>(
                name: "POORMEDTRT",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "38. How frequently did you receive poorer service or treatment from doctors or in hospitals compared to other people?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "How frequently did you receive poorer service or treatment from doctors or in hospitals compared to other people?");

            migrationBuilder.AlterColumn<int>(
                name: "PARTICIPATE",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "26. How often do you participate in activities outside the home (e.g., religious activities, educational activities, volunteer work, paid work, or activities with groups or organizations)?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "How often do you participate in activities outside the home (e.g., religious activities, educational activities, volunteer work, paid work, or activities with groups or organizations)?");

            migrationBuilder.AlterColumn<int>(
                name: "PARENTCOMM",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "23. If your parents are still alive, how often do you have contact with them (including mother, father, mother-in-law, and father-in-law) either in person, by phone, mail, or email (e.g., any online interaction)?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "If your parents are still alive, how often do you have contact with them (including mother, father, mother-in-law, and father-in-law) either in person, by phone, mail, or email (e.g., any online interaction)?");

            migrationBuilder.AlterColumn<int>(
                name: "OWNSCAR",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "1. Do you or someone in your household currently own a car?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Do you or someone in your household currently own a car?");

            migrationBuilder.AlterColumn<int>(
                name: "NOTSMART",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "35. In your day-to-day life how often do people act as if they think you are not smart?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "In your day-to-day life how often do people act as if they think you are not smart?");

            migrationBuilder.AlterColumn<int>(
                name: "MISSPEOPLE",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "19. I miss having people around",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "I miss having people around");

            migrationBuilder.AlterColumn<int>(
                name: "MISSEDFUP",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "30. In the past year, how often did you miss a follow-up medical appointment that was scheduled?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "In the past year, how often did you miss a follow-up medical appointment that was scheduled?");

            migrationBuilder.AlterColumn<int>(
                name: "LESSMEDSYR",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "14. In the last 12 months, have you ended up taking less medication than was prescribed for you because of the cost?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "In the last 12 months, have you ended up taking less medication than was prescribed for you because of the cost?");

            migrationBuilder.AlterColumn<int>(
                name: "LESSMEDS",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "13. At any time, have you ended up taking less medication than was prescribed for you because of the cost?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "At any time, have you ended up taking less medication than was prescribed for you because of the cost?");

            migrationBuilder.AlterColumn<int>(
                name: "LESSCOURT",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "33. In your day-to-day life how often are you treated with less courtesy or respect than other people?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "In your day-to-day life how often are you treated with less courtesy or respect than other people?");

            migrationBuilder.AlterColumn<int>(
                name: "INCOMEYR",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "7. Which of these income groups represents your household income for the past year? Include income from all sources such as wages, salaries, social security or retirement benefits, help from relatives, rent from property, and so forth.",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Which of these income groups represents your household income for the past year? Include income from all sources such as wages, salaries, social security or retirement benefits, help from relatives, rent from property, and so forth.");

            migrationBuilder.AlterColumn<int>(
                name: "HEALTHACC",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "32. Overall, which of these describes your health insurance, access to healthcare services, and access to medications?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Overall, which of these describes your health insurance, access to healthcare services, and access to medications?");

            migrationBuilder.AlterColumn<int>(
                name: "GUARDEDU",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "16. Thinking of the person who raised you, what was their highest level of education completed?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Thinking of the person who raised you, what was their highest level of education completed?");

            migrationBuilder.AlterColumn<int>(
                name: "FRIENDS",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "20. I feel like I don't have enough friends",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "I feel like I don't have enough friends");

            migrationBuilder.AlterColumn<int>(
                name: "FRIENDCOMM",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "25. How often do you have contact with close friends either in person, by phone, mail, or email (e.g., any online interaction)?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "How often do you have contact with close friends either in person, by phone, mail, or email (e.g., any online interaction)?");

            migrationBuilder.AlterColumn<int>(
                name: "FINUPSET",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "10. If you have had financial problems that lasted twelve months or longer, how upsetting has it been to you?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "If you have had financial problems that lasted twelve months or longer, how upsetting has it been to you?");

            migrationBuilder.AlterColumn<int>(
                name: "FINSATIS",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "8. How satisfied are you with your current personal financial condition?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "How satisfied are you with your current personal financial condition?");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPWEIGHT",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "39a7. Main reason--Your weight",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "Main reason--Your weight");

            migrationBuilder.AlterColumn<int>(
                name: "EXPSTRS",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "40. When you have had day-to-day experiences like those in questions 33 to 38, would you say they have been very stressful, moderately stressful, or not stressful?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "When you have had day-to-day experiences like those in questions 33 to 38, would you say they have been very stressful, moderately stressful, or not stressful?");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPSKIN",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "39a12. Main reason--Your shade of skin color",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "Main reason--Your shade of skin color");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPSEXORN",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "39a9. Main reason--Your sexual orientation",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "Main reason--Your sexual orientation");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPRELIG",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "39a5. Main reason--Your religion",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "Main reason--Your religion");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPRACE",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "39a3. Main reason--Your race",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "Main reason--Your race");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPOTHER",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "39a13. Main reason -- Other",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "Main reason -- Other");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPNOTAPP",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "39a14. Main reason -- not applicable - I do not have these experiences in my day to day life",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "Main reason -- not applicable - I do not have these experiences in my day to day life");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPNOANS",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "39a15. Main reason--Prefer not to answer",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "Main reason--Prefer not to answer");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPHEIGHT",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "39a6. Main reason--Your height",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "Main reason--Your height");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPGENDER",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "39a2. Main reason--Your gender",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "Main reason--Your gender");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPEDUCINC",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "39a10. Main reason--Your education or income level",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "Main reason--Your education or income level");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPDISAB",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "39a11. Main reason--A physical disability",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "Main reason--A physical disability");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPAPPEAR",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "39a8. Main reason--Some other aspect of your physical appearance",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "Main reason--Some other aspect of your physical appearance");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPANCEST",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "39a1. Main reason--Your Ancestry or National Origins",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "Main reason--Your Ancestry or National Origins");

            migrationBuilder.AlterColumn<bool>(
                name: "EXPAGE",
                table: "tbl_A1as",
                type: "bit",
                nullable: true,
                comment: "39a4. Main reason--Your age",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldComment: "Main reason--Your age");

            migrationBuilder.AlterColumn<int>(
                name: "EMPTINESS",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "18. I experience a general sense of emptiness",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "I experience a general sense of emptiness");

            migrationBuilder.AlterColumn<int>(
                name: "EATLESSYR",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "12. In the last 12 months, did you ever eat less than you felt you should because there wasn't enough money to buy food?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "In the last 12 months, did you ever eat less than you felt you should because there wasn't enough money to buy food?");

            migrationBuilder.AlterColumn<int>(
                name: "EATLESS",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "11. At any time, did you ever eat less than you felt you should because there wasn't enough money to buy food?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "At any time, did you ever eat less than you felt you should because there wasn't enough money to buy food?");

            migrationBuilder.AlterColumn<int>(
                name: "DOCADVICE",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "31. In the past year, how often did you follow a doctor's advice or treatment plan when it was given?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "In the past year, how often did you follow a doctor's advice or treatment plan when it was given?");

            migrationBuilder.AlterColumn<int>(
                name: "DELAYMED",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "28. In the past year, how often did you delay seeking medical attention for a problem that was bothering you?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "In the past year, how often did you delay seeking medical attention for a problem that was bothering you?");

            migrationBuilder.AlterColumn<int>(
                name: "COMPCOMM",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "15a. Where would you place yourself on this ladder compared to others in your community (or neighborhood)? Please mark the number where you would place yourself.",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Where would you place yourself on this ladder compared to others in your community (or neighborhood)? Please mark the number where you would place yourself.");

            migrationBuilder.AlterColumn<int>(
                name: "CLOSEFRND",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "22. I miss having a really good friend",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "I miss having a really good friend");

            migrationBuilder.AlterColumn<int>(
                name: "CHILDCOMM",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "24. If you have children, how often do you have contact with your children (including child[ren]-in-law and stepchild[ren]) either in person, by phone, mail, or email (e.g., any online interaction)?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "If you have children, how often do you have contact with your children (including child[ren]-in-law and stepchild[ren]) either in person, by phone, mail, or email (e.g., any online interaction)?");

            migrationBuilder.AlterColumn<int>(
                name: "BILLPAY",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "9. How difficult is it for you to meet monthly payments on your bills?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "How difficult is it for you to meet monthly payments on your bills?");

            migrationBuilder.AlterColumn<int>(
                name: "ACTAFRAID",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "36. In your day-to-day life how often do people act as if they are afraid of you?",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "In your day-to-day life how often do people act as if they are afraid of you?");

            migrationBuilder.AlterColumn<int>(
                name: "ABANDONED",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "21. I often feel abandoned",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "I often feel abandoned");

            migrationBuilder.AddColumn<int>(
                name: "COMPUSA",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "15b. Where would you place yourself on this ladder compared to others in the U.S.?");

            migrationBuilder.AddColumn<int>(
                name: "FAMCOMP",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "15c. Thinking of your childhood, where would your family have been placed on this ladder compared to others in your community (or neighborhood)?");

            migrationBuilder.AddColumn<int>(
                name: "GUARD2EDU",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "17. If there was a second person who raised you (e.g., your mother, father, grandmother, etc.?), what was that person's highest level of education completed?");

            migrationBuilder.AddColumn<int>(
                name: "GUARD2REL",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "17a. What was this second person's relationship to you (if applicable)?");

            migrationBuilder.AddColumn<string>(
                name: "GUARD2RELX",
                table: "tbl_A1as",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                comment: "17a1. Specify other relationship");

            migrationBuilder.AddColumn<int>(
                name: "GUARDREL",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "16a. What was this person's relationship to you?");

            migrationBuilder.AddColumn<string>(
                name: "GUARDRELX",
                table: "tbl_A1as",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                comment: "16a1. Specify other relationship");

            migrationBuilder.AddColumn<int>(
                name: "TRSPLONGER",
                table: "tbl_A1as",
                type: "int",
                nullable: true,
                comment: "5. In the past 30 days, how often did it take you longer to get somewhere than it would have taken you if you had different transportation?");
        }
    }
}
