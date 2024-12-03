using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UDS.Net.API.Entities
{
    public class CountryCodesLookup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? Code { get; set; }

        public string? Country { get; set; }

        public bool IsActive { get; set; }
    }
}
