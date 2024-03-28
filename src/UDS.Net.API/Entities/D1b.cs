using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace UDS.Net.API.Entities
{
    [Table("tbl_D1bs")]
    public class D1b : Form
    {
        [Comment("1. Were any biomarker results used to support the current etiological diagnosis?")]
        public int? BIOMARKDX { get; set; }
        [Comment("2. Fluid Biomarkers - Were fluid biomarkers used for assessing the etiological diagnosis?")]
        public int? FLUIDBIOM { get; set; }
        [Comment("3a. Blood-based biomarkers - Consistent with AD")]
        public int? BLOODAD { get; set; }
        [Comment("3b. Blood-based biomarkers - Consistent with FTLD")]
        public int? BLOODFTLD { get; set; }
        [Comment("3c. Blood-based biomarkers - Consistent with LBD")]
        public int? BLOODLBD { get; set; }
        [Comment("3d. Blood-based biomarkers - Consistent with other etiology")]
        public int? BLOODOTH { get; set; }
        [Comment("3d1. Blood-based biomarkers - Consistent with other etiology (specify)")]
        public string? BLOODOTHX { get; set; }
        [Comment("4a. CSF-based biomarkers - Consistent with AD")]
        public int? CSFAD { get; set; }
        [Comment("4b. CSF-based biomarkers - Consistent with FTLD")]
        public int? CSFFTLD { get; set; }
        [Comment("4c. CSF-based biomarkers - Consistent with LBD")]
        public int? CSFLBD { get; set; }
        [Comment("4d. CSF-based biomarkers - Consistent with other etiology")]
        public int? CSFOTH { get; set; }
        [Comment("4d1. CSF-based biomarkers - Consistent with other etiology (specify)")]
        public string? CSFOTHX { get; set; }
        [Comment("5. Imaging - Was imaging used for assessing etiological diagnosis?")]
        public int? IMAGINGDX { get; set; }
        [Comment("6a. Tracer-based PET - Were tracer-based PET measures used in assessing an etiological diagnosis?")]
        public int? PETDX { get; set; }
        [Comment("6a1. Elevated amyloid")]
        public int? AMYLPET { get; set; }
        [Comment("6a2. Elevated tau pathology")]
        public int? TAUPET { get; set; }
        [Comment("6b. FDG PET - Was FDG PET data or information used to support an etiological diagnosis?")]
        public int? FDGPETDX { get; set; }
        [Comment("6b1. FDG PET - Consistent with AD")]
        public int? FDGAD { get; set; }
        [Comment("6b2. FDG PET - Consistent with FTLD")]
        public int? FDGFTLD { get; set; }
        [Comment("6b3. FDG PET - Consistent with LBD")]
        public int? FDGLBD { get; set; }
        [Comment("6b4. FDG PET - Consistent with other etiology")]
        public int? FDGOTH { get; set; }
        [Comment("6b4a. FDG PET - Consistent with other etiology (specify)")]
        public string? FDGOTHX { get; set; }
        [Comment("6c. Dopamine Transporter (DAT) Scan - Was DAT Scan data or information used to support an etiological diagnosis?")]
        public int? DATSCANDX { get; set; }
        [Comment("6d. Other tracer-based imaging - Were other tracer-based imaging used to support an etiological diagnosis?")]
        public int? TRACOTHDX { get; set; }
        [Comment("6d1a. Other tracer-based imaging - Were other tracer-based imaging used to support an etiological diagnosis? (specify)")]
        public string? TRACOTHDXX { get; set; }
        [Comment("6d1. Other tracer-based imaging - Consistent with AD")]
        public int? TRACERAD { get; set; }
        [Comment("6d2. Other tracer-based imaging - Consistent with FTLD")]
        public int? TRACERFTLD { get; set; }
        [Comment("6d3. Other tracer-based imaging - Consistent with LBD")]
        public int? TRACERLBD { get; set; }
        [Comment("6d4. Other tracer-based imaging - Consistent with other etiology")]
        public int? TRACEROTH { get; set; }
        [Comment("6d4a. Other tracer-based imaging - Consistent with other etiology (specify)")]
        public string? TRACEROTHX { get; set; }
        [Comment("7a. Structural Imaging (i.e., MRI or CT) - Was structural imaging data or information used to support an etiological diagnosis?")]
        public int? STRUCTDX { get; set; }
        [Comment("7a1. Atrophy pattern conistent with AD")]
        public int? STRUCTAD { get; set; }
        [Comment("7a2. Atrophy pattern consistent with FTLD")]
        public int? STRUCTFTLD { get; set; }
        [Comment("7a3. Consistent with cerebrovascular disease (CVD)")]
        public int? STRUCTCVD { get; set; }
        [Comment("7a3a. Large vessel infarct(s)")]
        public int? IMAGLINF { get; set; }
        [Comment("7a3b. Lacunar infarct(s)")]
        public int? IMAGLAC { get; set; }
        [Comment("7a3c. Macrohemorrhage(s)")]
        public int? IMAGMACH { get; set; }
        [Comment("7a3d. Microhemorrhage(s)")]
        public int? IMAGMICH { get; set; }
        [Comment("7a3e. Moderate white-matter hyperintensity (CHS score 5-6)")]
        public int? IMAGMWMH { get; set; }
        [Comment("7a3f. Extensive white-matter hyperinensity (CHS score 7-8+)")]
        public int? IMAGEWMH { get; set; }
        [Comment("8. Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis?")]
        public int? OTHBIOM1 { get; set; }
        [Comment("8a1. Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis? (specify)\tOTHBI")]
        public string? OTHBIOMX1 { get; set; }
        [Comment("8a. Other biomarker modality - Consistent with AD")]
        public int? BIOMAD1 { get; set; }
        [Comment("8b. Other biomarker modality - Consistent with FTLD")]
        public int? BIOMFTLD1 { get; set; }
        [Comment("8c. Other biomarker modality - Consistent with LBD")]
        public int? BIOMLBD1 { get; set; }
        [Comment("8d. Other biomarker modality - Consistent with other etiology")]
        public int? BIOMOTH1 { get; set; }
        [Comment("8d1. Other biomarker modality - Consistent with other etiology (specify)")]
        public string? BIOMOTHX1 { get; set; }
        [Comment("9. Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis?")]
        public int? OTHBIOM2 { get; set; }
        [Comment("9a1. Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis? (specify)")]
        public string? OTHBIOMX2 { get; set; }
        [Comment("9a. Other biomarker modality - Consistent with AD")]
        public int? BIOMAD2 { get; set; }
        [Comment("9b. Other biomarker modality - Consistent with FTLD")]
        public int? BIOMFTLD2 { get; set; }
        [Comment("9c. Other biomarker modality - Consistent with LBD")]
        public int? BIOMLBD2 { get; set; }
        [Comment("9d. Other biomarker modality - Consistent with other etiology")]
        public int? BIOMOTH2 { get; set; }
        [Comment("9d1. Other biomarker modality - Consistent with other etiology (specify)")]
        public string? BIOMOTHX2 { get; set; }
        [Comment("10. Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis?")]
        public int? OTHBIOM3 { get; set; }
        [Comment("10a1. Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis? (specify)")]
        public string? OTHBIOMX3 { get; set; }
        [Comment("10a. Other biomarker modality - Consistent with AD")]
        public int? BIOMAD3 { get; set; }
        [Comment("10b. Other biomarker modality - Consistent with FTLD")]
        public int? BIOMFTLD3 { get; set; }
        [Comment("10c. Other biomarker modality - Consistent with LBD")]
        public int? BIOMLBD3 { get; set; }
        [Comment("10d. Other biomarker modality - Consistent with other etiology")]
        public int? BIOMOTH3 { get; set; }
        [Comment("10d1. Other biomarker modality - Consistent with other etiology (specify)")]
        public string? BIOMOTHX3 { get; set; }
        [Comment("11. Is there an autosomal dominant pathogenic variant to support an etiological diagnosis?")]
        public int? AUTDOMMUT { get; set; }
        [Comment("12. Alzheimer's disease")]
        public bool? ALZDIS { get; set; }
        [Comment("12a. Primary, contributing, or non-contributing - Alzheimer's disease")]
        public int? ALZDISIF { get; set; }
        [Comment("13. Lewy body disease")]
        public bool? LBDIS { get; set; }
        [Comment("13a. Primary, contributing, or non-contributing - Lewy body disease")]
        public int? LBDIF { get; set; }
        [Comment("14. Frontotemporal lobar degeneration")]
        public bool? FTLD { get; set; }
        [Comment("14a. Primary, contributing, or non-contributing - Frontotemporal lobar degeneration")]
        public int? FTLDIF { get; set; }
        [Comment("14ba. Primary supranuclear palsy (PSP)")]
        public bool? PSP { get; set; }
        [Comment("14b1a. Primary, contributing, or non-contributing - Primary supranuclear palsy (PSP)")]
        public int? PSPIF { get; set; }
        [Comment("14b2. Corticobasal degeneration (CBD)")]
        public bool? CORT { get; set; }
        [Comment("14b2a. Primary, contributing, or non-contributing - Corticobasal degeneration (CBD)")]
        public int? CORTIF { get; set; }
        [Comment("14b3. FTLD with motor neuron disease")]
        public bool? FTLDMO { get; set; }
        [Comment("14b3a. Primary, contributing, or non-contributing - FTLD with motor neuron disease")]
        public int? FTLDMOIF { get; set; }
        [Comment("14b4. FTLD not otherwise specified (NOS)")]
        public bool? FTLDNOS { get; set; }
        [Comment("14b4a. Primary, contributing, or non-contributing - FTLD not otherwise specified (NOS)")]
        public int? FTLDNOIF { get; set; }
        [Comment("14c. FTLD subtype")]
        public int? FTLDSUBT { get; set; }
        [Comment("14c1. Other FTLD subtype (specify)")]
        public string? FTLDSUBX { get; set; }
        [Comment("15. Vascular brain injury (based on clinical and imaging evidence according to your Center's standards)")]
        public bool? CVD { get; set; }
        [Comment("15a. Primary, contributing, or non-contributing - Vascular brain injury")]
        public int? CVDIF { get; set; }
        [Comment("16. Multiple system atrophy")]
        public bool? MSA { get; set; }
        [Comment("16a. Primary, contributing, or non-contributing - Multiple system atrophy")]
        public int? MSAIF { get; set; }
        [Comment("17. Chronic traumatic encephalopathy")]
        public bool? CTE { get; set; }
        [Comment("17a. Primary, contributing, or non-contributing - Chronic traumatic encephalopathy")]
        public int? CTEIF { get; set; }
        [Comment("18. Down syndrome")]
        public bool? DOWNS { get; set; }
        [Comment("18a. Primary, contributing, or non-contributing - Down syndrome")]
        public int? DOWNSIF { get; set; }
        [Comment("19. Huntington's disease")]
        public bool? HUNT { get; set; }
        [Comment("19a. Primary, contributing, or non-contributing - Huntington's disease")]
        public int? HUNTIF { get; set; }
        [Comment("20. Prion disease (CJD, other)")]
        public bool? PRION { get; set; }
        [Comment("20a. Primary, contributing, or non-contributing - Prion disease (CJD, other)")]
        public int? PRIONIF { get; set; }
        [Comment("21. Cerebral amyloid angiopathy")]
        public bool? CAA { get; set; }
        [Comment("21a. Primary, contributing, or non-contributing - Cerebral amyloid angiopathy")]
        public int? CAAIF { get; set; }
        [Comment("22. LATE: Limbic-predominant age-related TDP-43 encephalopathy")]
        public bool? LATE { get; set; }
        [Comment("22a. Primary, contributing, or non-contributing - LATE")]
        public int? LATEIF { get; set; }
        [Comment("23. Other")]
        public bool? OTHCOG { get; set; }
        [Comment("23a. Primary, contributing, or non-contributing - Other")]
        public int? OTHCOGIF { get; set; }
        [Comment("23b. Other (specify)")]
        public string? OTHCOGX { get; set; }

    }
}
