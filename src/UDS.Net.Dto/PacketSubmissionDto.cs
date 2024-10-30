using System;
using System.Collections.Generic;

namespace UDS.Net.Dto
{
    public class PacketSubmissionDto : BaseDto
    {
        public int PacketId { get; set; }

        public DateTime SubmissionDate { get; set; }

        public int? ErrorCount { get; set; } // if the results haven't been returned then the error count will be null

        public List<PacketSubmissionErrorDto> PacketSubmissionErrors { get; set; } = new List<PacketSubmissionErrorDto>();

        public List<FormDto> Forms { get; set; } = new List<FormDto>(); // temporal state of forms at time of submission
    }
}

