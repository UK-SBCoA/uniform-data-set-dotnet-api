using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UDS.Net.API.Entities
{
    [Table("tbl_D1cs")]
    public class D1c : Form
    {
        public DateTime? FRMDATED1C { get; set; }

        [MaxLength(60)]
        public string? INITIALSD1C { get; set; }

        public int? LANGD1C { get; set; }

        public int? MODED1C { get; set; }

        public int? D1CNOT { get; set; }

        public int? DXPLSMABIO { get; set; }

        public int? DXPTAU217 { get; set; }

        public int? PTAU217RS { get; set; }

        public int? PT217ANLYS { get; set; }

        public int? PT217INT { get; set; }

        public int? DXPCPT217 { get; set; }

        public int? PCPT217RS { get; set; }

        public int? PCPT217INT { get; set; }

        public int? DXOTHPLSMA { get; set; }

        [MaxLength(60)]
        public string? DXOTHPLSMX { get; set; }

        public int? OTHPLSMARS { get; set; }

        public int? OPLSMANLYS { get; set; }

        public int? OPLSMAINT { get; set; }

        public int? DXCSFBIO { get; set; }

        public int? DXPT181AB { get; set; }

        public int? PT181ABRS { get; set; }

        public int? PT181ABAYS { get; set; }

        public int? PT181ABINT { get; set; }

        public int? DXTTABETA { get; set; }

        public int? TTABETARS { get; set; }

        public int? TTABETAINT { get; set; }

        public int? DXAB42AB40 { get; set; }

        public int? AB42AB40RS { get; set; }

        public int? AB42AB40AY { get; set; }

        public int? AB42AB40IT { get; set; }

        public int? DXOTHCSF { get; set; }

        [MaxLength(60)]
        public string? DXOTHCSFX { get; set; }

        public int? OTHCSFRS { get; set; }

        public int? OCSFANLYS { get; set; }

        public int? OCSFINT { get; set; }

        public int? DXAPET { get; set; }

        public int? APETRS { get; set; }

        public int? APETVIS { get; set; }

        public int? APETQUANT { get; set; }

        public int? APETANLYS { get; set; }

        public int? APETINT { get; set; }

        public int? DXTAUPET { get; set; }

        public int? TPETMTLRS { get; set; }

        public int? TPETMTLVIS { get; set; }

        public int? TPETMTLQNT { get; set; }

        public int? TPETMTLAYS { get; set; }

        public int? TPETNEORS { get; set; }

        public int? TPETNEOVIS { get; set; }

        public int? TPETNEOQNT { get; set; }

        public int? TPETNEOAYS { get; set; }

        public int? DXTAUPTINT { get; set; }

        public int? INFORISCH { get; set; }

        public int? IMGRSINF { get; set; }

        public int? IMGRSINFLC { get; set; }

        public int? IMGRSINFCT { get; set; }

        public int? IMGRSMICR { get; set; }

        public int? IMGRSWMH { get; set; }

        public int? IMGRSSPSID { get; set; }

        public int? IMGRSOTH { get; set; }

        [MaxLength(60)]
        public string? IMGRSOTHX { get; set; }

        public int? IMGRSINT { get; set; }

        public int? DXASYN { get; set; }

        public int? ASYNRS { get; set; }

        public int? ASYNASSAY { get; set; }

        [MaxLength(60)]
        public string? ASYNASSAYX { get; set; }

        [MaxLength(60)]
        public string? ASYNANLYSX { get; set; }

        public int? ASYNINT { get; set; }

        public int? AACRITMET { get; set; }

        public int? CR1APET { get; set; }

        public int? CR1PTAU217 { get; set; }

        public int? CR1PCPT217 { get; set; }

        public int? CR1PT181AB { get; set; }

        public int? CR1TTABETA { get; set; }

        public int? C1AB42AB40 { get; set; }

        public int? CR1OTH { get; set; }

        [MaxLength(60)]
        public string? CR1OTHX { get; set; }

        public int? BIOSTAGE { get; set; }

        public int? CLINSTAGE { get; set; }
    }
}