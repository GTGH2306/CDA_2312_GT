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
        public DbSet<Introduction.Models.Travel> Route { get; set; } = default!;


        ////WTF?
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Travel>()
        //            .HasRequired(m => m.CityStart)
        //            .WithMany(t => t.TravelStarts)
        //            .HasForeignKey(m => m.CityStartId)
        //            .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Travel>()
        //                .HasRequired(m => m.CityEnd)
        //                .WithMany(t => t.TravelEnds)
        //                .HasForeignKey(m => m.CityEndId)
        //                .WillCascadeOnDelete(false);
        //}

    }
}
