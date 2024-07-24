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
        public string FormKind { get; set; }

        [MaxLength(500)]
        public string Message { get; set; }

        public string AssignedTo { get; set; }

        public PacketSubmissionErrorLevel Level { get; set; }

        public string ResolvedBy { get; set; }
    }
}

