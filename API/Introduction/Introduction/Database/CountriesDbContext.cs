using Introduction.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

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
        public DbSet<Introduction.Models.Person> Person { get; set; } = default!;
        public DbSet<Introduction.Models.Travel> Travels { get; set; } = default!;
        public DbSet<Introduction.Models.TravelsPeople> TravelsPeople { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            modelBuilder.Entity<Travel>()
                //indique que dans Travel CityStart est le côté One de la relation
                .HasOne(t => t.CityStart)
                //indique que dans City TravelsStarts est le côté Many de la relation
                .WithMany(c => c.TravelStarts)
                //Indique que dans Travel CityStartId est la clé étrangère
                .HasForeignKey(t => t.CityStartId)
                //Demande de ne pas faire de suppression en cascade car risque de boucle infini
                .OnDelete(DeleteBehavior.Restrict);



            modelBuilder.Entity<Travel>()

                .HasOne(t => t.CityEnd)

                .WithMany(c => c.TravelEnds)

                .HasForeignKey(t => t.CityEndId)

                .OnDelete(DeleteBehavior.Restrict);



            base.OnModelCreating(modelBuilder);

        }
    }
}
