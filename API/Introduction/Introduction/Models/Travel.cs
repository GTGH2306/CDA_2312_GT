using Microsoft.EntityFrameworkCore;
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
        public required DateTime TravelStartDate { get; set; }

        [Column("travel_end_date")]
        public DateTime? TravelEndDate { get; set; }


        [ForeignKey("CityStart")]
        [Column("travel_start_city_id")]
        [Required]
        public required int CityStartId { get; set; }
        public City? CityStart { get; set; }


        [ForeignKey("CityEnd")]
        [Column("travel_end_city_id")]
        [Required]
        public required int CityEndId { get; set; }
        public City? CityEnd { get; set; }

        [JsonIgnore]
        public ICollection<TravelsPeople>? TravelsPeople { get; set; }
    }
}