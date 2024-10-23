using System;
using System.Collections.Generic;

namespace UDS.Net.Dto
{
    public class PacketDto : VisitDto
    {
        public int PacketSubmissionCount { get; set; } = 0;

        public List<PacketSubmissionDto> PacketSubmissions { get; set; } = new List<PacketSubmissionDto>();
    }
}

