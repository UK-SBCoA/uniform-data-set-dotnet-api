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

        [Column(Order = 1)]
        public int PacketId { get; set; }
        public Packet Packet { get; set; }

        [MaxLength(20)]
        [Column(Order = 2)]
        public string Status { get; set; } = default!;

        [Column("FRMDATE", Order = 3)]
        public DateTime FRMDATE { get; set; }

        [Column("INITIALS", Order = 4)]
        public string INITIALS { get; set; } = default!;
        [MaxLength(3)]

        [Column("LANG", Order = 5)]
        public Language? LANG { get; set; }

        [Column("MODE", Order = 6)]
        public FormMode? MODE { get; set; }

        [Column("RMREASON", Order = 7)]
        public RemoteReasonCode? RMREAS { get; set; }

        [Column("RMMODE", Order = 8)]
        public RemoteMode? RMMODE { get; set; }

        [Column("NOT", Order = 9)] // A2NOT, A4NOT, A4ANOT, B1NOT, B3NOT, B5NOT, B6NOT, B7NOT
        public NotIncludedReasonCode? NOT { get; set; }

        [Column("ADMIN", Order = 10)]
        public AdministrationFormat? ADMIN { get; set; }
    }
}

