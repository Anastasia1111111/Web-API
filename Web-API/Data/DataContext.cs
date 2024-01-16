using Microsoft.EntityFrameworkCore;
using Web_API.Entities;

namespace Web_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) 
        {
            
        }

        public DbSet<AppUser> Users { get; set; }
    }
}
