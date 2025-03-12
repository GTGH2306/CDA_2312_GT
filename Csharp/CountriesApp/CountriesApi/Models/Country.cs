using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountriesApi.Models
{
    public class Country
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "char")]
        [StringLength(2, ErrorMessage = "La longueur du code pays doit être strictement 2")]
        public string CountryCode { get; set; }

        [Required]
        public string CountryName { get; set; }
    }
}
