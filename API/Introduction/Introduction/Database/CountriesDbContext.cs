using Introduction.Models;
using Microsoft.EntityFrameworkCore;

namespace Introduction.Database
{
    public class CountriesDbContext : DbContext
    {
        //on doit déclarer un modèle qu'on a utilisé en propriété
        public DbSet<Continent> Continents { get; set ;}
        public DbSet<Country> Countries { get; set; }

        //On doit réecrire cette méthode héritée de DbContext pour qu'entity puisse savoir l'adresse du serveur 
        protected override void OnConfiguring(DbContextOptionsBuilder _options)
        {
            //le port est facultatif si c'est le port par défaut
            _options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=db_countries_2312");
        }
        public DbSet<Introduction.Models.City> City { get; set; } = default!;
    }
}
