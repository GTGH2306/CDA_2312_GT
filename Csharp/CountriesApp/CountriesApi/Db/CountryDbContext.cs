using CountriesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CountriesApi.Db
{
    public class CountryDbContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=db_countries");
        }
    }
}
