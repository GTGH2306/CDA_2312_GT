using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Introduction.Models
{
    [PrimaryKey(nameof(TravelId), nameof(PersonId))]
    [Table("travels_people")]
    public class TravelsPeople
    {
        [ForeignKey("Travel")]
        [Column("travel_id")]
        [Required]
        public required int TravelId { get; set; }
        public Travel? Travel { get; set; }


        [ForeignKey("Person")]
        [Column("person_id")]
        [Required]
        public required int PersonId { get; set; }
        public Person? Person { get; set; }

        [Column("driver")]
        public bool IsDriver { get; set; }

    }
}
