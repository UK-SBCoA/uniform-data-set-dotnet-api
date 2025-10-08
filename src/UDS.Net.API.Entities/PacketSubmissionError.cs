using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UDS.Net.API.Entities
{
    public class PacketSubmissionError : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PacketSubmissionErrorId", Order = 0)]
        public int Id { get; set; }

        [MaxLength(10)]
        public string? FormKind { get; set; } // it might be possible for an error to be at the visit and not a specific form

        [MaxLength(500)]
        public string Message { get; set; }

        public string? AssignedTo { get; set; }

        public PacketSubmissionErrorLevel Level { get; set; }

        public string? ResolvedBy { get; set; }

        public PacketSubmission PacketSubmission { get; set; } = default!;

        public int PacketSubmissionId { get; set; }
        [MaxLength(50)]
        public string? Location { get; set; }
        [MaxLength(100)]
        public string? Value { get; set; }
        public bool IgnoreStatus { get; set; }
    }
}

