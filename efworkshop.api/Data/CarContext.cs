using efworkshop.api.Model;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace efworkshop.api.Data
{
    public class CarContext : DbContext
    {
        private static string GetConnectionString()
        {
            string jsonSettings = File.ReadAllText("appsettings.json");
            JObject configuration = JObject.Parse(jsonSettings);
            return configuration["ConnectionStrings"]["DefaultConnectionString"].ToString();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {           
            optionsBuilder.UseNpgsql(GetConnectionString());

        }

        public DbSet<Car> Cars { get; set; }
    }
}
