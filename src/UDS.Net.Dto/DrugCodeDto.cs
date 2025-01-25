using System;
namespace UDS.Net.Dto
{
    public class DrugCodeDto
    {
        public int RxNormId { get; set; }

        public string DrugName { get; set; }

        public string? BrandName { get; set; }

        public bool IsOverTheCounter { get; set; }

        public bool IsPopular { get; set; }
    }
}

