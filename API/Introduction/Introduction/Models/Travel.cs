using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Introduction.Models
{
    [Table("travel")]
    public class Travel
    {
        [Key]
        [Column("travel_id")]
        public int Id { get; set; }

        [Column("travel_start_date")]
        [Required]
        public DateTime TravelStartDate { get; set; }

        [Column("travel_end_date")]
        public DateTime TravelEndDate { get; set; }



        [Column("travel_start_city_id")]
        [Required]
        public int CityStartId { get; set; }
        [ForeignKey("CityStartId")]
        [JsonIgnore]
        public City? CityStart { get; set; }



        [Column("travel_end_city_id")]
        [Required]
        public int CityEndId { get; set; }
        [ForeignKey("CityEndId")]
        [JsonIgnore]
        public City? CityEnd { get; set; }
    }
}