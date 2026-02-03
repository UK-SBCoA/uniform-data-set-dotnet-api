using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UDS.Net.API.Entities
{
    public class M1Submission : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("MilestoneSubmissionId", Order = 0)]
        public int Id { get; set; }

        public DateTime SubmissionDate { get; set; }

        public M1 M1 { get; set; } = default!;

        public int PacketId { get; set; }

        public int? ErrorCount { get; set; } // null means no results yet, 0 means no errors

        public List<M1SubmissionError> M1SubmissionErrors { get; set; } = new List<M1SubmissionError>();
    }
}