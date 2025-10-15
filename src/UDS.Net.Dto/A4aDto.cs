using System;
namespace UDS.Net.Dto
{
    public class A4aDto : FormDto
    {
        public int? TRTBIOMARK { get; set; }

        public int? NEWTREAT { get; set; }
        public A4aTreatmentDto Treatment1 { get; set; } = default!;
        public A4aTreatmentDto Treatment2 { get; set; } = default!;
        public A4aTreatmentDto Treatment3 { get; set; } = default!;
        public A4aTreatmentDto Treatment4 { get; set; } = default!;
        public A4aTreatmentDto Treatment5 { get; set; } = default!;
        public A4aTreatmentDto Treatment6 { get; set; } = default!;
        public A4aTreatmentDto Treatment7 { get; set; } = default!;
        public A4aTreatmentDto Treatment8 { get; set; } = default!;

        public int? NEWADEVENT { get; set; }
        public int? ADVEVENT { get; set; }
        public bool? ARIAE { get; set; }
        public bool? ARIAH { get; set; }
        public bool? ADVERSEOTH { get; set; }
        public string ADVERSEOTX { get; set; }
    }
}

