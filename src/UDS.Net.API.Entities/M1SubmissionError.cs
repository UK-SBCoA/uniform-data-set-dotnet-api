using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UDS.Net.API.Entities
{
    public class M1SubmissionError : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("M1SubmissionErrorId", Order = 0)]
        public int Id { get; set; }

        [MaxLength(10)]
        public string? FormKind { get; set; } 

        [MaxLength(500)]
        public string? Message { get; set; }

        public string? AssignedTo { get; set; }

        public M1SubmissionErrorLevel? Level { get; set; }

        [MaxLength(50)]
        public string? Location { get; set; }

        [MaxLength(100)]
        public string? Value { get; set; }

        public M1SubmissionErrorStatus? Status { get; set; }

        public string? StatusChangedBy { get; set; }

        public M1Submission M1Submission { get; set; } = default!;

        public int M1SubmissionId { get; set; }
    }
}
