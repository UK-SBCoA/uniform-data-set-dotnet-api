using System;
using System.Collections.Generic;
using System.Text;

namespace UDS.Net.Dto
{
    public class LookupCountryCodeDto : LookupDto
    {
        public int Id { get; set; }

        public string? Code { get; set; }

        public string? Country { get; set; }

        public bool IsActive { get; set; }

        public string? ReasonChangedCode { get; set; }
    }
}
