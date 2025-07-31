using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UDS.Net.API.Entities
{
    /// <summary>
    /// Neurological Examination Findings
    /// </summary>
    [Table("tbl_B8s")]
    public class B8 : Form
    {
        public int? NEUREXAM { get; set; }
        public bool? NORMNREXAM { get; set; }
        public int? PARKSIGN { get; set; }
        public int? SLOWINGFM { get; set; }
        public int? TREMREST { get; set; }
        public int? TREMPOST { get; set; }
        public int? TREMKINE { get; set; }
        public int? RIGIDARM { get; set; }
        public int? RIGIDLEG { get; set; }
        public int? DYSTARM { get; set; }
        public int? DYSTLEG { get; set; }
        public int? CHOREA { get; set; }
        public int? AMPMOTOR { get; set; }
        public int? AXIALRIG { get; set; }
        public int? POSTINST { get; set; }
        public int? MASKING { get; set; }
        public int? STOOPED { get; set; }
        public int? OTHERSIGN { get; set; }
        public int? LIMBAPRAX { get; set; }
        public int? UMNDIST { get; set; }
        public int? LMNDIST { get; set; }
        public int? VFIELDCUT { get; set; }
        public int? LIMBATAX { get; set; }
        public int? MYOCLON { get; set; }
        public int? UNISOMATO { get; set; }
        public int? APHASIA { get; set; }
        public int? ALIENLIMB { get; set; }
        public int? HSPATNEG { get; set; }
        public int? PSPOAGNO { get; set; }
        public int? SMTAGNO { get; set; }
        public int? OPTICATAX { get; set; }
        public int? APRAXGAZE { get; set; }
        public int? VHGAZEPAL { get; set; }
        public int? DYSARTH { get; set; }
        public int? APRAXSP { get; set; }
        public int? GAITABN { get; set; }
        public int? GAITFIND { get; set; }
        [MaxLength(60)]
        public string? GAITOTHRX { get; set; }

    }
}

