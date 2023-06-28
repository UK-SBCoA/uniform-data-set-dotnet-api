using System;
using System.Collections.Generic;

namespace UDS.Net.Dto
{
    public class LookupDto
    {
        public string LookupType { get; set; }

        public string SearchTerm { get; set; }
        public object LookupParameters { get; set; }

        public List<object> Results { get; set; }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public int TotalResultsCount { get; set; }

        public ErrorDto Error { get; set; }

    }
}

