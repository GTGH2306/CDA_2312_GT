using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Introduction.Models
{
    [Table("people")]
    public class Person
    {
        [Key]
        [Column("person_id")]
        public int Id { get; set; }
        [Column("person_firstname")]
        [MaxLength(50)]
        [Required]
        public required string Firstname { get; set; }
        [Column("person_lastname")]
        [MaxLength(50)]
        [Required]
        public required string Lastname { get; set; }

        [JsonIgnore]
        public ICollection<TravelsPeople>? TravelsPeople { get; set; }
    }
}
