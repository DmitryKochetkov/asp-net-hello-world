using System.Data.Common;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace CitiesAndRestaurants.Model
{
    public class AppContext: DbContext
    {
        public AppContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            using (var fileStream = File.OpenRead("connectionString.txt"))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true))
            {
                string line = streamReader.ReadLine();
                optionsBuilder
                        .UseNpgsql(line)
                        .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            }
             
        }

        public DbSet<City> CityItems { get; set; }
        public DbSet<Restaurant> RestaurantItems { get; set; }
    }
}