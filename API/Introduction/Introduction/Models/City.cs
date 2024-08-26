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
        public string CityCode { get; set; }

        [Column("city_name")]
        public string CityName { get; set; }

        [Column("country_id")]
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        [JsonIgnore]
        public Country? Country { get; set; }
    }
}
