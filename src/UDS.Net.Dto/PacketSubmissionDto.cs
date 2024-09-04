using System;
using System.Collections.Generic;

namespace UDS.Net.Dto
{
    public class PacketSubmissionDto : BaseDto
    {
        public int VisitId { get; set; }

        public DateTime SubmissionDate { get; set; }

        public int ErrorCount { get; set; } = 0;

        public List<PacketSubmissionErrorDto> PacketSubmissionErrors { get; set; } = new List<PacketSubmissionErrorDto>();

        public A1Dto A1 { get; set; }

        public A1aDto A1a { get; set; }

        public A2Dto A2 { get; set; }

        public A3Dto A3 { get; set; }

        public A4Dto A4 { get; set; }

        public A4aDto A4a { get; set; }

        public A5D2Dto A5D2 { get; set; }

        public B1Dto B1 { get; set; }

        public B3Dto B3 { get; set; }

        public B4Dto B4 { get; set; }

        public B5Dto B5 { get; set; }

        public B6Dto B6 { get; set; }

        public B7Dto B7 { get; set; }

        public B8Dto B8 { get; set; }

        public B9Dto B9 { get; set; }

        public C2Dto C2 { get; set; }

        public D1aDto D1a { get; set; }

        public D1bDto D1b { get; set; }
    }
}

