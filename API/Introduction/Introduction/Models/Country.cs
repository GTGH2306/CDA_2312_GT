using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Introduction.Models
{
    [Table("country")]
    public class Country
    {
        [Key]
        [Column("country_id")]
        public int Id { get; set; }

        [Column("country_name")]
        public string CountryName { get; set; }

        [Column("country_code", TypeName = "char(2)")]
        public string CountryCode { get; set; }
        /*
        Pour ajouter une clée étrangère on ajoute un objet nullable du type du modèle étrangé
        Ensuite on ajoute une annotation ForeignKey sur un int nullable représentant l'id de l'objet étrangé
        On ajoute aussi l'annotation JsonIgnore pour dire qu'on indique en fait seulement l'id de l'objet 
        */
        [Column("continent_id")]
        [ForeignKey("Continent")]
        public int ContinentId { get; set; }
        [JsonIgnore]
        public Continent? Continent { get; set; }
        
        public ICollection<City>? Cities { get; set; }

    }
}
