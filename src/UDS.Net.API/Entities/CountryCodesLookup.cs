using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UDS.Net.API.Entities
{
    public class CountryCodesLookup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string? Code { get; set; }

        public string? Country { get; set; }
    }
}
