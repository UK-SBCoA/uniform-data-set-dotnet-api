using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;

namespace UDS.Net.API.Entities
{
    /// <summary>
    /// Visit's data bundled and submitted to NACC is called "packet"
    /// </summary>
    public class PacketSubmission : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PacketSubmissionId", Order = 0)]
        public int Id { get; set; }

        public DateTime SubmissionDate { get; set; }

        public Visit Visit { get; set; } = default!;

        public int VisitId { get; set; }
    }
}

