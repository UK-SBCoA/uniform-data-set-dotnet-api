using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace UDS.Net.API.Entities
{
    /// <summary>
    /// Vital Signs and Anthropometrics
    /// </summary>
    [Table("tbl_B1s")]
    public class B1 : Form
    {
        // Height range 36.0 to 87.9, 88.8
        [Column(TypeName = "decimal(3,1)")]
        public double? HEIGHT { get; set; }
        public int? WEIGHT { get; set; }
        public int? WAIST1 { get; set; }
        public int? WAIST2 { get; set; }
        public int? HIP1 { get; set; }
        public int? HIP2 { get; set; }
        public int? BPSYSL1 { get; set; }
        public int? BPDIASL1 { get; set; }
        public int? BPSYSL2 { get; set; }
        public int? BPDIASL2 { get; set; }
        public int? BPSYSR1 { get; set; }
        public int? BPDIASR1 { get; set; }
        public int? BPSYSR2 { get; set; }
        public int? BPDIASR2 { get; set; }
        public int? HRATE { get; set; }

    }
}

