using System;
using System.Collections.Generic;

namespace UDS.Net.Dto
{
    public class PacketSubmissionDto : BaseDto
    {
        public DateTime SubmissionDate { get; set; }

        public int ErrorCount { get; set; } = 0;

        public List<PacketSubmissionErrorDto> PacketSubmissionErrors { get; set; } = new List<PacketSubmissionErrorDto>();
    }
}

