﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UDS.Net.API.Entities
{
    /// <summary>
    /// IVP data template https://files.alz.washington.edu/documentation/uds3-ivp-template.pdf
    /// FVP data template https://files.alz.washington.edu/documentation/uds3-fvp-template.pdf
    /// Form A2: Co-participant demographics
    /// </summary>
    [Table("tbl_A2s")]
    public class A2 : Form
    {
        public int? NEWINF { get; set; }
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

