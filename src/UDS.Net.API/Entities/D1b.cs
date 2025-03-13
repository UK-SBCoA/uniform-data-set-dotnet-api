using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace UDS.Net.API.Entities
{
    [Table("tbl_D1bs")]
    public class D1b : Form
    {
        [Comment("Were any biomarker results used to support the current etiological diagnosis?")]
        public int? BIOMARKDX { get; set; }

        [Comment("Fluid Biomarkers - Were fluid biomarkers used for assessing the etiological diagnosis?")]
        public int? FLUIDBIOM { get; set; }

        [Comment("Blood-based biomarkers - Consistent with AD")]
        public int? BLOODAD { get; set; }

        [Comment("Blood-based biomarkers - Consistent with FTLD")]
        public int? BLOODFTLD { get; set; }

        [Comment("Blood-based biomarkers - Consistent with LBD")]
        public int? BLOODLBD { get; set; }

        [Comment("Blood-based biomarkers - Consistent with other etiology")]
        public int? BLOODOTH { get; set; }

        [Comment("Blood-based biomarkers - Consistent with other etiology (specify)")]
        [MaxLength(60)]
        public string? BLOODOTHX { get; set; }

        [Comment("CSF-based biomarkers - Consistent with AD")]
        public int? CSFAD { get; set; }

        [Comment("CSF-based biomarkers - Consistent with FTLD")]
        public int? CSFFTLD { get; set; }

        [Comment("CSF-based biomarkers - Consistent with LBD")]
        public int? CSFLBD { get; set; }

        [Comment("CSF-based biomarkers - Consistent with other etiology")]
        public int? CSFOTH { get; set; }

        [Comment("CSF-based biomarkers - Consistent with other etiology (specify)")]
        [MaxLength(60)]
        public string? CSFOTHX { get; set; }

        [Comment("Imaging - Was imaging used for assessing etiological diagnosis?")]
        public int? IMAGINGDX { get; set; }

        [Comment("Tracer-based PET - Were tracer-based PET measures used in assessing an etiological diagnosis?")]
        public int? PETDX { get; set; }

        [Comment("Elevated amyloid")]
        public int? AMYLPET { get; set; }

        [Comment("Elevated tau pathology")]
        public int? TAUPET { get; set; }

        [Comment("FDG PET - Was FDG PET data or information used to support an etiological diagnosis?")]
        public int? FDGPETDX { get; set; }

        [Comment("FDG PET - Consistent with AD")]
        public int? FDGAD { get; set; }

        [Comment("FDG PET - Consistent with FTLD")]
        public int? FDGFTLD { get; set; }

        [Comment("FDG PET - Consistent with LBD")]
        public int? FDGLBD { get; set; }

        [Comment("FDG PET - Consistent with other etiology")]
        public int? FDGOTH { get; set; }

        [Comment("FDG PET - Consistent with other etiology (specify)")]
        [MaxLength(60)]
        public string? FDGOTHX { get; set; }

        [Comment("Dopamine Transporter (DAT) Scan - Was DAT Scan data or information used to support an etiological diagnosis?")]
        public int? DATSCANDX { get; set; }

        [Comment("Other tracer-based imaging - Were other tracer-based imaging used to support an etiological diagnosis?")]
        public int? TRACOTHDX { get; set; }

        [Comment("Other tracer-based imaging - Were other tracer-based imaging used to support an etiological diagnosis? (specify)")]
        [MaxLength(60)]
        public string? TRACOTHDXX { get; set; }

        [Comment("Other tracer-based imaging - Consistent with AD")]
        public int? TRACERAD { get; set; }

        [Comment("Other tracer-based imaging - Consistent with FTLD")]
        public int? TRACERFTLD { get; set; }

        [Comment("Other tracer-based imaging - Consistent with LBD")]
        public int? TRACERLBD { get; set; }

        [Comment("Other tracer-based imaging - Consistent with other etiology")]
        public int? TRACEROTH { get; set; }

        [Comment("Other tracer-based imaging - Consistent with other etiology (specify)")]
        [MaxLength(60)]
        public string? TRACEROTHX { get; set; }

        [Comment("Structural Imaging (i.e., MRI or CT) - Was structural imaging data or information used to support an etiological diagnosis?")]
        public int? STRUCTDX { get; set; }

        [Comment("Atrophy pattern consistent with AD")]
        public int? STRUCTAD { get; set; }

        [Comment("Atrophy pattern consistent with FTLD")]
        public int? STRUCTFTLD { get; set; }

        [Comment("Consistent with cerebrovascular disease (CVD)")]
        public int? STRUCTCVD { get; set; }

        [Comment("Large vessel infarct(s)")]
        public int? IMAGLINF { get; set; }

        [Comment("Lacunar infarct(s)")]
        public int? IMAGLAC { get; set; }

        [Comment("Macrohemorrhage(s)")]
        public int? IMAGMACH { get; set; }

        [Comment("icrohemorrhage(s)")]
        public int? IMAGMICH { get; set; }

        [Comment("White-matter hyperintensity")]
        public int? IMAGWMH { get; set; }

        [Comment("White-matter hyperintensity severity")]
        public int? IMAGWMHSEV { get; set; }

        [Comment("Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis?")]
        public int? OTHBIOM1 { get; set; }

        [Comment("Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis? (specify)\tOTHBI")]
        [MaxLength(60)]
        public string? OTHBIOMX1 { get; set; }

        [Comment("Other biomarker modality - Consistent with AD")]
        public int? BIOMAD1 { get; set; }

        [Comment("8b. Other biomarker modality - Consistent with FTLD")]
        public int? BIOMFTLD1 { get; set; }

        [Comment("Other biomarker modality - Consistent with LBD")]
        public int? BIOMLBD1 { get; set; }

        [Comment("Other biomarker modality - Consistent with other etiology")]
        public int? BIOMOTH1 { get; set; }

        [Comment("Other biomarker modality - Consistent with other etiology (specify)")]
        [MaxLength(60)]
        public string? BIOMOTHX1 { get; set; }

        [Comment("Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis?")]
        public int? OTHBIOM2 { get; set; }

        [Comment("Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis? (specify)")]
        [MaxLength(60)]
        public string? OTHBIOMX2 { get; set; }

        [Comment("Other biomarker modality - Consistent with AD")]
        public int? BIOMAD2 { get; set; }

        [Comment("Other biomarker modality - Consistent with FTLD")]
        public int? BIOMFTLD2 { get; set; }

        [Comment("Other biomarker modality - Consistent with LBD")]
        public int? BIOMLBD2 { get; set; }

        [Comment("Other biomarker modality - Consistent with other etiology")]
        public int? BIOMOTH2 { get; set; }

        [Comment("Other biomarker modality - Consistent with other etiology (specify)")]
        [MaxLength(60)]
        public string? BIOMOTHX2 { get; set; }

        [Comment("Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis?")]
        public int? OTHBIOM3 { get; set; }

        [Comment("Other biomarker modality - Was another biomarker modality used to support an etiological diagnosis? (specify)")]
        [MaxLength(60)]
        public string? OTHBIOMX3 { get; set; }

        [Comment("Other biomarker modality - Consistent with AD")]
        public int? BIOMAD3 { get; set; }

        [Comment("Other biomarker modality - Consistent with FTLD")]
        public int? BIOMFTLD3 { get; set; }

        [Comment("Other biomarker modality - Consistent with LBD")]
        public int? BIOMLBD3 { get; set; }

        [Comment("Other biomarker modality - Consistent with other etiology")]
        public int? BIOMOTH3 { get; set; }

        [Comment("Other biomarker modality - Consistent with other etiology (specify)")]
        [MaxLength(60)]
        public string? BIOMOTHX3 { get; set; }

        [Comment("Is there an autosomal dominant pathogenic variant to support an etiological diagnosis?")]
        public int? AUTDOMMUT { get; set; }

        [Comment("Alzheimer's disease")]
        public bool? ALZDIS { get; set; }

        [Comment("Primary, contributing, or non-contributing - Alzheimer's disease")]
        public int? ALZDISIF { get; set; }

        [Comment("Lewy body disease")]
        public bool? LBDIS { get; set; }

        [Comment("Primary, contributing, or non-contributing - Lewy body disease")]
        public int? LBDIF { get; set; }

        [Comment("Frontotemporal lobar degeneration")]
        public bool? FTLD { get; set; }

        [Comment("Primary supranuclear palsy (PSP)")]
        public bool? PSP { get; set; }

        [Comment("Primary, contributing, or non-contributing - Primary supranuclear palsy (PSP)")]
        public int? PSPIF { get; set; }

        [Comment("Corticobasal degeneration (CBD)")]
        public bool? CORT { get; set; }

        [Comment("Primary, contributing, or non-contributing - Corticobasal degeneration (CBD)")]
        public int? CORTIF { get; set; }

        [Comment("FTLD with motor neuron disease")]
        public bool? FTLDMO { get; set; }

        [Comment("Primary, contributing, or non-contributing - FTLD with motor neuron disease")]
        public int? FTLDMOIF { get; set; }

        [Comment("FTLD not otherwise specified (NOS)")]
        public bool? FTLDNOS { get; set; }

        [Comment("Primary, contributing, or non-contributing - FTLD not otherwise specified (NOS)")]
        public int? FTLDNOIF { get; set; }

        [Comment("FTLD subtype")]
        public int? FTLDSUBT { get; set; }

        [Comment("Other FTLD subtype (specify)")]
        [MaxLength(60)]
        public string? FTLDSUBX { get; set; }

        [Comment("Vascular brain injury (based on clinical and imaging evidence according to your Center's standards)")]
        public bool? CVD { get; set; }

        [Comment("Primary, contributing, or non-contributing - Vascular brain injury")]
        public int? CVDIF { get; set; }

        [Comment("Multiple system atrophy")]
        public bool? MSA { get; set; }

        [Comment("Primary, contributing, or non-contributing - Multiple system atrophy")]
        public int? MSAIF { get; set; }

        [Comment("Chronic traumatic encephalopathy")]
        public bool? CTE { get; set; }

        [Comment("Primary, contributing, or non-contributing - Chronic traumatic encephalopathy")]
        public int? CTEIF { get; set; }

        [Comment("CTE certainty")]
        public int? CTECERT { get; set; }

        [Comment("Down syndrome")]
        public bool? DOWNS { get; set; }

        [Comment("Primary, contributing, or non-contributing - Down syndrome")]
        public int? DOWNSIF { get; set; }

        [Comment("Huntington's disease")]
        public bool? HUNT { get; set; }

        [Comment("Primary, contributing, or non-contributing - Huntington's disease")]
        public int? HUNTIF { get; set; }

        [Comment("Prion disease (CJD, other)")]
        public bool? PRION { get; set; }

        [Comment("Primary, contributing, or non-contributing - Prion disease (CJD, other)")]
        public int? PRIONIF { get; set; }

        [Comment("Cerebral amyloid angiopathy")]
        public bool? CAA { get; set; }

        [Comment("Primary, contributing, or non-contributing - Cerebral amyloid angiopathy")]
        public int? CAAIF { get; set; }

        [Comment("LATE: Limbic-predominant age-related TDP-43 encephalopathy")]
        public bool? LATE { get; set; }

        [Comment("Primary, contributing, or non-contributing - LATE")]
        public int? LATEIF { get; set; }

        [Comment("Other")]
        public bool? OTHCOG { get; set; }

        [Comment("Primary, contributing, or non-contributing - Other")]
        public int? OTHCOGIF { get; set; }

        [Comment("Other (specify)")]
        [MaxLength(60)]
        public string? OTHCOGX { get; set; }

    }
}
