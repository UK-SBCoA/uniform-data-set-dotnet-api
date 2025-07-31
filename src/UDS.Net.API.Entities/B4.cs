using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace UDS.Net.API.Entities
{
    /// <summary>
    /// CDR Dementia Staging Instrument Plus NACC FTLD Behavior & Language Domains (CDR Plus NACC FTLD)
    /// </summary>
    [Table("tbl_B4s")]
    public class B4 : Form
    {
        [Column(TypeName = "decimal(2,1)")]
        public double? MEMORY { get; set; }
        [Column(TypeName = "decimal(2,1)")]
        public double? ORIENT { get; set; }
        [Column(TypeName = "decimal(2,1)")]
        public double? JUDGMENT { get; set; }
        [Column(TypeName = "decimal(2,1)")]
        public double? COMMUN { get; set; }
        [Column(TypeName = "decimal(2,1)")]
        public double? HOMEHOBB { get; set; }
        [Column(TypeName = "decimal(2,1)")]
        public double? PERSCARE { get; set; }
        [Column(TypeName = "decimal(3,1)")]
        public double? CDRSUM { get; set; }
        [Column(TypeName = "decimal(2,1)")]
        public double? CDRGLOB { get; set; }
        [Column(TypeName = "decimal(2,1)")]
        public double? COMPORT { get; set; }
        [Column(TypeName = "decimal(2,1)")]
        public double? CDRLANG { get; set; }
    }
}

