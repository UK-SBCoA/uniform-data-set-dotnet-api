using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UDS.Net.API.Entities
{
    public abstract class Form : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("FormId", Order = 0)]
        public int Id { get; set; }

        // CenterOnAging.studies.tbl_Visits
        [Column(Order = 1)]
        public int VisitId { get; set; }

        [MaxLength(20)]
        [Column(Order = 2)]
        public string Status { get; set; } = default!;

        [Column("LANG", Order = 3)]
        public Language? Language { get; set; }

        [Column("MODE", Order = 4)] // TODO update variable name
        public FormMode? Mode { get; set; }

        [Column("REMOTEMODE", Order = 5)] // TODO update variable name
        public RemoteMode? RemoteMode { get; set; }

        [Column("REMOTEREASON", Order = 6)] // TODO update variable name
        public RemoteReasonCode? RemoteReasonCode { get; set; }

        [Column("SUB", Order = 7)]
        public bool? IsIncluded { get; set; }

        [Column("NOT", Order = 8)]
        public ReasonCode? ReasonCode { get; set; }
    }
}

