using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace api.Models
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<Vehicle> Vehicles { get; set; } = null!;
    }
}
