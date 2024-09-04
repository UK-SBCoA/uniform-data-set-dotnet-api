using System;
using System.Collections.Generic;

namespace UDS.Net.Dto
{
    public class PacketSubmissionFormsDto : List<FormDto>
    {
        // The time period when the data was submitted
        public DateTime Period { get; set; }

    }
}

