using System;
namespace UDS.Net.Dto
{
    public class A4aTreatmentDto
    {
        public int FormId { get; set; }
        public bool? TARGETAB { get; set; }
        public bool? TARGETTAU { get; set; }
        public bool? TARGETINF { get; set; }
        public bool? TARGETSYN { get; set; }
        public bool? TARGETOTH { get; set; }
        public string TARGETOTX { get; set; }
        public string TRTTRIAL { get; set; }
        public string NCTNUM { get; set; }
        public int? STARTMO { get; set; }
        public int? STARTYEAR { get; set; }
        public int? ENDMO { get; set; }
        public int? ENDYEAR { get; set; }
        public int? CARETRIAL { get; set; }
        public int? TRIALGRP { get; set; }
    }
}

