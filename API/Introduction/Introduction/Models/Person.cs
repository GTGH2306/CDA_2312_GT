using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Introduction.Models
{
    [Table("people")]
    public class Person
    {
        [Key]
        [Column("person_id")]
        [Required]
        public int Id { get; set; }
        [Column("person_firstname")]
        [MaxLength(50)]
        [Required]
        public string Firstname { get; set; }
        [Column("person_lastname")]
        [MaxLength(50)]
        [Required]
        public string Lastname { get; set; }

    }
}
