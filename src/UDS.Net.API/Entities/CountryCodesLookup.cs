using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

//ISO 3166 -- Country Codes https://www.iso.org/glossary-for-iso-3166.html
namespace UDS.Net.API.Entities
{
    public class CountryCodesLookup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? Alpha3Code { get; set; }

        public string? Country { get; set; }

        public bool IsActive { get; set; }

        public string? Alpha4Code { get; set; }
    }
}
