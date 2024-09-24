using Document_Management_Backend.Model;
using Microsoft.EntityFrameworkCore;

namespace Document_Management_Backend.Context
{
    public class DMDbContext : DbContext
    {

        public DMDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);

        }
    }
} 
