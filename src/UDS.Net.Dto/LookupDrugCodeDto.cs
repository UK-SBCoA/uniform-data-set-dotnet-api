using System;
using System.Collections.Generic;

namespace UDS.Net.Dto
{
    public class LookupDrugCodeDto : LookupDto
    {
        public new List<DrugCodeDto> Results { get; set; }
    }
}

