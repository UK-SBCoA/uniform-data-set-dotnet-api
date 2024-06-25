using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UDS.Net.API.Entities
{
    [Table("tbl_Visits")]
    [Index(nameof(ParticipationId), nameof(VISITNUM), IsUnique = true)]
    public class Visit : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("VisitId")]
        public int Id { get; set; }

        public int ParticipationId { get; set; }

        [ForeignKey("ParticipationId")]
        public virtual Participation Participation { get; set; } = default!;

        [Column("VISITNUM")]
        public int VISITNUM { get; set; }

        [MaxLength(1)]
        [Column("PACKET")]
        public string PACKET { get; set; } = ""; // I, F

        [MaxLength(1)]
        [Column("FORMVER")]
        public string FORMVER { get; set; } = ""; // 4

        // Will you submit a Down Syndrome Module with this UDS visit?
        public int DSSDUB { get; set; } = 0;

        public DateTime VISIT_DATE { get; set; }

        [MaxLength(3)]
        public string INITIALS { get; set; } = default!;

        public virtual List<FormStatus> FormStatuses { get; set; } = default!;

        public virtual A1 A1 { get; set; } = default!; // A1 required for all visit kinds

        public virtual A1a A1a { get; set; } = default!; // A1a required at least for IVP

        public virtual A2 A2 { get; set; } = default!;

        public virtual A3 A3 { get; set; } = default!; // A3 required at least for IVP

        public virtual A4 A4 { get; set; } = default!; // A4 optional

        public virtual A4a A4a { get; set; } = default!; // A4a optional

        public virtual A5D2 A5D2 { get; set; } = default!; // A5D2 required at least for IVP

        public virtual B1 B1 { get; set; } = default!; // B1 required at least for IVP

        public virtual B3 B3 { get; set; } = default!; // B3 optional and only available or in-person

        public virtual B4 B4 { get; set; } = default!; // B4 required at least for IVP

        public virtual B5 B5 { get; set; } = default!; // B5 optional

        public virtual B6 B6 { get; set; } = default!; // B6 optional

        public virtual B7 B7 { get; set; } = default!; // B7 optional

        public virtual B8 B8 { get; set; } = default!; // B8 required at least for IVP

        public virtual B9 B9 { get; set; } = default!; // B9 required at least for IVP

        public virtual C1 C1 { get; set; } = default!; // not allowed?

        public virtual C2 C2 { get; set; } = default!; // C2 required at least for IVP

        public virtual D1a D1a { get; set; } = default!; // D1a required at least for IVP

        public virtual D1b D1b { get; set; } = default!; // D1b required at least for IVP

        public virtual T1? T1 { get; set; } // T1 only required for TIP, TFP visits
    }
}

