using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UDS.Net.API.Entities
{
    /// <summary>
    /// Neuropsychological Battery Scores (UDS3)
    /// </summary>
    [Table("tbl_C2s")]
    public class C2 : Form
    {
        public int? MOCACOMP { get; set; }
        public int? MOCAREAS { get; set; }
        public int? MOCALOC { get; set; }
        public int? MOCALAN { get; set; }
        [MaxLength(60)]
        public string? MOCALANX { get; set; }
        public int? MOCAVIS { get; set; }
        public int? MOCAHEAR { get; set; }
        public int? MOCATOTS { get; set; }
        public int? MOCBTOTS { get; set; }
        public int? MOCATRAI { get; set; }
        public int? MOCACUBE { get; set; }
        public int? MOCACLOC { get; set; }
        public int? MOCACLON { get; set; }
        public int? MOCACLOH { get; set; }
        public int? MOCANAMI { get; set; }
        public int? MOCAREGI { get; set; }
        public int? MOCADIGI { get; set; }
        public int? MOCALETT { get; set; }
        public int? MOCASER7 { get; set; }
        public int? MOCAREPE { get; set; }
        public int? MOCAFLUE { get; set; }
        public int? MOCAABST { get; set; }
        public int? MOCARECN { get; set; }
        public int? MOCARECC { get; set; }
        public int? MOCARECR { get; set; }
        public int? MOCAORDT { get; set; }
        public int? MOCAORMO { get; set; }
        public int? MOCAORYR { get; set; }
        public int? MOCAORDY { get; set; }
        public int? MOCAORPL { get; set; }
        public int? MOCAORCT { get; set; }
        public int? NPSYCLOC { get; set; }
        public int? NPSYLAN { get; set; }
        [MaxLength(60)]
        public string? NPSYLANX { get; set; }
        public int? CRAFTVRS { get; set; }
        public int? CRAFTURS { get; set; }
        public int? UDSBENTC { get; set; }
        public int? DIGFORCT { get; set; }
        public int? DIGFORSL { get; set; }
        public int? DIGBACCT { get; set; }
        public int? DIGBACLS { get; set; }
        public int? ANIMALS { get; set; }
        public int? VEG { get; set; }
        public int? TRAILA { get; set; }
        public int? TRAILARR { get; set; }
        public int? TRAILALI { get; set; }
        public int? TRAILB { get; set; }
        public int? TRAILBRR { get; set; }
        public int? TRAILBLI { get; set; }
        public int? UDSBENTD { get; set; }
        public int? UDSBENRS { get; set; }
        public int? CRAFTDVR { get; set; }
        public int? CRAFTDRE { get; set; }
        public int? CRAFTDTI { get; set; }
        public int? CRAFTCUE { get; set; }
        public int? UDSVERFC { get; set; }
        public int? UDSVERFN { get; set; }
        public int? UDSVERNF { get; set; }
        public int? UDSVERLC { get; set; }
        public int? UDSVERLR { get; set; }
        public int? UDSVERLN { get; set; }
        public int? UDSVERTN { get; set; }
        public int? UDSVERTE { get; set; }
        public int? UDSVERTI { get; set; }
        public int? VERBALTEST { get; set; }
        public int? REY1REC { get; set; }
        public int? REY1INT { get; set; }
        public int? REY2REC { get; set; }
        public int? REY2INT { get; set; }
        public int? REY3REC { get; set; }
        public int? REY3INT { get; set; }
        public int? REY4REC { get; set; }
        public int? REY4INT { get; set; }
        public int? REY5REC { get; set; }
        public int? REY5INT { get; set; }
        public int? REYBREC { get; set; }
        public int? REYBINT { get; set; }
        public int? REY6REC { get; set; }
        public int? REY6INT { get; set; }
        public int? REYDREC { get; set; }
        public int? REYDINT { get; set; }
        public int? REYDTI { get; set; }
        public int? REYMETHOD { get; set; }
        public int? REYTCOR { get; set; }
        public int? REYFPOS { get; set; }
        public int? VNTTOTW { get; set; }
        public int? VNTPCNC { get; set; }
        public int? CERAD1REC { get; set; }
        public int? CERAD1READ { get; set; }
        public int? CERAD1INT { get; set; }
        public int? CERAD2REC { get; set; }
        public int? CERAD2READ { get; set; }
        public int? CERAD2INT { get; set; }
        public int? CERAD3REC { get; set; }
        public int? CERAD3READ { get; set; }
        public int? CERAD3INT { get; set; }
        public int? CERADDTI { get; set; }
        public int? CERADJ6REC { get; set; }
        public int? CERADJ6INT { get; set; }
        public int? CERADJ7YES { get; set; }
        public int? CERADJ7NO { get; set; }
        public int? OTRAILA { get; set; }
        public int? OTRLARR { get; set; }
        public int? OTRLALI { get; set; }
        public int? OTRAILB { get; set; }
        public int? OTRLBRR { get; set; }
        public int? OTRLBLI { get; set; }
        public int? MINTTOTS { get; set; }
        public int? MINTTOTW { get; set; }
        public int? MINTSCNG { get; set; }
        public int? MINTSCNC { get; set; }
        public int? MINTPCNG { get; set; }
        public int? MINTPCNC { get; set; }
        public int? COGSTAT { get; set; }
        public int? RESPVAL { get; set; }
        public bool? RESPHEAR { get; set; }
        public bool? RESPDIST { get; set; }
        public bool? RESPINTR { get; set; }
        public bool? RESPDISN { get; set; }
        public bool? RESPFATG { get; set; }
        public bool? RESPEMOT { get; set; }
        public bool? RESPASST { get; set; }
        public bool? RESPOTH { get; set; }
        [MaxLength(60)]
        public string? RESPOTHX { get; set; }
    }
}

