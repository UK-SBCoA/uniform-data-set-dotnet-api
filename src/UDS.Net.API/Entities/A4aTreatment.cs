using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace UDS.Net.API.Entities
{
    [Owned]
    public class A4aTreatment
    {
        public bool? TARGETAB { get; set; }
        public bool? TARGETTAU { get; set; }
        public bool? TARGETINF { get; set; }
        public bool? TARGETSYN { get; set; }
        public bool? TARGETOTH { get; set; }
        [MaxLength(60)]
        public string? TARGETOTX { get; set; }
        [MaxLength(60)]
        public string? TRTTRIAL { get; set; }
        [MaxLength(60)]
        public string? NCTNUM { get; set; }

        public int? STARTMO { get; set; }
        public int? STARTYEAR { get; set; }
        public int? ENDMO { get; set; }
        public int? ENDYEAR { get; set; }
        public int? CARETRIAL { get; set; }
        public int? TRIALGRP { get; set; }
    }
}

