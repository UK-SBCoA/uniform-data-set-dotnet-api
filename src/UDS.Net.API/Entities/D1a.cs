using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UDS.Net.API.Entities
{

    [Table("tbl_D1as")]
    public class D1a : Form
    {
        [Comment("1. Diagnosis method—responses in this form are based on diagnosis by a:")]
        public int? DXMETHOD { get; set; }
        [Comment("2. Does the participant have unimpaired cognition & behavior")]
        public int? NORMCOG { get; set; }
        [Comment("2a. Does the participant report 1) significant concerns about changes in cognition AND 2) no neuropsychological evidence of decline AND 3) no functional decline?")]
        public int? SCD { get; set; }
        [Comment("2b. As a clinician, are you confident that the subjective cognitive decline is clinically meaningful?")]
        public int? SCDDXCONF { get; set; }
        [Comment("3. Does the participant meet criteria for dementia?")]
        public int? DEMENTED { get; set; }
        [Comment("4a1. MCI criteria - Clinical concern about decline in cognition compared to participant’s prior level of lifelong or usual cognitive function")]
        public bool? MCICRITCLN { get; set; }
        [Comment("4a2. MCI criteria - Impairment in one or more cognitive domains, compared to participant’s estimated prior level of lifelong or usual cognitive function, or supported by objective longitudinal neuropsychological evidence of decline")]
        public bool? MCICRITIMP { get; set; }
        [Comment("4a3. MCI criteria - Largely preserved functional independence OR functional dependence that is not related to cognitive decline")]
        public bool? MCICRITFUN { get; set; }
        [Comment("4b. Does the participant meet criteria for MCI (amnestic or non-amnestic)?")]
        public int? MCI { get; set; }
        [Comment("5a1. Cognitively impaired, not MCI reason - Evidence of functional impairment (e.g., CDR SB>0 and/or FAS>0), but available cognitive testing is judged to be normal")]
        public bool? IMPNOMCIFU { get; set; }
        [Comment("5a2. Cognitively impaired, not MCI reason - Cognitive testing is abnormal but no clinical concern or functional decline (e.g., CDR SB=0 and FAS=0)")]
        public bool? IMPNOMCICG { get; set; }
        [Comment("5a3. Cognitively impaired, not MCI reason - Longstanding cognitive difficulties, not representing a change from their usual function")]
        public bool? IMPNOMCLCD { get; set; }
        [Comment("5a4. Cognitively impaired, not MCI reason - Other")]
        public bool? IMPNOMCIO { get; set; }
        [Comment("5a4a. Cognitively impaired, not MCI reason - Other (specify)")]
        [MaxLength(60)]
        public string? IMPNOMCIOX { get; set; }
        [Comment("5b. Cognitively impaired, not MCI")]
        public bool? IMPNOMCI { get; set; }
        [Comment("6a. Dementia and MCI affected domains - Memory")]
        public bool? CDOMMEM { get; set; }
        [Comment("6b. Dementia and MCI affected domains - Language")]
        public bool? CDOMLANG { get; set; }
        [Comment("6c. Dementia and MCI affected domains - Attention")]
        public bool? CDOMATTN { get; set; }
        [Comment("6d. Dementia and MCI affected domains - Executive")]
        public bool? CDOMEXEC { get; set; }
        [Comment("6e. Dementia and MCI affected domains - Visuospatial")]
        public bool? CDOMVISU { get; set; }
        [Comment("6f. Dementia and MCI affected domains - Behavioral")]
        public bool? CDOMBEH { get; set; }
        [Comment("6g. Dementia and MCI affected domains - Apraxia")]
        public bool? CDOMAPRAX { get; set; }
        [Comment("7. Does the participant meet criteria for MBI")]
        public int? MBI { get; set; }
        [Comment("7a. MBI affected domains - Motivation")]
        public int? BDOMMOT { get; set; }
        [Comment("7b. MBI affected domains - Affective regulation")]
        public int? BDOMAFREG { get; set; }
        [Comment("7c. MBI affected domains - Impulse control")]
        public int? BDOMIMP { get; set; }
        [Comment("7d. MBI affected domains - Social appropriateness")]
        public int? BDOMSOCIAL { get; set; }
        [Comment("7e. MBI affected domains - Thought content/perception")]
        public int? BDOMTHTS { get; set; }
        [Comment("8. Is there a predominant clinical syndrome?")]
        public int? PREDOMSYN { get; set; }
        [Comment("8a. Amnestic predominant syndrome")]
        public bool? AMNDEM { get; set; }
        [Comment("8b. Dysexecutive predominant syndrome")]
        public bool? DYEXECSYN { get; set; }
        [Comment("8c. Primary visual presentation (such as posterior cortical atrophy (PCA) syndrome)")]
        public bool? PCA { get; set; }
        [Comment("8d. Primary progressive aphasia (PPA) syndrome")]
        public bool? PPASYN { get; set; }
        [Comment("8d1. Primary progressive aphasia (PPA) syndrome - type")]
        public int? PPASYNT { get; set; }
        [Comment("8e. Behavioral variant frontotemporal (bvFTD) syndrome")]
        public bool? FTDSYN { get; set; }
        [Comment("8f. Lewy body syndrome")]
        public bool? LBDSYN { get; set; }
        [Comment("8f1. Lewy body syndrome - type")]
        public int? LBDSYNT { get; set; }
        [Comment("8g. Non-amnestic multidomain syndrome, not PCA, PPA, bvFT, or DLB syndrome")]
        public bool? NAMNDEM { get; set; }
        [Comment("8h. Primary supranuclear palsy (PSP) syndrome")]
        public bool? PSPSYN { get; set; }
        [Comment("8h1. Primary supranuclear palsy (PSP) syndrome - type")]
        public int? PSPSYNT { get; set; }
        [Comment("8i. Traumatic encephalopathy syndrome")]
        public bool? CTESYN { get; set; }
        [Comment("8j. Corticobasal syndrome (CBS)")]
        public bool? CBSSYN { get; set; }
        [Comment("8k. Multiple system atrophy (MSA) syndrome")]
        public bool? MSASYN { get; set; }
        [Comment("8k1. Multiple system atrophy (MSA) syndrome - type")]
        public int? MSASYNT { get; set; }
        [Comment("8l. Other syndrome")]
        public bool? OTHSYN { get; set; }
        [Comment("8l1. Other syndrome (specify)")]
        [MaxLength(60)]
        public string? OTHSYNX { get; set; }
        [Comment("9a. Indicate the source(s) of information used to assign the clinical syndrome - Clinical information (history, CDR)")]
        public bool? SYNINFCLIN { get; set; }
        [Comment("9b. Indicate the source(s) of information used to assign the clinical syndrome - Cognitive testing")]
        public bool? SYNINFCTST { get; set; }
        [Comment("9c. Indicate the source(s) of information used to assign the clinical syndrome - Biomarkers (MRI, PET, CSF, plasma)")]
        public bool? SYNINFBIOM { get; set; }
        [Comment("10. Major depressive disorder (present)")]
        public bool? MAJDEPDX { get; set; }
        [Comment("10a. Major depressive disorder (primary/contributing/non-contributing)")]
        public int? MAJDEPDIF { get; set; }
        [Comment("11. Other specified depressive disorder (present)")]
        public bool? OTHDEPDX { get; set; }
        [Comment("11a. Other specified depressive disorder (primary/contributing/non-contributing)")]
        public int? OTHDEPDIF { get; set; }
        [Comment("12. Bipolar disorder (present)")]
        public bool? BIPOLDX { get; set; }
        [Comment("12a. Bipolar disorder (primary/contributing/non-contributing)")]
        public int? BIPOLDIF { get; set; }
        [Comment("13. Schizophrenia or other psychotic disorder (present)")]
        public bool? SCHIZOP { get; set; }
        [Comment("13a. Schizophrenia or other psychotic disorder (primary/contributing/non-contributing)")]
        public int? SCHIZOIF { get; set; }
        [Comment("14. Anxiety disorder (present)")]
        public bool? ANXIET { get; set; }
        [Comment("14a. Anxiety disorder (primary/contributing/non-contributing)")]
        public bool? ANXIETIF { get; set; }
        [Comment("14b. Generalized Anxiety Disorder")]
        public bool? GENANX { get; set; }
        [Comment("14c. Panic Disorder")]
        public bool? PANICDISDX { get; set; }
        [Comment("14d. Obsessive-compulsive disorder (OCD)")]
        public bool? OCDDX { get; set; }
        [Comment("14e. Other anxiety disorder")]
        public bool? OTHANXD { get; set; }
        [Comment("14e1. Other anxiety disorder (specify)")]
        [MaxLength(60)]
        public string? OTHANXDX { get; set; }
        [Comment("15. Post-traumatic stress disorder (PTSD) (present)")]
        public bool? PTSDDX { get; set; }
        [Comment("15a. Post-traumatic stress disorder (PTSD) (primary/contributing/non-contributing)")]
        public int? PTSDDXIF { get; set; }
        [Comment("16. Developmental neuropsychiatric disorders (e.g., autism spectrum disorder (ASD), attention-deficit hyperactivity disorder (ADHD), dyslexia) (present)")]
        public bool? NDEVDIS { get; set; }
        [Comment("16a. Developmental neuropsychiatric disorders (e.g., autism spectrum disorder (ASD), attention-deficit hyperactivity disorder (primary/contributing/non-contributing)")]
        public int? NDEVDISIF { get; set; }
        [Comment("17. Delirium (present)")]
        public bool? DELIR { get; set; }
        [Comment("17a. Delirium (primary/contributing/non-contributing)")]
        public int? DELIRIF { get; set; }
        [Comment("18. Other psychiatric disorder (present)")]
        public bool? OTHPSY { get; set; }
        [Comment("18a. Other psychiatric disorder (primary/contributing/non-contributing)")]
        public int? OTHPSYIF { get; set; }
        [Comment("18b. Other psychiatric disorder (specify)")]
        [MaxLength(60)]
        public string? OTHPSYX { get; set; }
        [Comment("19. Traumatic brain injury (present)")]
        public bool? TBIDX { get; set; }
        [Comment("19a. Traumatic brain injury (primary/contributing/non-contributing)")]
        public int? TBIDXIF { get; set; }
        [Comment("20. Epilepsy (present)")]
        public bool? EPILEP { get; set; }
        [Comment("20a. Epilepsy (primary/contributing/non-contributing)")]
        public int? EPILEPIF { get; set; }
        [Comment("21. Normal-pressure hydrocephalus (present)")]
        public bool? HYCEPH { get; set; }
        [Comment("21a. Normal-pressure hydrocephalus (primary/contributing/non-contributing)")]
        public int? HYCEPHIF { get; set; }
        [Comment("22. CNS Neoplasm (present)")]
        public bool? NEOP { get; set; }
        [Comment("22a. CNS Neoplasm (primary/contributing/non-contributing)")]
        public int? NEOPIF { get; set; }
        [Comment("22b. CNS Neoplasm - benign or malignant")]
        public int? NEOPSTAT { get; set; }
        [Comment("23. Human Immunodeficiency Virus (HIV) infection (present)")]
        public bool? HIV { get; set; }
        [Comment("23a. Human Immunodeficiency Virus (HIV) infection (primary/contributing/non-contributing)")]
        public int? HIVIF { get; set; }
        [Comment("24. Post COVID-19 cognitive impairment (present)")]
        public bool? POSTC19 { get; set; }
        [Comment("24a. Post COVID-19 cognitive impairment (primary/contributing/non-contributing)")]
        public int? POSTC19IF { get; set; }
        [Comment("25. Sleep apnea (i.e., obstructive, central, mixed or complex sleep apnea) (present)")]
        public bool? APNEADX { get; set; }
        [Comment("25a. Sleep apnea (i.e., obstructive, central, mixed or complex sleep apnea) (primary/contributing/non-contributing)")]
        public int? APNEADXIF { get; set; }
        [Comment("26. Cognitive impairment due to other neurologic, genetic, infectious conditions (not listed above), or systemic disease/medical illness (as indicated on Form A5/D2) (present)")]
        public bool? OTHCOGILL { get; set; }
        [Comment("26a. Cognitive impairment due to other neurologic, genetic, infectious conditions (not listed above), or systemic disease/medical illness (as indicated on Form A5/D2) (primary/contributing/non-contributing)")]
        public int? OTHCILLIF { get; set; }
        [Comment("26b. Specify cognitive impairment due to other neurologic, genetic, infection conditions or systemic disease")]
        [MaxLength(60)]
        public string? OTHCOGILLX { get; set; }
        [Comment("27. Cognitive impairment due to alcohol abuse (present)")]
        public bool? ALCDEM { get; set; }
        [Comment("27a. Cognitive impairment due to alcohol abuse (primary/contributing/non-contributing)")]
        public int? ALCDEMIF { get; set; }
        [Comment("28. Cognitive impairment due to substance use or abuse (present)")]
        public bool? IMPSUB { get; set; }
        [Comment("28a. Cognitive impairment due to substance use or abuse (primary/contributing/non-contributing)")]
        public int? IMPSUBIF { get; set; }
        [Comment("29. Cognitive impairment due to medications (present)")]
        public bool? MEDS { get; set; }
        [Comment("29a. Cognitive impairment due to medications (primary/contributing/non-contributing)")]
        public int? MEDSIF { get; set; }
        [Comment("30. Cognitive impairment not otherwise specified (NOS) (present)")]
        public bool? COGOTH { get; set; }
        [Comment("30a. Cognitive impairment NOS (primary/contributing/non-contributing)")]
        public int? COGOTHIF { get; set; }
        [Comment("30b. Cognitive impairment NOS (specify)")]
        [MaxLength(60)]
        public string? COGOTHX { get; set; }
        [Comment("31. Cognitive impairment not otherwise specified (NOS) (present)")]
        public bool? COGOTH2 { get; set; }
        [Comment("31a. Cognitive impairment NOS (primary/contributing/non-contributing)")]
        public int? COGOTH2F { get; set; }
        [Comment("31b. Cognitive impairment NOS (specify)")]
        [MaxLength(60)]
        public string? COGOTH2X { get; set; }
        [Comment("32. Cognitive impairment not otherwise specified (NOS) (present)")]
        public bool? COGOTH3 { get; set; }
        [Comment("32a. Cognitive impairment NOS (primary/contributing/non-contributing)")]
        public int? COGOTH3F { get; set; }
        [Comment("32b. Cognitive impairment NOS (specify)")]
        [MaxLength(60)]
        public string? COGOTH3X { get; set; }
    }
}
