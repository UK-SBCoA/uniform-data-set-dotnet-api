using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UDS.Net.API.Entities
{
    [Table("tbl_A4as")]
    public class A4a : Form
    {
        public int? TRTBIOMARK { get; set; }

        public A4aTreatment Treatment1 { get; set; } = default!;
        public A4aTreatment Treatment2 { get; set; } = default!;
        public A4aTreatment Treatment3 { get; set; } = default!;
        public A4aTreatment Treatment4 { get; set; } = default!;
        public A4aTreatment Treatment5 { get; set; } = default!;
        public A4aTreatment Treatment6 { get; set; } = default!;
        public A4aTreatment Treatment7 { get; set; } = default!;
        public A4aTreatment Treatment8 { get; set; } = default!;

        public int? ADVEVENT { get; set; }
        public bool? ARIAE { get; set; }
        public bool? ARIAH { get; set; }
        public bool? ADVERSEOTH { get; set; }
        [MaxLength(60)]
        public string? ADVERSEOTX { get; set; }
    }
}

