using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UDS.Net.API.Entities
{
    [Table("tbl_D1bs")]
    public class D1b : Form
    {
        public int? BIOMARKDX { get; set; }

        public int? FLUIDBIOM { get; set; }

        public int? BLOODAD { get; set; }

        public int? BLOODFTLD { get; set; }

        public int? BLOODLBD { get; set; }

        public int? BLOODOTH { get; set; }

        [MaxLength(60)]
        public string? BLOODOTHX { get; set; }

        public int? CSFAD { get; set; }

        public int? CSFFTLD { get; set; }

        public int? CSFLBD { get; set; }

        public int? CSFOTH { get; set; }

        [MaxLength(60)]
        public string? CSFOTHX { get; set; }

        public int? IMAGINGDX { get; set; }

        public int? PETDX { get; set; }

        public int? AMYLPET { get; set; }

        public int? TAUPET { get; set; }

        public int? FDGPETDX { get; set; }

        public int? FDGAD { get; set; }

        public int? FDGFTLD { get; set; }

        public int? FDGLBD { get; set; }

        public int? FDGOTH { get; set; }

        [MaxLength(60)]
        public string? FDGOTHX { get; set; }

        public int? DATSCANDX { get; set; }

        public int? TRACOTHDX { get; set; }

        [MaxLength(60)]
        public string? TRACOTHDXX { get; set; }

        public int? TRACERAD { get; set; }

        public int? TRACERFTLD { get; set; }

        public int? TRACERLBD { get; set; }

        public int? TRACEROTH { get; set; }

        [MaxLength(60)]
        public string? TRACEROTHX { get; set; }

        public int? STRUCTDX { get; set; }

        public int? STRUCTAD { get; set; }

        public int? STRUCTFTLD { get; set; }

        public int? STRUCTCVD { get; set; }

        public int? IMAGLINF { get; set; }

        public int? IMAGLAC { get; set; }

        public int? IMAGMACH { get; set; }

        public int? IMAGMICH { get; set; }

        public int? IMAGWMH { get; set; }

        public int? IMAGWMHSEV { get; set; }

        public int? OTHBIOM1 { get; set; }

        [MaxLength(60)]
        public string? OTHBIOMX1 { get; set; }

        public int? BIOMAD1 { get; set; }

        public int? BIOMFTLD1 { get; set; }

        public int? BIOMLBD1 { get; set; }

        public int? BIOMOTH1 { get; set; }

        [MaxLength(60)]
        public string? BIOMOTHX1 { get; set; }

        public int? OTHBIOM2 { get; set; }

        [MaxLength(60)]
        public string? OTHBIOMX2 { get; set; }

        public int? BIOMAD2 { get; set; }

        public int? BIOMFTLD2 { get; set; }

        public int? BIOMLBD2 { get; set; }

        public int? BIOMOTH2 { get; set; }

        [MaxLength(60)]
        public string? BIOMOTHX2 { get; set; }

        public int? OTHBIOM3 { get; set; }

        [MaxLength(60)]
        public string? OTHBIOMX3 { get; set; }

        public int? BIOMAD3 { get; set; }

        public int? BIOMFTLD3 { get; set; }

        public int? BIOMLBD3 { get; set; }

        public int? BIOMOTH3 { get; set; }

        [MaxLength(60)]
        public string? BIOMOTHX3 { get; set; }

        public int? AUTDOMMUT { get; set; }

        public bool? ALZDIS { get; set; }

        public int? ALZDISIF { get; set; }

        public bool? LBDIS { get; set; }

        public int? LBDIF { get; set; }

        public bool? FTLD { get; set; }

        public bool? PSP { get; set; }

        public int? PSPIF { get; set; }

        public bool? CORT { get; set; }

        public int? CORTIF { get; set; }

        public bool? FTLDMO { get; set; }

        public int? FTLDMOIF { get; set; }

        public bool? FTLDNOS { get; set; }

        public int? FTLDNOIF { get; set; }

        public int? FTLDSUBT { get; set; }

        [MaxLength(60)]
        public string? FTLDSUBX { get; set; }

        public bool? CVD { get; set; }

        public int? CVDIF { get; set; }

        public bool? MSA { get; set; }

        public int? MSAIF { get; set; }

        public bool? CTE { get; set; }

        public int? CTEIF { get; set; }

        public int? CTECERT { get; set; }

        public bool? DOWNS { get; set; }

        public int? DOWNSIF { get; set; }

        public bool? HUNT { get; set; }

        public int? HUNTIF { get; set; }

        public bool? PRION { get; set; }

        public int? PRIONIF { get; set; }

        public bool? CAA { get; set; }

        public int? CAAIF { get; set; }

        public bool? LATE { get; set; }

        public int? LATEIF { get; set; }

        public bool? OTHCOG { get; set; }

        public int? OTHCOGIF { get; set; }

        [MaxLength(60)]
        public string? OTHCOGX { get; set; }

    }
}
