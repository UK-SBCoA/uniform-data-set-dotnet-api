using System;
using System.Collections.Generic;
using System.Text;
using UDS.Net.API.Entities;

namespace UDS.Net.Dto
{
    public class M1SubmissionDto : BaseDto
    {
        public DateTime SubmissionDate { get; set; }

        public int? ErrorCount { get; set; } // if the results haven't been returned then the error count will be null

        public List<M1SubmissionErrorDto> M1SubmissionErrors { get; set; } = new List<M1SubmissionErrorDto>();
    }
}