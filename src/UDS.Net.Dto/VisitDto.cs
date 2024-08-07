﻿using System;
using System.Collections.Generic;

namespace UDS.Net.Dto
{
    public class VisitDto : BaseDto
    {
        public int ParticipationId { get; set; }

        public int VISITNUM { get; set; }

        public string PACKET { get; set; } = "";

        public string FORMVER { get; set; } = "";

        public DateTime VISIT_DATE { get; set; }

        public string INITIALS { get; set; } = "";

        public List<FormDto> Forms { get; set; }
    }
}

