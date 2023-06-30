using System;
using System.ComponentModel.DataAnnotations;

namespace UDS.Net.API.Entities
{
    /// <summary>
    /// Use NACC's website to download the Excel drug list and insert into this lookup table
    /// https://www.alz.washington.edu/MEMBER/DrugCodeLookUp.html
    /// </summary>
    public class DrugCodeLookup
    {
        [Key]
        [MaxLength(6)]
        public string DrugId { get; set; }

        [MaxLength(500)]
        public string DrugName { get; set; }

        [MaxLength(500)]
        public string? BrandName { get; set; }

        /// <summary>
        /// Indicates that the drug is available over the counter (it could also be available by prescription)
        /// </summary>
        public bool IsOverTheCounter { get; set; }

        /// <summary>
        /// Indicates that the drug should be displayed right away, instead of behind a search mechanism
        /// </summary>
        public bool IsPopular { get; set; }
    }
}

