using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Introduction.Models
{
    //ça au dessus d'un élement permet d'indiquer le nom qu'on veux utiliser en BDD
    [Table("continent")]
    public class Continent
    {
        /*
         clé primaire va être soit
        public int Id
        soir
        public int Continent
         */
        //Pour indiquer que c'est bien la clé primaire
        [Key]
        [Column("continent_id")]
        [Required]
        public int Id { get; set; }

        //Les anotations liés à une contrainte peuvent avoir un message d'erreur personnalisé
        [MaxLength(20, ErrorMessage = "Un continent doit contenir 20 caractères maximum")]
        [MinLength(2)]
        [Column("continent_name")]
        [Required]
        public string ContinentName { get; set; }

        [Column("continent_area")]
        [Required]
        public int ContinentArea { get; set; }
        //Rendre nullable pour ne pas avoir à envoyer une liste de pays à la création d'un continent
        public ICollection<Country>? Countries { get; set; }
    }
}
