using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Introduction.Models
{
    [Table("city")]
    public class City
    {
        [Key]
        [Column("city_id")]
        public int Id { get; set; }

        [Column("city_code", TypeName = "char(8)")]
        [Required]
        public required string CityCode { get; set; }

        [Column("city_name")]
        [Required]
        public required string CityName { get; set; }

        [Column("country_id")]
        [ForeignKey("Country")]
        [Required]
        public int CountryId { get; set; }
        [JsonIgnore]
        public Country? Country { get; set; }

        [JsonIgnore]
        public ICollection<Travel>? TravelStarts { get; set; }
        [JsonIgnore]
        public ICollection<Travel>? TravelEnds { get; set; }
    }
}
