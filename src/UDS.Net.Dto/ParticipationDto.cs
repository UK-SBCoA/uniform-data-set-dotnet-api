using System;
using System.Collections.Generic;

namespace UDS.Net.Dto
{
    public class ParticipationDto : BaseDto
    {
        public string LegacyId { get; set; }

        public IEnumerable<VisitDto> Visits { get; set; }

        public int LastVisitNumber { get; set; }

        public int VisitCount { get; set; }
    }
}

