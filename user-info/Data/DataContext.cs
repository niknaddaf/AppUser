using Microsoft.EntityFrameworkCore;
using user_info.Entities;

namespace user_info.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users{ get; set; }
    }
}
