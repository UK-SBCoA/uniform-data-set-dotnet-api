using System;
using System.Collections.Generic;
using System.Text;

namespace UDS.Net.Dto
{
    public class M1SubmissionErrorDto : BaseDto
    {
        public int M1SubmissionId { get; set; }

        public string FormKind { get; set; }

        public string Message { get; set; }

        public string AssignedTo { get; set; }

        public string Level { get; set; }

        public string StatusChangedBy { get; set; }

        public string Location { get; set; }

        public string Value { get; set; }

        public string Status { get; set; }
    }
}
