using Microsoft.EntityFrameworkCore;
using MVCRegistration;

namespace web2.Models.AppDbContext
{
    public class AppDbContext : DbContext
    {
        
        private readonly DbContextOptions _options;

        public AppDbContext(DbContextOptions options) : base(options)
        {
            _options = options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
