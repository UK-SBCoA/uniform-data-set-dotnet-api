using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UDS.Net.API.Entities
{
    /// <summary>
    /// Form A3: Family history
    /// </summary>
    [Table("tbl_A3s")]
    public class A3 : Form
    {
        public int? AFFFAMM { get; set; } // Assuming these variables will remain in UDS4

        public int? NWINFMUT { get; set; } // Assuming these variables will remain in UDS4

        public int? MOMYOB { get; set; }

        public int? MOMDAGE { get; set; }

        public int? MOMETPR { get; set; }

        public int? MOMETSEC { get; set; }

        public int? MOMMEVAL { get; set; }

        public int? MOMAGEO { get; set; }


        public int? DADYOB { get; set; }

        public int? DADDAGE { get; set; }

        public int? DADETPR { get; set; }

        public int? DADETSEC { get; set; }

        public int? DADMEVAL { get; set; }

        public int? DADAGEO { get; set; }

        public int? SIBS { get; set; }

        public int? NWINFSIB { get; set; }

        public A3FamilyMember SIB1 { get; set; } = default!;
        public A3FamilyMember SIB2 { get; set; } = default!;
        public A3FamilyMember SIB3 { get; set; } = default!;
        public A3FamilyMember SIB4 { get; set; } = default!;
        public A3FamilyMember SIB5 { get; set; } = default!;
        public A3FamilyMember SIB6 { get; set; } = default!;
        public A3FamilyMember SIB7 { get; set; } = default!;
        public A3FamilyMember SIB8 { get; set; } = default!;
        public A3FamilyMember SIB9 { get; set; } = default!;
        public A3FamilyMember SIB10 { get; set; } = default!;
        public A3FamilyMember SIB11 { get; set; } = default!;
        public A3FamilyMember SIB12 { get; set; } = default!;
        public A3FamilyMember SIB13 { get; set; } = default!;
        public A3FamilyMember SIB14 { get; set; } = default!;
        public A3FamilyMember SIB15 { get; set; } = default!;
        public A3FamilyMember SIB16 { get; set; } = default!;
        public A3FamilyMember SIB17 { get; set; } = default!;
        public A3FamilyMember SIB18 { get; set; } = default!;
        public A3FamilyMember SIB19 { get; set; } = default!;
        public A3FamilyMember SIB20 { get; set; } = default!;

        public int? KIDS { get; set; }

        public int? NWINFKID { get; set; }

        public A3FamilyMember KID1 { get; set; } = default!;
        public A3FamilyMember KID2 { get; set; } = default!;
        public A3FamilyMember KID3 { get; set; } = default!;
        public A3FamilyMember KID4 { get; set; } = default!;
        public A3FamilyMember KID5 { get; set; } = default!;
        public A3FamilyMember KID6 { get; set; } = default!;
        public A3FamilyMember KID7 { get; set; } = default!;
        public A3FamilyMember KID8 { get; set; } = default!;
        public A3FamilyMember KID9 { get; set; } = default!;
        public A3FamilyMember KID10 { get; set; } = default!;
        public A3FamilyMember KID11 { get; set; } = default!;
        public A3FamilyMember KID12 { get; set; } = default!;
        public A3FamilyMember KID13 { get; set; } = default!;
        public A3FamilyMember KID14 { get; set; } = default!;
        public A3FamilyMember KID15 { get; set; } = default!;

    }
}

