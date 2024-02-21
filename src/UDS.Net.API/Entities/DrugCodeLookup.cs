using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UDS.Net.API.Entities
{
    /// <summary>
    /// RxNav should be used to find a drug and determine its RxNorm code
    /// https://lhncbc.nlm.nih.gov/RxNav/
    /// </summary>
    public class DrugCodeLookup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RxNormId { get; set; }

        [MaxLength(500)]
        public string DrugName { get; set; }

        [MaxLength(500)]
        public string? BrandNames { get; set; }

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

