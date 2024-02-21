using System;
using System.Collections.Generic;

namespace UDS.Net.Dto
{
    public class A4Dto : FormDto
    {
        public int FormId { get; set; }

        public int? ANYMEDS { get; set; }

        public List<int> A4DetailsDtos { get; set; } = new List<int>();

    }
}

