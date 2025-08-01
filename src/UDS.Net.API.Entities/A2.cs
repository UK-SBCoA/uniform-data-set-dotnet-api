using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UDS.Net.API.Entities
{
    /// <summary>
    /// UDS 4 https://github.com/naccdata/uniform-data-set/blob/main/forms/uds/a2/form_a2_ivp_questions_and%20vars.csv
    /// Form A2: Co-participant demographics
    /// </summary>
    [Table("tbl_A2s")]
    public class A2 : Form
    {
        public int? INRELTO { get; set; }
        public int? INKNOWN { get; set; }
        public int? INLIVWTH { get; set; }
        public int? INCNTMOD { get; set; }
        [MaxLength(60)]
        public string? INCNTMDX { get; set; }
        public int? INCNTFRQ { get; set; }
        public int? INCNTTIM { get; set; }
        public int? INRELY { get; set; }
        public int? INMEMWORS { get; set; }
        public int? INMEMTROUB { get; set; }
        public int? INMEMTEN { get; set; }

    }
}

