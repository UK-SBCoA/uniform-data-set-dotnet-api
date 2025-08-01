﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UDS.Net.API.Entities
{
    /// <summary>
    /// Clinician Judgment of Symptoms
    /// </summary>
    [Table("tbl_B9s")]
    public class B9 : Form
    {
        public int? DECCOG { get; set; }
        public int? DECMOT { get; set; }
        public int? PSYCHSYM { get; set; }
        public int? DECCOGIN { get; set; }
        public int? DECMOTIN { get; set; }
        public int? PSYCHSYMIN { get; set; }
        public bool? DECCLIN { get; set; }
        public bool? DECCLCOG { get; set; }
        public int? COGMEM { get; set; }
        public int? COGORI { get; set; }
        public int? COGJUDG { get; set; }
        public int? COGLANG { get; set; }
        public int? COGVIS { get; set; }
        public int? COGATTN { get; set; }
        public int? COGFLUC { get; set; }
        public int? COGOTHR { get; set; }
        [MaxLength(60)]
        public string? COGOTHRX { get; set; }
        public int? COGAGE { get; set; }
        public int? COGMODE { get; set; }
        [MaxLength(60)]
        public string? COGMODEX { get; set; }
        public int? DECCLBE { get; set; }
        public int? BEAPATHY { get; set; }
        public int? BEDEP { get; set; }
        public int? BEANX { get; set; }
        public int? BEEUPH { get; set; }
        public int? BEIRRIT { get; set; }
        public int? BEAGIT { get; set; }
        public int? BEHAGE { get; set; }
        public int? BEVHALL { get; set; }
        public int? BEVPATT { get; set; }
        public int? BEVWELL { get; set; }
        public int? BEAHALL { get; set; }
        public int? BEAHSIMP { get; set; }
        public int? BEAHCOMP { get; set; }
        public int? BEDEL { get; set; }
        public int? BEAGGRS { get; set; }
        public int? PSYCHAGE { get; set; }
        public int? BEDISIN { get; set; }
        public int? BEPERCH { get; set; }
        public int? BEEMPATH { get; set; }
        public int? BEOBCOM { get; set; }
        public int? BEANGER { get; set; }
        public int? BESUBAB { get; set; }
        public bool? ALCUSE { get; set; }
        public bool? SEDUSE { get; set; }
        public bool? OPIATEUSE { get; set; }
        public bool? COCAINEUSE { get; set; }
        public bool? CANNABUSE { get; set; }
        public bool? OTHSUBUSE { get; set; }
        [MaxLength(60)]
        public string? OTHSUBUSEX { get; set; }
        public int? PERCHAGE { get; set; }
        public int? BEREM { get; set; }
        public int? BEREMAGO { get; set; }
        public int? BEREMCONF { get; set; }
        public int? BEOTHR { get; set; }
        public string? BEOTHRX { get; set; }
        public int? BEMODE { get; set; }
        public string? BEMODEX { get; set; }
        public bool? DECCLMOT { get; set; }
        public int? MOGAIT { get; set; }
        public int? MOFALLS { get; set; }
        public int? MOSLOW { get; set; }
        public int? MOTREM { get; set; }
        public int? MOLIMB { get; set; }
        public int? MOFACE { get; set; }
        public int? MOSPEECH { get; set; }
        public int? MOTORAGE { get; set; }
        public int? MOMODE { get; set; }
        public string? MOMODEX { get; set; }
        public int? MOMOPARK { get; set; }
        public int? MOMOALS { get; set; }
        public int? COURSE { get; set; }
        public int? FRSTCHG { get; set; }
    }
}

