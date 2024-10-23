using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public int? UnresolvedErrorCount { get; set; } // null means no results yet, 0 means no errors

        public List<PacketSubmissionError> PacketSubmissionErrors { get; set; } = new List<PacketSubmissionError>();
    }
}

